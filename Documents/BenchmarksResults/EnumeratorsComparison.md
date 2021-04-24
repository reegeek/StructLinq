## EnumeratorsComparison

### Source
[EnumeratorsComparison.cs](../../src/StructLinq.Benchmark/EnumeratorsComparison.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.202
  [Host]        : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4341.0), X64 RyuJIT
  .NET Core 5.0 : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT


```
|              Method |           Job |       Runtime | ItemCount |        Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated | Code Size |
|-------------------- |-------------- |-------------- |---------- |------------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|----------:|
|          **SysForEach** |      **.NET 4.8** |      **.NET 4.8** |         **2** |   **1.0029 ns** | **0.0171 ns** | **0.0151 ns** |  **1.00** |    **0.00** |     **-** |     **-** |     **-** |         **-** |      **36 B** |
|    StructEnumerable |      .NET 4.8 |      .NET 4.8 |         2 |   1.8061 ns | 0.0083 ns | 0.0078 ns |  1.80 |    0.03 |     - |     - |     - |         - |      72 B |
| RefStructEnumerable |      .NET 4.8 |      .NET 4.8 |         2 |   1.8065 ns | 0.0114 ns | 0.0107 ns |  1.80 |    0.02 |     - |     - |     - |         - |      72 B |
|   ArrayEnumerableV1 |      .NET 4.8 |      .NET 4.8 |         2 |   1.9375 ns | 0.0161 ns | 0.0151 ns |  1.93 |    0.03 |     - |     - |     - |         - |      62 B |
|                     |               |               |           |             |           |           |       |         |       |       |       |           |           |
|          SysForEach | .NET Core 5.0 | .NET Core 5.0 |         2 |   0.7455 ns | 0.0120 ns | 0.0112 ns |  1.00 |    0.00 |     - |     - |     - |         - |      36 B |
|    StructEnumerable | .NET Core 5.0 | .NET Core 5.0 |         2 |   1.8064 ns | 0.0099 ns | 0.0082 ns |  2.42 |    0.04 |     - |     - |     - |         - |      72 B |
| RefStructEnumerable | .NET Core 5.0 | .NET Core 5.0 |         2 |   1.7841 ns | 0.0134 ns | 0.0125 ns |  2.39 |    0.04 |     - |     - |     - |         - |      72 B |
|   ArrayEnumerableV1 | .NET Core 5.0 | .NET Core 5.0 |         2 |   1.9215 ns | 0.0117 ns | 0.0098 ns |  2.57 |    0.04 |     - |     - |     - |         - |      62 B |
|                     |               |               |           |             |           |           |       |         |       |       |       |           |           |
|          **SysForEach** |      **.NET 4.8** |      **.NET 4.8** |        **20** |  **10.1332 ns** | **0.0835 ns** | **0.0740 ns** |  **1.00** |    **0.00** |     **-** |     **-** |     **-** |         **-** |      **36 B** |
|    StructEnumerable |      .NET 4.8 |      .NET 4.8 |        20 |  10.5474 ns | 0.2252 ns | 0.1881 ns |  1.04 |    0.02 |     - |     - |     - |         - |      72 B |
| RefStructEnumerable |      .NET 4.8 |      .NET 4.8 |        20 |  10.4610 ns | 0.0293 ns | 0.0274 ns |  1.03 |    0.01 |     - |     - |     - |         - |      72 B |
|   ArrayEnumerableV1 |      .NET 4.8 |      .NET 4.8 |        20 |  10.7367 ns | 0.0488 ns | 0.0407 ns |  1.06 |    0.01 |     - |     - |     - |         - |      62 B |
|                     |               |               |           |             |           |           |       |         |       |       |       |           |           |
|          SysForEach | .NET Core 5.0 | .NET Core 5.0 |        20 |   6.6720 ns | 0.0448 ns | 0.0397 ns |  1.00 |    0.00 |     - |     - |     - |         - |      36 B |
|    StructEnumerable | .NET Core 5.0 | .NET Core 5.0 |        20 |   7.6526 ns | 0.0456 ns | 0.0404 ns |  1.15 |    0.01 |     - |     - |     - |         - |      72 B |
| RefStructEnumerable | .NET Core 5.0 | .NET Core 5.0 |        20 |  11.2079 ns | 0.0429 ns | 0.0381 ns |  1.68 |    0.01 |     - |     - |     - |         - |      72 B |
|   ArrayEnumerableV1 | .NET Core 5.0 | .NET Core 5.0 |        20 |  12.6083 ns | 0.0700 ns | 0.0655 ns |  1.89 |    0.02 |     - |     - |     - |         - |      62 B |
|                     |               |               |           |             |           |           |       |         |       |       |       |           |           |
|          **SysForEach** |      **.NET 4.8** |      **.NET 4.8** |       **100** |  **56.5278 ns** | **0.2356 ns** | **0.2204 ns** |  **1.00** |    **0.00** |     **-** |     **-** |     **-** |         **-** |      **36 B** |
|    StructEnumerable |      .NET 4.8 |      .NET 4.8 |       100 |  56.9945 ns | 0.1988 ns | 0.1860 ns |  1.01 |    0.01 |     - |     - |     - |         - |      72 B |
| RefStructEnumerable |      .NET 4.8 |      .NET 4.8 |       100 |  57.0610 ns | 0.2040 ns | 0.1908 ns |  1.01 |    0.01 |     - |     - |     - |         - |      72 B |
|   ArrayEnumerableV1 |      .NET 4.8 |      .NET 4.8 |       100 |  61.9914 ns | 0.3340 ns | 0.3125 ns |  1.10 |    0.01 |     - |     - |     - |         - |      62 B |
|                     |               |               |           |             |           |           |       |         |       |       |       |           |           |
|          SysForEach | .NET Core 5.0 | .NET Core 5.0 |       100 |  42.6101 ns | 0.1160 ns | 0.1085 ns |  1.00 |    0.00 |     - |     - |     - |         - |      36 B |
|    StructEnumerable | .NET Core 5.0 | .NET Core 5.0 |       100 |  45.1775 ns | 0.1689 ns | 0.1498 ns |  1.06 |    0.00 |     - |     - |     - |         - |      72 B |
| RefStructEnumerable | .NET Core 5.0 | .NET Core 5.0 |       100 |  57.2476 ns | 0.2130 ns | 0.1663 ns |  1.34 |    0.00 |     - |     - |     - |         - |      72 B |
|   ArrayEnumerableV1 | .NET Core 5.0 | .NET Core 5.0 |       100 |  62.5415 ns | 0.2777 ns | 0.2598 ns |  1.47 |    0.01 |     - |     - |     - |         - |      62 B |
|                     |               |               |           |             |           |           |       |         |       |       |       |           |           |
|          **SysForEach** |      **.NET 4.8** |      **.NET 4.8** |      **1000** | **508.5305 ns** | **2.2190 ns** | **2.0756 ns** |  **1.00** |    **0.00** |     **-** |     **-** |     **-** |         **-** |      **36 B** |
|    StructEnumerable |      .NET 4.8 |      .NET 4.8 |      1000 | 509.8773 ns | 1.7279 ns | 1.6163 ns |  1.00 |    0.01 |     - |     - |     - |         - |      72 B |
| RefStructEnumerable |      .NET 4.8 |      .NET 4.8 |      1000 | 510.7655 ns | 1.6832 ns | 1.5745 ns |  1.00 |    0.01 |     - |     - |     - |         - |      72 B |
|   ArrayEnumerableV1 |      .NET 4.8 |      .NET 4.8 |      1000 | 561.1364 ns | 2.7141 ns | 2.5388 ns |  1.10 |    0.01 |     - |     - |     - |         - |      62 B |
|                     |               |               |           |             |           |           |       |         |       |       |       |           |           |
|          SysForEach | .NET Core 5.0 | .NET Core 5.0 |      1000 | 373.7682 ns | 1.5464 ns | 1.4465 ns |  1.00 |    0.00 |     - |     - |     - |         - |      36 B |
|    StructEnumerable | .NET Core 5.0 | .NET Core 5.0 |      1000 | 386.0018 ns | 1.5133 ns | 1.4156 ns |  1.03 |    0.01 |     - |     - |     - |         - |      72 B |
| RefStructEnumerable | .NET Core 5.0 | .NET Core 5.0 |      1000 | 510.9528 ns | 2.6485 ns | 2.4774 ns |  1.37 |    0.01 |     - |     - |     - |         - |      72 B |
|   ArrayEnumerableV1 | .NET Core 5.0 | .NET Core 5.0 |      1000 | 560.8496 ns | 2.3370 ns | 2.1861 ns |  1.50 |    0.01 |     - |     - |     - |         - |      62 B |
