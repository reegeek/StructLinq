## Dictionary

### Source
[Dictionary.cs](../../src/StructLinq.Benchmark/Dictionary.cs)

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
|     Method |                Job |            Runtime | ItemCount |         Mean |      Error |     StdDev | Ratio | Allocated | Alloc Ratio |
|----------- |------------------- |------------------- |---------- |-------------:|-----------:|-----------:|------:|----------:|------------:|
|       **LINQ** |           **.NET 6.0** |           **.NET 6.0** |         **2** |    **17.734 ns** |  **0.0472 ns** |  **0.0419 ns** |  **0.71** |         **-** |          **NA** |
| StructLINQ |           .NET 6.0 |           .NET 6.0 |         2 |     3.596 ns |  0.0184 ns |  0.0172 ns |  0.14 |         - |          NA |
|       LINQ |           .NET 7.0 |           .NET 7.0 |         2 |    17.767 ns |  0.0622 ns |  0.0552 ns |  0.71 |         - |          NA |
| StructLINQ |           .NET 7.0 |           .NET 7.0 |         2 |     2.522 ns |  0.0209 ns |  0.0196 ns |  0.10 |         - |          NA |
|       LINQ | .NET Framework 4.8 | .NET Framework 4.8 |         2 |    24.985 ns |  0.0964 ns |  0.0902 ns |  1.00 |         - |          NA |
| StructLINQ | .NET Framework 4.8 | .NET Framework 4.8 |         2 |     4.897 ns |  0.0294 ns |  0.0260 ns |  0.20 |         - |          NA |
|            |                    |                    |           |              |            |            |       |           |             |
|       **LINQ** |           **.NET 6.0** |           **.NET 6.0** |       **100** |   **406.131 ns** |  **1.3808 ns** |  **1.1531 ns** |  **0.91** |         **-** |          **NA** |
| StructLINQ |           .NET 6.0 |           .NET 6.0 |       100 |   132.867 ns |  0.4359 ns |  0.4077 ns |  0.30 |         - |          NA |
|       LINQ |           .NET 7.0 |           .NET 7.0 |       100 |   341.778 ns |  0.8536 ns |  0.7984 ns |  0.76 |         - |          NA |
| StructLINQ |           .NET 7.0 |           .NET 7.0 |       100 |    82.047 ns |  0.3348 ns |  0.2796 ns |  0.18 |         - |          NA |
|       LINQ | .NET Framework 4.8 | .NET Framework 4.8 |       100 |   446.860 ns |  1.7993 ns |  1.6831 ns |  1.00 |         - |          NA |
| StructLINQ | .NET Framework 4.8 | .NET Framework 4.8 |       100 |   164.881 ns |  0.7415 ns |  0.6936 ns |  0.37 |         - |          NA |
|            |                    |                    |           |              |            |            |       |           |             |
|       **LINQ** |           **.NET 6.0** |           **.NET 6.0** |      **1000** | **3,952.483 ns** | **13.5244 ns** | **12.6507 ns** |  **0.92** |         **-** |          **NA** |
| StructLINQ |           .NET 6.0 |           .NET 6.0 |      1000 | 1,272.484 ns |  5.1616 ns |  4.5756 ns |  0.30 |         - |          NA |
|       LINQ |           .NET 7.0 |           .NET 7.0 |      1000 | 3,541.406 ns |  9.7710 ns |  9.1398 ns |  0.82 |         - |          NA |
| StructLINQ |           .NET 7.0 |           .NET 7.0 |      1000 |   868.747 ns |  3.1798 ns |  2.8188 ns |  0.20 |         - |          NA |
|       LINQ | .NET Framework 4.8 | .NET Framework 4.8 |      1000 | 4,306.939 ns |  9.2884 ns |  8.2339 ns |  1.00 |         - |          NA |
| StructLINQ | .NET Framework 4.8 | .NET Framework 4.8 |      1000 | 1,535.423 ns |  4.2516 ns |  3.9770 ns |  0.36 |         - |          NA |
