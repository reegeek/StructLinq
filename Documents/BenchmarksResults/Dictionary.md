## Dictionary

### Source
[Dictionary.cs](../../src/StructLinq.Benchmark/Dictionary.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]        : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4250.0), X64 RyuJIT
  .NET Core 5.0 : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|     Method |           Job |       Runtime | ItemCount |         Mean |      Error |     StdDev | Ratio | RatioSD | Code Size | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------- |-------------- |-------------- |---------- |-------------:|-----------:|-----------:|------:|--------:|----------:|------:|------:|------:|----------:|
|       **LINQ** |      **.NET 4.8** |      **.NET 4.8** |         **2** |    **26.642 ns** |  **0.1956 ns** |  **0.1830 ns** |  **1.00** |    **0.00** |    **1322 B** |     **-** |     **-** |     **-** |         **-** |
| StructLINQ |      .NET 4.8 |      .NET 4.8 |         2 |     4.031 ns |  0.0507 ns |  0.0474 ns |  0.15 |    0.00 |     129 B |     - |     - |     - |         - |
|       LINQ | .NET Core 5.0 | .NET Core 5.0 |         2 |    18.439 ns |  0.1449 ns |  0.1355 ns |  0.69 |    0.01 |     348 B |     - |     - |     - |         - |
| StructLINQ | .NET Core 5.0 | .NET Core 5.0 |         2 |     5.238 ns |  0.0396 ns |  0.0370 ns |  0.20 |    0.00 |     125 B |     - |     - |     - |         - |
|            |               |               |           |              |            |            |       |         |           |       |       |       |           |
|       **LINQ** |      **.NET 4.8** |      **.NET 4.8** |       **100** |   **517.662 ns** |  **5.5493 ns** |  **5.1908 ns** |  **1.00** |    **0.00** |    **1322 B** |     **-** |     **-** |     **-** |         **-** |
| StructLINQ |      .NET 4.8 |      .NET 4.8 |       100 |   128.530 ns |  1.5881 ns |  1.4855 ns |  0.25 |    0.00 |     129 B |     - |     - |     - |         - |
|       LINQ | .NET Core 5.0 | .NET Core 5.0 |       100 |   446.103 ns |  3.0140 ns |  2.6718 ns |  0.86 |    0.01 |     348 B |     - |     - |     - |         - |
| StructLINQ | .NET Core 5.0 | .NET Core 5.0 |       100 |   122.727 ns |  0.6960 ns |  0.6510 ns |  0.24 |    0.00 |     125 B |     - |     - |     - |         - |
|            |               |               |           |              |            |            |       |         |           |       |       |       |           |
|       **LINQ** |      **.NET 4.8** |      **.NET 4.8** |      **1000** | **4,996.247 ns** | **67.5138 ns** | **63.1524 ns** |  **1.00** |    **0.00** |    **1322 B** |     **-** |     **-** |     **-** |         **-** |
| StructLINQ |      .NET 4.8 |      .NET 4.8 |      1000 | 1,242.466 ns | 15.8836 ns | 14.0804 ns |  0.25 |    0.00 |     129 B |     - |     - |     - |         - |
|       LINQ | .NET Core 5.0 | .NET Core 5.0 |      1000 | 4,278.529 ns | 58.2323 ns | 54.4706 ns |  0.86 |    0.02 |     348 B |     - |     - |     - |         - |
| StructLINQ | .NET Core 5.0 | .NET Core 5.0 |      1000 | 1,237.477 ns |  8.2719 ns |  6.9074 ns |  0.25 |    0.00 |     125 B |     - |     - |     - |         - |
