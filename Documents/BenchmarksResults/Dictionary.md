## Dictionary

### Source
[Dictionary.cs](../../src/StructLinq.Benchmark/Dictionary.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  Job-ILXHKQ : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  Job-DKIKQP : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|     Method |       Runtime | ItemCount |         Mean |      Error |     StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------- |-------------- |---------- |-------------:|-----------:|-----------:|------:|------:|------:|------:|----------:|
|       **LINQ** |      **.NET 4.8** |         **2** |    **27.489 ns** |  **0.0391 ns** |  **0.0366 ns** |  **1.00** |     **-** |     **-** |     **-** |         **-** |
| StructLINQ |      .NET 4.8 |         2 |     4.237 ns |  0.0116 ns |  0.0108 ns |  0.15 |     - |     - |     - |         - |
|       LINQ | .NET Core 3.1 |         2 |    26.421 ns |  0.0404 ns |  0.0338 ns |  0.96 |     - |     - |     - |         - |
| StructLINQ | .NET Core 3.1 |         2 |     5.720 ns |  0.0144 ns |  0.0134 ns |  0.21 |     - |     - |     - |         - |
|            |               |           |              |            |            |       |       |       |       |           |
|       **LINQ** |      **.NET 4.8** |       **100** |   **473.446 ns** |  **0.8406 ns** |  **0.7863 ns** |  **1.00** |     **-** |     **-** |     **-** |         **-** |
| StructLINQ |      .NET 4.8 |       100 |   127.077 ns |  0.1941 ns |  0.1621 ns |  0.27 |     - |     - |     - |         - |
|       LINQ | .NET Core 3.1 |       100 |   417.060 ns |  0.8111 ns |  0.7587 ns |  0.88 |     - |     - |     - |         - |
| StructLINQ | .NET Core 3.1 |       100 |   137.737 ns |  0.1382 ns |  0.1154 ns |  0.29 |     - |     - |     - |         - |
|            |               |           |              |            |            |       |       |       |       |           |
|       **LINQ** |      **.NET 4.8** |      **1000** | **4,729.685 ns** |  **6.6869 ns** |  **6.2549 ns** |  **1.00** |     **-** |     **-** |     **-** |         **-** |
| StructLINQ |      .NET 4.8 |      1000 | 1,306.087 ns |  3.2112 ns |  3.0037 ns |  0.28 |     - |     - |     - |         - |
|       LINQ | .NET Core 3.1 |      1000 | 3,980.738 ns | 12.6089 ns | 11.1774 ns |  0.84 |     - |     - |     - |         - |
| StructLINQ | .NET Core 3.1 |      1000 | 1,319.680 ns |  2.4587 ns |  2.2998 ns |  0.28 |     - |     - |     - |         - |
