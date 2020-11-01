using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace SingleThreadedSynchronizationContextDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoContext context = null;

            if (args.Length == 1)
            {
                context = new LimitedConcurrencySynchronizationContext(uint.Parse(args[0]));
            }
            else
            {
                context = new SingleThreadedSynchronizationContext();
            }

            //
            // Could be improved but stealing a thread from thread pool
            //
            var thread = Task.Run(context.RunOnCurrentThread);

            QueueProcessor processor = new QueueProcessor();
            var consumer = processor.ProcessingAsync(context);

            var producer = Task.Run(() =>
            {
                while (true)
                {
                    processor.Queue("Hello!");
                }
            });

            // var cesp = new ConcurrentExclusiveSchedulerPair();
            //
            // var producer = Task.Factory.StartNew(async () =>
            // {
            //     while (true)
            //     {
            //         processor.Queue("Hello!");
            //     }
            // }, default, TaskCreationOptions.None, cesp.ExclusiveScheduler);

            Console.ReadKey();
        }

        public class QueueProcessor
        {
            private readonly BlockingCollection<string> queue = new BlockingCollection<string>();

            public Task ProcessingAsync(SynchronizationContext? context = null)
            {
                return Task.Factory.StartNew(async () =>
                {
                    if (context != null)
                    {
                        SynchronizationContext.SetSynchronizationContext(context);
                    }

                    foreach (var item in queue.GetConsumingEnumerable())
                    {
                        await ProcessItemAsync(item);
                    }
                }, 
                        TaskCreationOptions.LongRunning) // Long running hint will place this on a dedicated thread
                                                         // but this can be removed and it will still run on a dedicated thread after first await
                    .Unwrap();
            }

            public void Queue(string str) => queue.Add(str);

            private async Task ProcessItemAsync(string item)
            {
                var thread = Thread.CurrentThread;
                string threadType = thread.IsThreadPoolThread ? "ThreadPool" : "not ThreadPool";
                Console.WriteLine($"Processing {item} on thread {thread.ManagedThreadId} from {threadType}");
                await Task.Delay(item.Length * 100);
                Console.WriteLine($"Processed {item} on thread {thread.ManagedThreadId} from {threadType}");
            }
        }

        private abstract class DemoContext: SynchronizationContext
        {
            public abstract void RunOnCurrentThread();
        }

        private sealed class SingleThreadedSynchronizationContext : DemoContext
        {
            private readonly BlockingCollection<(SendOrPostCallback callback, object? arg)> queue =
                new BlockingCollection<(SendOrPostCallback callback, object? arg)>();

            /// <summary>
            /// Post continuation somewhere 
            /// </summary>
            /// <param name="d"></param>
            /// <param name="state"></param>
            public override void Post(SendOrPostCallback d, object? state)
            {
                queue.Add((d, state));
            }

            public override void RunOnCurrentThread()
            {
                var thread = Thread.CurrentThread;
                string threadType = thread.IsThreadPoolThread ? "ThreadPool" : "not ThreadPool";
                Console.WriteLine(($"RunOnCurrentThread started on thread {thread.ManagedThreadId} from {threadType}"));
                SetSynchronizationContext(this);

                //
                // endlessly waiting
                // take items from a queue and executing a same specific thread.  Not the thread pool
                //
                foreach (var workItem in queue.GetConsumingEnumerable())
                {
                    workItem.callback(workItem.arg);
                }
            }
        }


        private sealed class LimitedConcurrencySynchronizationContext : DemoContext
        {
            private readonly SemaphoreSlim semaphore;

            private readonly BlockingCollection<(SendOrPostCallback callback, object? arg)> queue =
                new BlockingCollection<(SendOrPostCallback callback, object? arg)>();


            public LimitedConcurrencySynchronizationContext(uint maximumConcurrency) =>
                semaphore = new SemaphoreSlim((int) maximumConcurrency);

            /// <summary>
            /// Post continuation somewhere 
            /// </summary>
            /// <param name="d"></param>
            /// <param name="state"></param>
            public override void Post(SendOrPostCallback d, object? state)
            {
                semaphore.WaitAsync().ContinueWith(delegate
                {
                    try
                    {
                        queue.Add((d, state));
                    }
                    finally
                    {
                        semaphore.Release();
                    }
                }, 
                    default, 
                    TaskContinuationOptions.None, 
                    TaskScheduler.Default);

                
            }

            public override void RunOnCurrentThread()
            {
                var thread = Thread.CurrentThread;
                string threadType = thread.IsThreadPoolThread ? "ThreadPool" : "not ThreadPool";
                Console.WriteLine(($"RunOnCurrentThread started on thread {thread.ManagedThreadId} from {threadType}"));
                SetSynchronizationContext(this);

                //
                // endlessly waiting
                // take items from a queue and executing a same specific thread.  Not the thread pool
                //
                foreach (var workItem in queue.GetConsumingEnumerable())
                {
                    workItem.callback(workItem.arg);
                }
            }
        }
    }
}
