## EnumeratorsOfClassComparison

### Source
[EnumeratorsOfClassComparison.cs](../../src/StructLinq.Benchmark/EnumeratorsOfClassComparison.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.202
  [Host]        : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4341.0), X64 RyuJIT
  .NET Core 5.0 : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT


```
|              Method |           Job |       Runtime | ItemCount |          Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated | Code Size |
|-------------------- |-------------- |-------------- |---------- |--------------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|----------:|
|          **SysForEach** |      **.NET 4.8** |      **.NET 4.8** |         **2** |     **0.8662 ns** | **0.0122 ns** | **0.0114 ns** |  **1.00** |    **0.00** |     **-** |     **-** |     **-** |         **-** |      **37 B** |
|    StructEnumerable |      .NET 4.8 |      .NET 4.8 |         2 |     1.8047 ns | 0.0159 ns | 0.0149 ns |  2.08 |    0.03 |     - |     - |     - |         - |      73 B |
| RefStructEnumerable |      .NET 4.8 |      .NET 4.8 |         2 |     4.9101 ns | 0.0252 ns | 0.0236 ns |  5.67 |    0.07 |     - |     - |     - |         - |      87 B |
|   ArrayEnumerableV1 |      .NET 4.8 |      .NET 4.8 |         2 |     1.8826 ns | 0.0177 ns | 0.0166 ns |  2.17 |    0.03 |     - |     - |     - |         - |      63 B |
|                     |               |               |           |               |           |           |       |         |       |       |       |           |           |
|          SysForEach | .NET Core 5.0 | .NET Core 5.0 |         2 |     0.8193 ns | 0.0150 ns | 0.0140 ns |  1.00 |    0.00 |     - |     - |     - |         - |      37 B |
|    StructEnumerable | .NET Core 5.0 | .NET Core 5.0 |         2 |     1.8134 ns | 0.0068 ns | 0.0057 ns |  2.21 |    0.04 |     - |     - |     - |         - |      73 B |
| RefStructEnumerable | .NET Core 5.0 | .NET Core 5.0 |         2 |     4.0451 ns | 0.0185 ns | 0.0154 ns |  4.94 |    0.09 |     - |     - |     - |         - |      77 B |
|   ArrayEnumerableV1 | .NET Core 5.0 | .NET Core 5.0 |         2 |     1.9102 ns | 0.0103 ns | 0.0086 ns |  2.33 |    0.04 |     - |     - |     - |         - |      63 B |
|                     |               |               |           |               |           |           |       |         |       |       |       |           |           |
|          **SysForEach** |      **.NET 4.8** |      **.NET 4.8** |        **20** |     **7.7553 ns** | **0.0750 ns** | **0.0701 ns** |  **1.00** |    **0.00** |     **-** |     **-** |     **-** |         **-** |      **37 B** |
|    StructEnumerable |      .NET 4.8 |      .NET 4.8 |        20 |    10.4815 ns | 0.0546 ns | 0.0510 ns |  1.35 |    0.02 |     - |     - |     - |         - |      73 B |
| RefStructEnumerable |      .NET 4.8 |      .NET 4.8 |        20 |    41.6188 ns | 0.1790 ns | 0.1587 ns |  5.36 |    0.04 |     - |     - |     - |         - |      87 B |
|   ArrayEnumerableV1 |      .NET 4.8 |      .NET 4.8 |        20 |    11.0207 ns | 0.0447 ns | 0.0397 ns |  1.42 |    0.01 |     - |     - |     - |         - |      63 B |
|                     |               |               |           |               |           |           |       |         |       |       |       |           |           |
|          SysForEach | .NET Core 5.0 | .NET Core 5.0 |        20 |     9.9139 ns | 0.0820 ns | 0.0767 ns |  1.00 |    0.00 |     - |     - |     - |         - |      37 B |
|    StructEnumerable | .NET Core 5.0 | .NET Core 5.0 |        20 |     7.7322 ns | 0.0478 ns | 0.0447 ns |  0.78 |    0.01 |     - |     - |     - |         - |      73 B |
| RefStructEnumerable | .NET Core 5.0 | .NET Core 5.0 |        20 |    27.2056 ns | 0.1009 ns | 0.0895 ns |  2.74 |    0.02 |     - |     - |     - |         - |      77 B |
|   ArrayEnumerableV1 | .NET Core 5.0 | .NET Core 5.0 |        20 |    10.4547 ns | 0.0716 ns | 0.0670 ns |  1.05 |    0.01 |     - |     - |     - |         - |      63 B |
|                     |               |               |           |               |           |           |       |         |       |       |       |           |           |
|          **SysForEach** |      **.NET 4.8** |      **.NET 4.8** |       **100** |    **43.0425 ns** | **0.1981 ns** | **0.1654 ns** |  **1.00** |    **0.00** |     **-** |     **-** |     **-** |         **-** |      **37 B** |
|    StructEnumerable |      .NET 4.8 |      .NET 4.8 |       100 |    56.6637 ns | 0.3237 ns | 0.2527 ns |  1.32 |    0.01 |     - |     - |     - |         - |      73 B |
| RefStructEnumerable |      .NET 4.8 |      .NET 4.8 |       100 |   209.2408 ns | 0.8795 ns | 0.8227 ns |  4.86 |    0.03 |     - |     - |     - |         - |      87 B |
|   ArrayEnumerableV1 |      .NET 4.8 |      .NET 4.8 |       100 |    62.9877 ns | 0.3470 ns | 0.3076 ns |  1.46 |    0.01 |     - |     - |     - |         - |      63 B |
|                     |               |               |           |               |           |           |       |         |       |       |       |           |           |
|          SysForEach | .NET Core 5.0 | .NET Core 5.0 |       100 |    56.2586 ns | 0.1761 ns | 0.1647 ns |  1.00 |    0.00 |     - |     - |     - |         - |      37 B |
|    StructEnumerable | .NET Core 5.0 | .NET Core 5.0 |       100 |    56.4388 ns | 0.2310 ns | 0.1929 ns |  1.00 |    0.00 |     - |     - |     - |         - |      73 B |
| RefStructEnumerable | .NET Core 5.0 | .NET Core 5.0 |       100 |   133.8485 ns | 0.7127 ns | 0.6666 ns |  2.38 |    0.01 |     - |     - |     - |         - |      77 B |
|   ArrayEnumerableV1 | .NET Core 5.0 | .NET Core 5.0 |       100 |    62.9925 ns | 0.2270 ns | 0.1896 ns |  1.12 |    0.01 |     - |     - |     - |         - |      63 B |
|                     |               |               |           |               |           |           |       |         |       |       |       |           |           |
|          **SysForEach** |      **.NET 4.8** |      **.NET 4.8** |      **1000** |   **374.9886 ns** | **1.2653 ns** | **1.1835 ns** |  **1.00** |    **0.00** |     **-** |     **-** |     **-** |         **-** |      **37 B** |
|    StructEnumerable |      .NET 4.8 |      .NET 4.8 |      1000 |   508.6803 ns | 2.1015 ns | 1.9657 ns |  1.36 |    0.01 |     - |     - |     - |         - |      73 B |
| RefStructEnumerable |      .NET 4.8 |      .NET 4.8 |      1000 | 2,020.7291 ns | 7.8670 ns | 7.3588 ns |  5.39 |    0.03 |     - |     - |     - |         - |      87 B |
|   ArrayEnumerableV1 |      .NET 4.8 |      .NET 4.8 |      1000 |   570.9349 ns | 3.2437 ns | 3.0341 ns |  1.52 |    0.01 |     - |     - |     - |         - |      63 B |
|                     |               |               |           |               |           |           |       |         |       |       |       |           |           |
|          SysForEach | .NET Core 5.0 | .NET Core 5.0 |      1000 |   381.2852 ns | 0.9235 ns | 0.8638 ns |  1.00 |    0.00 |     - |     - |     - |         - |      37 B |
|    StructEnumerable | .NET Core 5.0 | .NET Core 5.0 |      1000 |   394.1761 ns | 2.6189 ns | 2.4497 ns |  1.03 |    0.01 |     - |     - |     - |         - |      73 B |
| RefStructEnumerable | .NET Core 5.0 | .NET Core 5.0 |      1000 | 1,274.5959 ns | 4.0012 ns | 3.7427 ns |  3.34 |    0.01 |     - |     - |     - |         - |      77 B |
|   ArrayEnumerableV1 | .NET Core 5.0 | .NET Core 5.0 |      1000 |   574.1825 ns | 1.9711 ns | 1.7473 ns |  1.51 |    0.01 |     - |     - |     - |         - |      63 B |
