## HashSet

### Source
[HashSet.cs](../../src/StructLinq.Benchmark/HashSet.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]        : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4300.0), X64 RyuJIT
  .NET Core 5.0 : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|     Method |           Job |       Runtime | ItemCount |         Mean |      Error |     StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------- |-------------- |-------------- |---------- |-------------:|-----------:|-----------:|------:|------:|------:|------:|----------:|
|       **LINQ** |      **.NET 4.8** |      **.NET 4.8** |         **2** |    **14.725 ns** |  **0.0528 ns** |  **0.0494 ns** |  **1.00** |     **-** |     **-** |     **-** |         **-** |
| StructLINQ |      .NET 4.8 |      .NET 4.8 |         2 |     4.281 ns |  0.0170 ns |  0.0150 ns |  0.29 |     - |     - |     - |         - |
|       LINQ | .NET Core 5.0 | .NET Core 5.0 |         2 |     6.639 ns |  0.0278 ns |  0.0246 ns |  0.45 |     - |     - |     - |         - |
| StructLINQ | .NET Core 5.0 | .NET Core 5.0 |         2 |     3.179 ns |  0.0281 ns |  0.0263 ns |  0.22 |     - |     - |     - |         - |
|            |               |               |           |              |            |            |       |       |       |       |           |
|       **LINQ** |      **.NET 4.8** |      **.NET 4.8** |       **100** |   **293.470 ns** |  **1.5903 ns** |  **1.4098 ns** |  **1.00** |     **-** |     **-** |     **-** |         **-** |
| StructLINQ |      .NET 4.8 |      .NET 4.8 |       100 |   108.403 ns |  0.4108 ns |  0.3842 ns |  0.37 |     - |     - |     - |         - |
|       LINQ | .NET Core 5.0 | .NET Core 5.0 |       100 |   235.487 ns |  1.0204 ns |  0.9045 ns |  0.80 |     - |     - |     - |         - |
| StructLINQ | .NET Core 5.0 | .NET Core 5.0 |       100 |   121.138 ns |  0.3602 ns |  0.3193 ns |  0.41 |     - |     - |     - |         - |
|            |               |               |           |              |            |            |       |       |       |       |           |
|       **LINQ** |      **.NET 4.8** |      **.NET 4.8** |      **1000** | **2,792.092 ns** | **24.4475 ns** | **21.6721 ns** |  **1.00** |     **-** |     **-** |     **-** |         **-** |
| StructLINQ |      .NET 4.8 |      .NET 4.8 |      1000 | 1,011.152 ns |  3.6984 ns |  3.4595 ns |  0.36 |     - |     - |     - |         - |
|       LINQ | .NET Core 5.0 | .NET Core 5.0 |      1000 | 2,268.209 ns |  9.3345 ns |  8.7315 ns |  0.81 |     - |     - |     - |         - |
| StructLINQ | .NET Core 5.0 | .NET Core 5.0 |      1000 | 1,148.857 ns |  4.5158 ns |  4.2241 ns |  0.41 |     - |     - |     - |         - |
