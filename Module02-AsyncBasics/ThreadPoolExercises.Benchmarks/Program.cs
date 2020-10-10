using System;
using System.Reflection;
using BenchmarkDotNet.Running;

namespace ThreadPoolExercises.Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            //BenchmarkRunner.Run<ThreadingHelpersBenchmarks>();
            BenchmarkSwitcher.FromAssembly(Assembly.GetExecutingAssembly()).Run(args);
        }
    }
}
