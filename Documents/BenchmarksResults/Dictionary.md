## Dictionary

### Source
[Dictionary.cs](../../src/StructLinq.Benchmark/Dictionary.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]        : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4300.0), X64 RyuJIT
  .NET Core 5.0 : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|     Method |           Job |       Runtime | ItemCount |         Mean |      Error |     StdDev | Ratio | Code Size | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------- |-------------- |-------------- |---------- |-------------:|-----------:|-----------:|------:|----------:|------:|------:|------:|----------:|
|       **LINQ** |      **.NET 4.8** |      **.NET 4.8** |         **2** |    **24.116 ns** |  **0.0864 ns** |  **0.0765 ns** |  **1.00** |    **1322 B** |     **-** |     **-** |     **-** |         **-** |
| StructLINQ |      .NET 4.8 |      .NET 4.8 |         2 |     5.697 ns |  0.0295 ns |  0.0276 ns |  0.24 |     116 B |     - |     - |     - |         - |
|       LINQ | .NET Core 5.0 | .NET Core 5.0 |         2 |    17.819 ns |  0.0680 ns |  0.0636 ns |  0.74 |     348 B |     - |     - |     - |         - |
| StructLINQ | .NET Core 5.0 | .NET Core 5.0 |         2 |     5.482 ns |  0.0141 ns |  0.0125 ns |  0.23 |     112 B |     - |     - |     - |         - |
|            |               |               |           |              |            |            |       |           |       |       |       |           |
|       **LINQ** |      **.NET 4.8** |      **.NET 4.8** |       **100** |   **493.212 ns** |  **1.2900 ns** |  **1.2067 ns** |  **1.00** |    **1322 B** |     **-** |     **-** |     **-** |         **-** |
| StructLINQ |      .NET 4.8 |      .NET 4.8 |       100 |   137.782 ns |  0.4076 ns |  0.3813 ns |  0.28 |     116 B |     - |     - |     - |         - |
|       LINQ | .NET Core 5.0 | .NET Core 5.0 |       100 |   413.206 ns |  1.2275 ns |  1.0881 ns |  0.84 |     348 B |     - |     - |     - |         - |
| StructLINQ | .NET Core 5.0 | .NET Core 5.0 |       100 |   138.855 ns |  0.6230 ns |  0.5828 ns |  0.28 |     112 B |     - |     - |     - |         - |
|            |               |               |           |              |            |            |       |           |       |       |       |           |
|       **LINQ** |      **.NET 4.8** |      **.NET 4.8** |      **1000** | **4,767.096 ns** | **22.9220 ns** | **20.3197 ns** |  **1.00** |    **1322 B** |     **-** |     **-** |     **-** |         **-** |
| StructLINQ |      .NET 4.8 |      .NET 4.8 |      1000 | 1,309.999 ns |  4.0963 ns |  3.8317 ns |  0.27 |     116 B |     - |     - |     - |         - |
|       LINQ | .NET Core 5.0 | .NET Core 5.0 |      1000 | 4,027.063 ns | 15.1737 ns | 14.1935 ns |  0.84 |     348 B |     - |     - |     - |         - |
| StructLINQ | .NET Core 5.0 | .NET Core 5.0 |      1000 | 1,320.438 ns |  3.3702 ns |  2.9876 ns |  0.28 |     112 B |     - |     - |     - |         - |
