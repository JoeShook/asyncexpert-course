using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;

namespace Dotnetos.AsyncExpert.Homework.Module01.Benchmark
{
    [DisassemblyDiagnoser(exportCombinedDisassemblyReport: true)]
    [NativeMemoryProfiler]
    public class FibonacciCalc
    {
        // HOMEWORK:
        // 1. Write implementations for RecursiveWithMemoization and Iterative solutions
        // 2. Add MemoryDiagnoser to the benchmark
        // 3. Run with release configuration and compare results
        // 4. Open disassembler report and compare machine code
        // 
        // You can use the discussion panel to compare your results with other students

        [Benchmark(Baseline = true)]
        [ArgumentsSource(nameof(Data))]
        public ulong Recursive(ulong n)
        {
            if (n == 1 || n == 2) return 1;
            return Recursive(n - 2) + Recursive(n - 1);
        }

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public ulong RecursiveWithMemoization(ulong n)
        {
            var fibs = new ulong[n + 1];

            return RecursiveMemoized(n, fibs);
        }

        private static ulong RecursiveMemoized(ulong n, ulong[] fibs)
        {
            if (fibs[n] != 0)
            {
                return fibs[n];
            }
            
            if (n == 1 || n == 2) return 1;

            fibs[n] = RecursiveMemoized(n - 2, fibs) + RecursiveMemoized(n - 1, fibs);

            return fibs[n];
        }

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public ulong Iterative(ulong n)
        {
            if (n == 1 || n == 2) return 1;

            ulong a = 0;
            ulong b = 1;
            
            for (ulong i = 0; i < n; i++)
            {
                ulong temp = a;
                a = b;
                b = temp + b;
            }

            return a;
        }

        public IEnumerable<ulong> Data()
        {
            yield return 15;
            yield return 35;
        }
    }
}
