## EnumeratorsComparison

### Source
[EnumeratorsComparison.cs](../../src/StructLinq.Benchmark/EnumeratorsComparison.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.203
  [Host]        : .NET Core 5.0.6 (CoreCLR 5.0.621.22011, CoreFX 5.0.621.22011), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4341.0), X64 RyuJIT
  .NET Core 5.0 : .NET Core 5.0.6 (CoreCLR 5.0.621.22011, CoreFX 5.0.621.22011), X64 RyuJIT


```
|              Method |           Job |       Runtime | ItemCount |         Mean |     Error |    StdDev |       Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated | Code Size |
|-------------------- |-------------- |-------------- |---------- |-------------:|----------:|----------:|-------------:|------:|--------:|------:|------:|------:|----------:|----------:|
|          **SysForEach** |      **.NET 4.8** |      **.NET 4.8** |         **2** |     **1.996 ns** | **0.1537 ns** | **0.4531 ns** |     **2.023 ns** |  **1.00** |    **0.00** |     **-** |     **-** |     **-** |         **-** |      **36 B** |
|    StructEnumerable |      .NET 4.8 |      .NET 4.8 |         2 |     2.845 ns | 0.1514 ns | 0.4393 ns |     2.942 ns |  1.51 |    0.48 |     - |     - |     - |         - |      72 B |
| RefStructEnumerable |      .NET 4.8 |      .NET 4.8 |         2 |     2.331 ns | 0.0772 ns | 0.1662 ns |     2.285 ns |  1.10 |    0.26 |     - |     - |     - |         - |      72 B |
|   ArrayEnumerableV1 |      .NET 4.8 |      .NET 4.8 |         2 |     2.239 ns | 0.0794 ns | 0.1530 ns |     2.177 ns |  0.96 |    0.12 |     - |     - |     - |         - |      62 B |
|   StructEnumerable2 |      .NET 4.8 |      .NET 4.8 |         2 |    18.916 ns | 0.2558 ns | 0.2393 ns |    18.918 ns |  7.97 |    0.76 |     - |     - |     - |         - |     145 B |
|                     |               |               |           |              |           |           |              |       |         |       |       |       |           |           |
|          SysForEach | .NET Core 5.0 | .NET Core 5.0 |         2 |     1.170 ns | 0.0794 ns | 0.2253 ns |     1.107 ns |  1.00 |    0.00 |     - |     - |     - |         - |      36 B |
|    StructEnumerable | .NET Core 5.0 | .NET Core 5.0 |         2 |     2.293 ns | 0.0821 ns | 0.2028 ns |     2.223 ns |  1.99 |    0.37 |     - |     - |     - |         - |      72 B |
| RefStructEnumerable | .NET Core 5.0 | .NET Core 5.0 |         2 |     2.291 ns | 0.0817 ns | 0.1687 ns |     2.237 ns |  1.99 |    0.35 |     - |     - |     - |         - |      72 B |
|   ArrayEnumerableV1 | .NET Core 5.0 | .NET Core 5.0 |         2 |     2.426 ns | 0.0853 ns | 0.1223 ns |     2.399 ns |  2.07 |    0.37 |     - |     - |     - |         - |      62 B |
|   StructEnumerable2 | .NET Core 5.0 | .NET Core 5.0 |         2 |    11.342 ns | 0.2480 ns | 0.2855 ns |    11.221 ns |  9.81 |    1.79 |     - |     - |     - |         - |     124 B |
|                     |               |               |           |              |           |           |              |       |         |       |       |       |           |           |
|          **SysForEach** |      **.NET 4.8** |      **.NET 4.8** |        **20** |    **13.089 ns** | **0.2834 ns** | **0.2213 ns** |    **13.094 ns** |  **1.00** |    **0.00** |     **-** |     **-** |     **-** |         **-** |      **36 B** |
|    StructEnumerable |      .NET 4.8 |      .NET 4.8 |        20 |    14.831 ns | 0.3322 ns | 0.5818 ns |    14.746 ns |  1.14 |    0.06 |     - |     - |     - |         - |      72 B |
| RefStructEnumerable |      .NET 4.8 |      .NET 4.8 |        20 |    10.849 ns | 0.2523 ns | 0.4216 ns |    10.780 ns |  0.83 |    0.03 |     - |     - |     - |         - |      72 B |
|   ArrayEnumerableV1 |      .NET 4.8 |      .NET 4.8 |        20 |    13.924 ns | 0.3149 ns | 0.7173 ns |    13.774 ns |  1.05 |    0.06 |     - |     - |     - |         - |      62 B |
|   StructEnumerable2 |      .NET 4.8 |      .NET 4.8 |        20 |    46.667 ns | 0.9987 ns | 2.7001 ns |    45.519 ns |  3.57 |    0.18 |     - |     - |     - |         - |     145 B |
|                     |               |               |           |              |           |           |              |       |         |       |       |       |           |           |
|          SysForEach | .NET Core 5.0 | .NET Core 5.0 |        20 |     9.826 ns | 0.4035 ns | 1.1898 ns |     9.272 ns |  1.00 |    0.00 |     - |     - |     - |         - |      36 B |
|    StructEnumerable | .NET Core 5.0 | .NET Core 5.0 |        20 |    15.926 ns | 0.7984 ns | 2.3542 ns |    14.897 ns |  1.65 |    0.32 |     - |     - |     - |         - |      72 B |
| RefStructEnumerable | .NET Core 5.0 | .NET Core 5.0 |        20 |    12.460 ns | 0.2294 ns | 0.2982 ns |    12.368 ns |  1.30 |    0.16 |     - |     - |     - |         - |      72 B |
|   ArrayEnumerableV1 | .NET Core 5.0 | .NET Core 5.0 |        20 |    14.549 ns | 0.2305 ns | 0.1925 ns |    14.508 ns |  1.53 |    0.18 |     - |     - |     - |         - |      62 B |
|   StructEnumerable2 | .NET Core 5.0 | .NET Core 5.0 |        20 |    37.571 ns | 0.2287 ns | 0.1786 ns |    37.533 ns |  3.93 |    0.49 |     - |     - |     - |         - |     124 B |
|                     |               |               |           |              |           |           |              |       |         |       |       |       |           |           |
|          **SysForEach** |      **.NET 4.8** |      **.NET 4.8** |       **100** |    **64.437 ns** | **0.1786 ns** | **0.1583 ns** |    **64.440 ns** |  **1.00** |    **0.00** |     **-** |     **-** |     **-** |         **-** |      **36 B** |
|    StructEnumerable |      .NET 4.8 |      .NET 4.8 |       100 |    65.841 ns | 0.4667 ns | 0.4366 ns |    65.711 ns |  1.02 |    0.01 |     - |     - |     - |         - |      72 B |
| RefStructEnumerable |      .NET 4.8 |      .NET 4.8 |       100 |    51.685 ns | 0.2857 ns | 0.2532 ns |    51.659 ns |  0.80 |    0.00 |     - |     - |     - |         - |      72 B |
|   ArrayEnumerableV1 |      .NET 4.8 |      .NET 4.8 |       100 |    71.827 ns | 0.3129 ns | 0.2613 ns |    71.848 ns |  1.11 |    0.00 |     - |     - |     - |         - |      62 B |
|   StructEnumerable2 |      .NET 4.8 |      .NET 4.8 |       100 |   189.342 ns | 0.4157 ns | 0.3471 ns |   189.318 ns |  2.94 |    0.01 |     - |     - |     - |         - |     145 B |
|                     |               |               |           |              |           |           |              |       |         |       |       |       |           |           |
|          SysForEach | .NET Core 5.0 | .NET Core 5.0 |       100 |    49.713 ns | 0.1537 ns | 0.1438 ns |    49.668 ns |  1.00 |    0.00 |     - |     - |     - |         - |      36 B |
|    StructEnumerable | .NET Core 5.0 | .NET Core 5.0 |       100 |    66.644 ns | 0.4572 ns | 0.3569 ns |    66.772 ns |  1.34 |    0.01 |     - |     - |     - |         - |      72 B |
| RefStructEnumerable | .NET Core 5.0 | .NET Core 5.0 |       100 |    65.994 ns | 0.2662 ns | 0.2490 ns |    66.078 ns |  1.33 |    0.00 |     - |     - |     - |         - |      72 B |
|   ArrayEnumerableV1 | .NET Core 5.0 | .NET Core 5.0 |       100 |    74.010 ns | 0.4472 ns | 0.4183 ns |    73.912 ns |  1.49 |    0.01 |     - |     - |     - |         - |      62 B |
|   StructEnumerable2 | .NET Core 5.0 | .NET Core 5.0 |       100 |   183.192 ns | 1.1477 ns | 0.9584 ns |   182.978 ns |  3.68 |    0.02 |     - |     - |     - |         - |     124 B |
|                     |               |               |           |              |           |           |              |       |         |       |       |       |           |           |
|          **SysForEach** |      **.NET 4.8** |      **.NET 4.8** |      **1000** |   **589.378 ns** | **3.4081 ns** | **2.8459 ns** |   **588.876 ns** |  **1.00** |    **0.00** |     **-** |     **-** |     **-** |         **-** |      **36 B** |
|    StructEnumerable |      .NET 4.8 |      .NET 4.8 |      1000 |   597.397 ns | 3.5444 ns | 2.7672 ns |   597.084 ns |  1.01 |    0.01 |     - |     - |     - |         - |      72 B |
| RefStructEnumerable |      .NET 4.8 |      .NET 4.8 |      1000 |   450.626 ns | 1.7889 ns | 1.4938 ns |   450.803 ns |  0.76 |    0.00 |     - |     - |     - |         - |      72 B |
|   ArrayEnumerableV1 |      .NET 4.8 |      .NET 4.8 |      1000 |   670.008 ns | 3.9378 ns | 3.6834 ns |   668.287 ns |  1.14 |    0.01 |     - |     - |     - |         - |      62 B |
|   StructEnumerable2 |      .NET 4.8 |      .NET 4.8 |      1000 | 1,751.288 ns | 5.6142 ns | 4.6881 ns | 1,751.056 ns |  2.97 |    0.02 |     - |     - |     - |         - |     145 B |
|                     |               |               |           |              |           |           |              |       |         |       |       |       |           |           |
|          SysForEach | .NET Core 5.0 | .NET Core 5.0 |      1000 |   452.601 ns | 3.0103 ns | 2.5137 ns |   452.463 ns |  1.00 |    0.00 |     - |     - |     - |         - |      36 B |
|    StructEnumerable | .NET Core 5.0 | .NET Core 5.0 |      1000 |   600.515 ns | 4.1306 ns | 3.4492 ns |   599.862 ns |  1.33 |    0.01 |     - |     - |     - |         - |      72 B |
| RefStructEnumerable | .NET Core 5.0 | .NET Core 5.0 |      1000 |   592.455 ns | 2.8610 ns | 2.5362 ns |   592.375 ns |  1.31 |    0.01 |     - |     - |     - |         - |      72 B |
|   ArrayEnumerableV1 | .NET Core 5.0 | .NET Core 5.0 |      1000 |   672.050 ns | 3.7063 ns | 3.0949 ns |   671.494 ns |  1.48 |    0.01 |     - |     - |     - |         - |      62 B |
|   StructEnumerable2 | .NET Core 5.0 | .NET Core 5.0 |      1000 | 1,740.005 ns | 3.6980 ns | 2.8872 ns | 1,739.376 ns |  3.85 |    0.02 |     - |     - |     - |         - |     124 B |
