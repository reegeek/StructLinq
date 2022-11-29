## HashSet

### Source
[HashSet.cs](../../src/StructLinq.Benchmark/HashSet.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]             : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  .NET 6.0           : .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
  .NET 7.0           : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  .NET Framework 4.8 : .NET Framework 4.8.1 (4.8.9105.0), X64 RyuJIT VectorSize=256


```
|     Method |                Job |            Runtime | ItemCount |         Mean |      Error |    StdDev | Ratio | Allocated | Alloc Ratio |
|----------- |------------------- |------------------- |---------- |-------------:|-----------:|----------:|------:|----------:|------------:|
|       **LINQ** |           **.NET 6.0** |           **.NET 6.0** |         **2** |     **6.470 ns** |  **0.0263 ns** | **0.0246 ns** |  **0.43** |         **-** |          **NA** |
| StructLINQ |           .NET 6.0 |           .NET 6.0 |         2 |     3.750 ns |  0.0232 ns | 0.0217 ns |  0.25 |         - |          NA |
|       LINQ |           .NET 7.0 |           .NET 7.0 |         2 |     7.097 ns |  0.0523 ns | 0.0463 ns |  0.48 |         - |          NA |
| StructLINQ |           .NET 7.0 |           .NET 7.0 |         2 |     2.298 ns |  0.0153 ns | 0.0143 ns |  0.15 |         - |          NA |
|       LINQ | .NET Framework 4.8 | .NET Framework 4.8 |         2 |    14.879 ns |  0.0524 ns | 0.0490 ns |  1.00 |         - |          NA |
| StructLINQ | .NET Framework 4.8 | .NET Framework 4.8 |         2 |     3.661 ns |  0.0309 ns | 0.0274 ns |  0.25 |         - |          NA |
|            |                    |                    |           |              |            |           |       |           |             |
|       **LINQ** |           **.NET 6.0** |           **.NET 6.0** |       **100** |   **263.520 ns** |  **1.2710 ns** | **1.1889 ns** |  **0.88** |         **-** |          **NA** |
| StructLINQ |           .NET 6.0 |           .NET 6.0 |       100 |    59.400 ns |  0.2631 ns | 0.2461 ns |  0.20 |         - |          NA |
|       LINQ |           .NET 7.0 |           .NET 7.0 |       100 |   240.658 ns |  0.4676 ns | 0.3905 ns |  0.81 |         - |          NA |
| StructLINQ |           .NET 7.0 |           .NET 7.0 |       100 |   106.481 ns |  0.5253 ns | 0.4101 ns |  0.36 |         - |          NA |
|       LINQ | .NET Framework 4.8 | .NET Framework 4.8 |       100 |   298.331 ns |  1.2307 ns | 1.0909 ns |  1.00 |         - |          NA |
| StructLINQ | .NET Framework 4.8 | .NET Framework 4.8 |       100 |   135.522 ns |  0.5826 ns | 0.5165 ns |  0.45 |         - |          NA |
|            |                    |                    |           |              |            |           |       |           |             |
|       **LINQ** |           **.NET 6.0** |           **.NET 6.0** |      **1000** | **2,530.097 ns** |  **8.5344 ns** | **7.9831 ns** |  **0.90** |         **-** |          **NA** |
| StructLINQ |           .NET 6.0 |           .NET 6.0 |      1000 |   516.871 ns |  3.5900 ns | 2.9978 ns |  0.18 |         - |          NA |
|       LINQ |           .NET 7.0 |           .NET 7.0 |      1000 | 2,319.758 ns |  8.4753 ns | 7.9278 ns |  0.82 |         - |          NA |
| StructLINQ |           .NET 7.0 |           .NET 7.0 |      1000 | 1,018.004 ns |  4.0234 ns | 3.7635 ns |  0.36 |         - |          NA |
|       LINQ | .NET Framework 4.8 | .NET Framework 4.8 |      1000 | 2,825.801 ns |  8.9413 ns | 8.3637 ns |  1.00 |         - |          NA |
| StructLINQ | .NET Framework 4.8 | .NET Framework 4.8 |      1000 | 1,309.649 ns | 10.6553 ns | 9.4456 ns |  0.46 |         - |          NA |
