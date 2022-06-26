## EnumeratorsComparison

### Source
[EnumeratorsComparison.cs](../../src/StructLinq.Benchmark/EnumeratorsComparison.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]             : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  .NET 5.0           : .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT
  .NET 6.0           : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  .NET Framework 4.8 : .NET Framework 4.8 (4.8.4515.0), X64 RyuJIT


```
|              Method |                Job |            Runtime | ItemCount |        Mean |     Error |    StdDev | Ratio | RatioSD | Allocated |
|-------------------- |------------------- |------------------- |---------- |------------:|----------:|----------:|------:|--------:|----------:|
|          **SysForEach** |           **.NET 5.0** |           **.NET 5.0** |         **2** |   **0.7136 ns** | **0.0117 ns** | **0.0110 ns** |  **0.84** |    **0.02** |         **-** |
|    StructEnumerable |           .NET 5.0 |           .NET 5.0 |         2 |   1.8016 ns | 0.0074 ns | 0.0069 ns |  2.13 |    0.07 |         - |
| RefStructEnumerable |           .NET 5.0 |           .NET 5.0 |         2 |   1.7636 ns | 0.0101 ns | 0.0089 ns |  2.08 |    0.07 |         - |
|   ArrayEnumerableV1 |           .NET 5.0 |           .NET 5.0 |         2 |   1.9895 ns | 0.0078 ns | 0.0073 ns |  2.35 |    0.08 |         - |
|          SysForEach |           .NET 6.0 |           .NET 6.0 |         2 |   0.3869 ns | 0.0060 ns | 0.0053 ns |  0.46 |    0.02 |         - |
|    StructEnumerable |           .NET 6.0 |           .NET 6.0 |         2 |   1.0844 ns | 0.0134 ns | 0.0126 ns |  1.28 |    0.05 |         - |
| RefStructEnumerable |           .NET 6.0 |           .NET 6.0 |         2 |   1.0939 ns | 0.0180 ns | 0.0160 ns |  1.29 |    0.05 |         - |
|   ArrayEnumerableV1 |           .NET 6.0 |           .NET 6.0 |         2 |   1.9477 ns | 0.0070 ns | 0.0062 ns |  2.30 |    0.08 |         - |
|          SysForEach | .NET Framework 4.8 | .NET Framework 4.8 |         2 |   0.8483 ns | 0.0293 ns | 0.0274 ns |  1.00 |    0.00 |         - |
|    StructEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |         2 |   1.8448 ns | 0.0097 ns | 0.0090 ns |  2.18 |    0.07 |         - |
| RefStructEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |         2 |   1.8527 ns | 0.0165 ns | 0.0138 ns |  2.18 |    0.07 |         - |
|   ArrayEnumerableV1 | .NET Framework 4.8 | .NET Framework 4.8 |         2 |   2.0605 ns | 0.0073 ns | 0.0068 ns |  2.43 |    0.08 |         - |
|                     |                    |                    |           |             |           |           |       |         |           |
|          **SysForEach** |           **.NET 5.0** |           **.NET 5.0** |        **20** |  **10.2285 ns** | **0.0569 ns** | **0.0533 ns** |  **1.49** |    **0.01** |         **-** |
|    StructEnumerable |           .NET 5.0 |           .NET 5.0 |        20 |  10.5224 ns | 0.0596 ns | 0.0558 ns |  1.53 |    0.01 |         - |
| RefStructEnumerable |           .NET 5.0 |           .NET 5.0 |        20 |   8.0105 ns | 0.0646 ns | 0.0604 ns |  1.17 |    0.01 |         - |
|   ArrayEnumerableV1 |           .NET 5.0 |           .NET 5.0 |        20 |  11.0884 ns | 0.0959 ns | 0.0850 ns |  1.62 |    0.02 |         - |
|          SysForEach |           .NET 6.0 |           .NET 6.0 |        20 |   5.9842 ns | 0.0401 ns | 0.0356 ns |  0.87 |    0.01 |         - |
|    StructEnumerable |           .NET 6.0 |           .NET 6.0 |        20 |   7.8641 ns | 0.0401 ns | 0.0375 ns |  1.15 |    0.01 |         - |
| RefStructEnumerable |           .NET 6.0 |           .NET 6.0 |        20 |   7.8656 ns | 0.0629 ns | 0.0588 ns |  1.15 |    0.01 |         - |
|   ArrayEnumerableV1 |           .NET 6.0 |           .NET 6.0 |        20 |  10.4796 ns | 0.0407 ns | 0.0381 ns |  1.53 |    0.01 |         - |
|          SysForEach | .NET Framework 4.8 | .NET Framework 4.8 |        20 |   6.8579 ns | 0.0465 ns | 0.0435 ns |  1.00 |    0.00 |         - |
|    StructEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |        20 |   8.3157 ns | 0.0428 ns | 0.0357 ns |  1.21 |    0.01 |         - |
| RefStructEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |        20 |   8.4234 ns | 0.1007 ns | 0.0942 ns |  1.23 |    0.02 |         - |
|   ArrayEnumerableV1 | .NET Framework 4.8 | .NET Framework 4.8 |        20 |  13.0549 ns | 0.0738 ns | 0.0691 ns |  1.90 |    0.02 |         - |
|                     |                    |                    |           |             |           |           |       |         |           |
|          **SysForEach** |           **.NET 5.0** |           **.NET 5.0** |       **100** |  **43.1960 ns** | **0.2061 ns** | **0.1827 ns** |  **0.99** |    **0.01** |         **-** |
|    StructEnumerable |           .NET 5.0 |           .NET 5.0 |       100 |  58.1305 ns | 0.4501 ns | 0.3990 ns |  1.33 |    0.01 |         - |
| RefStructEnumerable |           .NET 5.0 |           .NET 5.0 |       100 |  45.3003 ns | 0.1172 ns | 0.1097 ns |  1.04 |    0.00 |         - |
|   ArrayEnumerableV1 |           .NET 5.0 |           .NET 5.0 |       100 |  63.3466 ns | 0.2148 ns | 0.1904 ns |  1.45 |    0.01 |         - |
|          SysForEach |           .NET 6.0 |           .NET 6.0 |       100 |  42.7354 ns | 0.1138 ns | 0.1064 ns |  0.98 |    0.00 |         - |
|    StructEnumerable |           .NET 6.0 |           .NET 6.0 |       100 |  46.3047 ns | 0.1739 ns | 0.1452 ns |  1.06 |    0.00 |         - |
| RefStructEnumerable |           .NET 6.0 |           .NET 6.0 |       100 |  46.3702 ns | 0.1864 ns | 0.1743 ns |  1.06 |    0.01 |         - |
|   ArrayEnumerableV1 |           .NET 6.0 |           .NET 6.0 |       100 |  64.2843 ns | 0.2033 ns | 0.1802 ns |  1.47 |    0.01 |         - |
|          SysForEach | .NET Framework 4.8 | .NET Framework 4.8 |       100 |  43.7402 ns | 0.1363 ns | 0.1275 ns |  1.00 |    0.00 |         - |
|    StructEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |       100 |  45.7428 ns | 0.1973 ns | 0.1846 ns |  1.05 |    0.01 |         - |
| RefStructEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |       100 |  45.6049 ns | 0.1511 ns | 0.1413 ns |  1.04 |    0.00 |         - |
|   ArrayEnumerableV1 | .NET Framework 4.8 | .NET Framework 4.8 |       100 |  63.6860 ns | 0.0803 ns | 0.0712 ns |  1.46 |    0.00 |         - |
|                     |                    |                    |           |             |           |           |       |         |           |
|          **SysForEach** |           **.NET 5.0** |           **.NET 5.0** |      **1000** | **381.0066 ns** | **0.7150 ns** | **0.5971 ns** |  **1.00** |    **0.00** |         **-** |
|    StructEnumerable |           .NET 5.0 |           .NET 5.0 |      1000 | 518.0785 ns | 1.7207 ns | 1.6096 ns |  1.36 |    0.01 |         - |
| RefStructEnumerable |           .NET 5.0 |           .NET 5.0 |      1000 | 392.1199 ns | 0.8584 ns | 0.7168 ns |  1.03 |    0.00 |         - |
|   ArrayEnumerableV1 |           .NET 5.0 |           .NET 5.0 |      1000 | 584.9259 ns | 3.4681 ns | 2.8960 ns |  1.54 |    0.01 |         - |
|          SysForEach |           .NET 6.0 |           .NET 6.0 |      1000 | 380.1563 ns | 1.0023 ns | 0.9376 ns |  1.00 |    0.00 |         - |
|    StructEnumerable |           .NET 6.0 |           .NET 6.0 |      1000 | 404.9016 ns | 0.7473 ns | 0.6625 ns |  1.06 |    0.00 |         - |
| RefStructEnumerable |           .NET 6.0 |           .NET 6.0 |      1000 | 405.8414 ns | 1.6857 ns | 1.4076 ns |  1.07 |    0.00 |         - |
|   ArrayEnumerableV1 |           .NET 6.0 |           .NET 6.0 |      1000 | 580.2002 ns | 1.0439 ns | 0.9764 ns |  1.52 |    0.01 |         - |
|          SysForEach | .NET Framework 4.8 | .NET Framework 4.8 |      1000 | 380.8477 ns | 0.9991 ns | 0.8343 ns |  1.00 |    0.00 |         - |
|    StructEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |      1000 | 392.6993 ns | 0.9748 ns | 0.7610 ns |  1.03 |    0.00 |         - |
| RefStructEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |      1000 | 392.5307 ns | 0.9440 ns | 0.8369 ns |  1.03 |    0.00 |         - |
|   ArrayEnumerableV1 | .NET Framework 4.8 | .NET Framework 4.8 |      1000 | 568.6044 ns | 1.2277 ns | 1.1484 ns |  1.49 |    0.00 |         - |
