``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1082 (1909/November2018Update/19H2)
Intel Core i9-9880H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=5.0.100-rc.1.20452.10
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.45114, CoreFX 5.0.20.45114), X64 RyuJIT
  Job-XCPACC : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT
  Job-WZCRYQ : .NET Core 5.0.0 (CoreCLR 5.0.20.45114, CoreFX 5.0.20.45114), X64 RyuJIT


```
|                   Method |        Job |       Runtime |     Toolchain |  n |              Mean |           Error |            StdDev | Ratio | RatioSD | Code Size | Allocated native memory | Native memory leak |
|------------------------- |----------- |-------------- |-------------- |--- |------------------:|----------------:|------------------:|------:|--------:|----------:|------------------------:|-------------------:|
|                **Recursive** | **Job-XCPACC** | **.NET Core 3.1** | **netcoreapp3.1** | **15** |      **2,433.662 ns** |      **46.3881 ns** |        **45.5593 ns** | **1.000** |    **0.00** |      **76 B** |                     **1 B** |                **1 B** |
| RecursiveWithMemoization | Job-XCPACC | .NET Core 3.1 | netcoreapp3.1 | 15 |         78.191 ns |       1.5828 ns |         2.5106 ns | 0.032 |    0.00 |     212 B |                       - |                  - |
|                Iterative | Job-XCPACC | .NET Core 3.1 | netcoreapp3.1 | 15 |          9.191 ns |       0.2173 ns |         0.3630 ns | 0.004 |    0.00 |      58 B |                       - |                  - |
|                Recursive | Job-WZCRYQ | .NET Core 5.0 |  netcoreapp50 | 15 |      2,451.136 ns |      41.1495 ns |        42.2576 ns | 1.007 |    0.02 |      76 B |                       - |                  - |
| RecursiveWithMemoization | Job-WZCRYQ | .NET Core 5.0 |  netcoreapp50 | 15 |         91.353 ns |       1.8209 ns |         2.0970 ns | 0.038 |    0.00 |     204 B |                       - |                  - |
|                Iterative | Job-WZCRYQ | .NET Core 5.0 |  netcoreapp50 | 15 |         14.801 ns |       0.3169 ns |         0.3254 ns | 0.006 |    0.00 |      58 B |                       - |                  - |
|                          |            |               |               |    |                   |                 |                   |       |         |           |                         |                    |
|                **Recursive** | **Job-XCPACC** | **.NET Core 3.1** | **netcoreapp3.1** | **35** | **42,742,518.864 ns** | **903,802.5708 ns** | **2,534,359.3071 ns** | **1.000** |    **0.00** |      **76 B** |                  **2262 B** |              **222 B** |
| RecursiveWithMemoization | Job-XCPACC | .NET Core 3.1 | netcoreapp3.1 | 35 |        204.089 ns |       4.0569 ns |         7.8162 ns | 0.000 |    0.00 |     212 B |                       - |                  - |
|                Iterative | Job-XCPACC | .NET Core 3.1 | netcoreapp3.1 | 35 |         25.665 ns |       0.7267 ns |         2.1312 ns | 0.000 |    0.00 |      58 B |                       - |                  - |
|                Recursive | Job-WZCRYQ | .NET Core 5.0 |  netcoreapp50 | 35 | 38,716,453.333 ns | 770,912.1990 ns | 1,861,839.6076 ns | 0.908 |    0.08 |      76 B |                   152 B |               66 B |
| RecursiveWithMemoization | Job-WZCRYQ | .NET Core 5.0 |  netcoreapp50 | 35 |        232.973 ns |       4.6441 ns |         8.8359 ns | 0.000 |    0.00 |     204 B |                       - |                  - |
|                Iterative | Job-WZCRYQ | .NET Core 5.0 |  netcoreapp50 | 35 |         22.988 ns |       0.4989 ns |         0.8605 ns | 0.000 |    0.00 |      58 B |                       - |                  - |
