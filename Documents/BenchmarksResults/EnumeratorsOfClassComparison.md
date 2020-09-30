## EnumeratorsOfClassComparison

### Source
[EnumeratorsOfClassComparison.cs](../../src/StructLinq.Benchmark/EnumeratorsOfClassComparison.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  Job-ILXHKQ : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  Job-DKIKQP : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|              Method |       Runtime | ItemCount |          Mean |      Error |     StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |-------------- |---------- |--------------:|-----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
|          **SysForEach** |      **.NET 4.8** |         **2** |     **0.6358 ns** |  **0.0075 ns** |  **0.0070 ns** |  **1.00** |    **0.00** |     **-** |     **-** |     **-** |         **-** |
|    StructEnumerable |      .NET 4.8 |         2 |     2.0254 ns |  0.0049 ns |  0.0043 ns |  3.18 |    0.04 |     - |     - |     - |         - |
| RefStructEnumerable |      .NET 4.8 |         2 |     5.4924 ns |  0.0172 ns |  0.0161 ns |  8.64 |    0.09 |     - |     - |     - |         - |
|   ArrayEnumerableV1 |      .NET 4.8 |         2 |     2.0610 ns |  0.0030 ns |  0.0028 ns |  3.24 |    0.04 |     - |     - |     - |         - |
|                     |               |           |               |            |            |       |         |       |       |       |           |
|          SysForEach | .NET Core 3.1 |         2 |     0.5157 ns |  0.0028 ns |  0.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
|    StructEnumerable | .NET Core 3.1 |         2 |     1.8370 ns |  0.0046 ns |  0.0043 ns |  3.56 |    0.02 |     - |     - |     - |         - |
| RefStructEnumerable | .NET Core 3.1 |         2 |     5.6511 ns |  0.0208 ns |  0.0162 ns | 10.95 |    0.07 |     - |     - |     - |         - |
|   ArrayEnumerableV1 | .NET Core 3.1 |         2 |     2.0783 ns |  0.0061 ns |  0.0054 ns |  4.03 |    0.02 |     - |     - |     - |         - |
|                     |               |           |               |            |            |       |         |       |       |       |           |
|          **SysForEach** |      **.NET 4.8** |        **20** |     **8.6796 ns** |  **0.0471 ns** |  **0.0441 ns** |  **1.00** |    **0.00** |     **-** |     **-** |     **-** |         **-** |
|    StructEnumerable |      .NET 4.8 |        20 |    11.8352 ns |  0.0169 ns |  0.0158 ns |  1.36 |    0.01 |     - |     - |     - |         - |
| RefStructEnumerable |      .NET 4.8 |        20 |    41.8397 ns |  0.8177 ns |  0.7249 ns |  4.82 |    0.09 |     - |     - |     - |         - |
|   ArrayEnumerableV1 |      .NET 4.8 |        20 |    12.2472 ns |  0.0451 ns |  0.0400 ns |  1.41 |    0.01 |     - |     - |     - |         - |
|                     |               |           |               |            |            |       |         |       |       |       |           |
|          SysForEach | .NET Core 3.1 |        20 |     8.3279 ns |  0.0538 ns |  0.0503 ns |  1.00 |    0.00 |     - |     - |     - |         - |
|    StructEnumerable | .NET Core 3.1 |        20 |    12.5315 ns |  0.0326 ns |  0.0305 ns |  1.50 |    0.01 |     - |     - |     - |         - |
| RefStructEnumerable | .NET Core 3.1 |        20 |    47.3032 ns |  0.1119 ns |  0.1046 ns |  5.68 |    0.04 |     - |     - |     - |         - |
|   ArrayEnumerableV1 | .NET Core 3.1 |        20 |    11.5585 ns |  0.0453 ns |  0.0424 ns |  1.39 |    0.01 |     - |     - |     - |         - |
|                     |               |           |               |            |            |       |         |       |       |       |           |
|          **SysForEach** |      **.NET 4.8** |       **100** |    **47.3674 ns** |  **0.0491 ns** |  **0.0459 ns** |  **1.00** |    **0.00** |     **-** |     **-** |     **-** |         **-** |
|    StructEnumerable |      .NET 4.8 |       100 |    62.8654 ns |  0.0858 ns |  0.0803 ns |  1.33 |    0.00 |     - |     - |     - |         - |
| RefStructEnumerable |      .NET 4.8 |       100 |   205.5518 ns |  0.2851 ns |  0.2667 ns |  4.34 |    0.01 |     - |     - |     - |         - |
|   ArrayEnumerableV1 |      .NET 4.8 |       100 |    70.5085 ns |  0.1573 ns |  0.1471 ns |  1.49 |    0.00 |     - |     - |     - |         - |
|                     |               |           |               |            |            |       |         |       |       |       |           |
|          SysForEach | .NET Core 3.1 |       100 |    47.8528 ns |  0.0638 ns |  0.0596 ns |  1.00 |    0.00 |     - |     - |     - |         - |
|    StructEnumerable | .NET Core 3.1 |       100 |    63.0187 ns |  0.0848 ns |  0.0751 ns |  1.32 |    0.00 |     - |     - |     - |         - |
| RefStructEnumerable | .NET Core 3.1 |       100 |   233.7422 ns |  0.1227 ns |  0.1148 ns |  4.88 |    0.01 |     - |     - |     - |         - |
|   ArrayEnumerableV1 | .NET Core 3.1 |       100 |    71.7434 ns |  0.1016 ns |  0.0901 ns |  1.50 |    0.00 |     - |     - |     - |         - |
|                     |               |           |               |            |            |       |         |       |       |       |           |
|          **SysForEach** |      **.NET 4.8** |      **1000** |   **423.7870 ns** |  **0.4404 ns** |  **0.3904 ns** |  **1.00** |    **0.00** |     **-** |     **-** |     **-** |         **-** |
|    StructEnumerable |      .NET 4.8 |      1000 |   570.2517 ns |  1.7700 ns |  1.6557 ns |  1.35 |    0.00 |     - |     - |     - |         - |
| RefStructEnumerable |      .NET 4.8 |      1000 | 1,992.7770 ns | 24.4675 ns | 20.4315 ns |  4.70 |    0.05 |     - |     - |     - |         - |
|   ArrayEnumerableV1 |      .NET 4.8 |      1000 |   639.4180 ns |  0.7556 ns |  0.7068 ns |  1.51 |    0.00 |     - |     - |     - |         - |
|                     |               |           |               |            |            |       |         |       |       |       |           |
|          SysForEach | .NET Core 3.1 |      1000 |   421.5588 ns |  0.7866 ns |  0.6973 ns |  1.00 |    0.00 |     - |     - |     - |         - |
|    StructEnumerable | .NET Core 3.1 |      1000 |   571.3795 ns |  1.2823 ns |  1.1994 ns |  1.36 |    0.00 |     - |     - |     - |         - |
| RefStructEnumerable | .NET Core 3.1 |      1000 | 2,262.4537 ns |  5.0062 ns |  4.6828 ns |  5.37 |    0.01 |     - |     - |     - |         - |
|   ArrayEnumerableV1 | .NET Core 3.1 |      1000 |   641.2650 ns |  1.0427 ns |  0.9754 ns |  1.52 |    0.00 |     - |     - |     - |         - |
