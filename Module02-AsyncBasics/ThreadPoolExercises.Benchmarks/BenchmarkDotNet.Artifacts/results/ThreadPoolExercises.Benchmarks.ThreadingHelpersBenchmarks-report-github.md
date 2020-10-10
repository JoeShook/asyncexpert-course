``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1082 (1909/November2018Update/19H2)
Intel Core i9-9880H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=5.0.100-rc.1.20452.10
  [Host]     : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT
  Job-XCUDBM : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT
  Job-VXRISX : .NET Core 5.0.0 (CoreCLR 5.0.20.45114, CoreFX 5.0.20.45114), X64 RyuJIT


```
|               Method |        Job |       Runtime |     Toolchain |       Mean |     Error |    StdDev | Ratio | RatioSD |
|--------------------- |----------- |-------------- |-------------- |-----------:|----------:|----------:|------:|--------:|
| ExecuteSynchronously | Job-XCUDBM | .NET Core 3.1 | netcoreapp3.1 |   4.419 μs | 0.0822 μs | 0.0769 μs |  1.00 |    0.00 |
| ExecuteSynchronously | Job-VXRISX | .NET Core 5.0 | netcoreapp5.0 |   4.378 μs | 0.0875 μs | 0.1282 μs |  1.01 |    0.04 |
|                      |            |               |               |            |           |           |       |         |
|      ExecuteOnThread | Job-XCUDBM | .NET Core 3.1 | netcoreapp3.1 | 228.727 μs | 4.5616 μs | 9.6219 μs |  1.00 |    0.00 |
|      ExecuteOnThread | Job-VXRISX | .NET Core 5.0 | netcoreapp5.0 | 219.265 μs | 4.3849 μs | 8.6554 μs |  0.96 |    0.05 |
|                      |            |               |               |            |           |           |       |         |
|  ExecuteOnThreadPool | Job-XCUDBM | .NET Core 3.1 | netcoreapp3.1 |  12.477 μs | 0.2493 μs | 0.6479 μs |  1.00 |    0.00 |
|  ExecuteOnThreadPool | Job-VXRISX | .NET Core 5.0 | netcoreapp5.0 |  11.888 μs | 0.2185 μs | 0.2516 μs |  0.91 |    0.04 |
