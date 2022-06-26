## HashSet

### Source
[HashSet.cs](../../src/StructLinq.Benchmark/HashSet.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]             : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  .NET 5.0           : .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT
  .NET 6.0           : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  .NET Framework 4.8 : .NET Framework 4.8 (4.8.4515.0), X64 RyuJIT


```
|     Method |                Job |            Runtime | ItemCount |         Mean |      Error |     StdDev | Ratio | Allocated |
|----------- |------------------- |------------------- |---------- |-------------:|-----------:|-----------:|------:|----------:|
|       **LINQ** |           **.NET 5.0** |           **.NET 5.0** |         **2** |     **6.813 ns** |  **0.0302 ns** |  **0.0283 ns** |  **0.47** |         **-** |
| StructLINQ |           .NET 5.0 |           .NET 5.0 |         2 |     4.238 ns |  0.0086 ns |  0.0067 ns |  0.29 |         - |
|       LINQ |           .NET 6.0 |           .NET 6.0 |         2 |     7.143 ns |  0.0301 ns |  0.0281 ns |  0.49 |         - |
| StructLINQ |           .NET 6.0 |           .NET 6.0 |         2 |     3.677 ns |  0.0152 ns |  0.0142 ns |  0.25 |         - |
|       LINQ | .NET Framework 4.8 | .NET Framework 4.8 |         2 |    14.554 ns |  0.0387 ns |  0.0302 ns |  1.00 |         - |
| StructLINQ | .NET Framework 4.8 | .NET Framework 4.8 |         2 |     4.513 ns |  0.0246 ns |  0.0231 ns |  0.31 |         - |
|            |                    |                    |           |              |            |            |       |           |
|       **LINQ** |           **.NET 5.0** |           **.NET 5.0** |       **100** |   **239.636 ns** |  **0.6109 ns** |  **0.5416 ns** |  **0.80** |         **-** |
| StructLINQ |           .NET 5.0 |           .NET 5.0 |       100 |   139.839 ns |  0.2739 ns |  0.2287 ns |  0.47 |         - |
|       LINQ |           .NET 6.0 |           .NET 6.0 |       100 |   266.609 ns |  1.1347 ns |  0.8859 ns |  0.90 |         - |
| StructLINQ |           .NET 6.0 |           .NET 6.0 |       100 |    60.589 ns |  0.1978 ns |  0.1851 ns |  0.20 |         - |
|       LINQ | .NET Framework 4.8 | .NET Framework 4.8 |       100 |   297.821 ns |  0.6454 ns |  0.6037 ns |  1.00 |         - |
| StructLINQ | .NET Framework 4.8 | .NET Framework 4.8 |       100 |   111.044 ns |  0.5202 ns |  0.4866 ns |  0.37 |         - |
|            |                    |                    |           |              |            |            |       |           |
|       **LINQ** |           **.NET 5.0** |           **.NET 5.0** |      **1000** | **2,082.016 ns** | **14.5452 ns** | **12.1459 ns** |  **0.73** |         **-** |
| StructLINQ |           .NET 5.0 |           .NET 5.0 |      1000 | 1,026.598 ns |  3.1034 ns |  2.7511 ns |  0.36 |         - |
|       LINQ |           .NET 6.0 |           .NET 6.0 |      1000 | 2,564.475 ns |  4.0716 ns |  3.6094 ns |  0.90 |         - |
| StructLINQ |           .NET 6.0 |           .NET 6.0 |      1000 |   523.430 ns |  7.3381 ns |  5.7291 ns |  0.18 |         - |
|       LINQ | .NET Framework 4.8 | .NET Framework 4.8 |      1000 | 2,861.785 ns | 25.1865 ns | 21.0319 ns |  1.00 |         - |
| StructLINQ | .NET Framework 4.8 | .NET Framework 4.8 |      1000 | 1,072.498 ns | 21.1196 ns | 22.5977 ns |  0.37 |         - |
