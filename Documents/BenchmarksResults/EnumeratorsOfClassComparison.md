## EnumeratorsOfClassComparison

### Source
[EnumeratorsOfClassComparison.cs](../../src/StructLinq.Benchmark/EnumeratorsOfClassComparison.cs)

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
|              Method |                Job |            Runtime | ItemCount |          Mean |     Error |    StdDev | Ratio | RatioSD | Allocated |
|-------------------- |------------------- |------------------- |---------- |--------------:|----------:|----------:|------:|--------:|----------:|
|          **SysForEach** |           **.NET 5.0** |           **.NET 5.0** |         **2** |     **0.7281 ns** | **0.0224 ns** | **0.0210 ns** |  **0.89** |    **0.02** |         **-** |
|    StructEnumerable |           .NET 5.0 |           .NET 5.0 |         2 |     1.8083 ns | 0.0109 ns | 0.0102 ns |  2.21 |    0.03 |         - |
| RefStructEnumerable |           .NET 5.0 |           .NET 5.0 |         2 |     3.9332 ns | 0.0168 ns | 0.0157 ns |  4.82 |    0.06 |         - |
|   ArrayEnumerableV1 |           .NET 5.0 |           .NET 5.0 |         2 |     1.8793 ns | 0.0082 ns | 0.0077 ns |  2.30 |    0.03 |         - |
|          SysForEach |           .NET 6.0 |           .NET 6.0 |         2 |     0.5627 ns | 0.0098 ns | 0.0087 ns |  0.69 |    0.01 |         - |
|    StructEnumerable |           .NET 6.0 |           .NET 6.0 |         2 |     1.1256 ns | 0.0090 ns | 0.0080 ns |  1.38 |    0.02 |         - |
| RefStructEnumerable |           .NET 6.0 |           .NET 6.0 |         2 |     4.3635 ns | 0.0259 ns | 0.0242 ns |  5.34 |    0.07 |         - |
|   ArrayEnumerableV1 |           .NET 6.0 |           .NET 6.0 |         2 |     2.7602 ns | 0.0842 ns | 0.0901 ns |  3.37 |    0.13 |         - |
|          SysForEach | .NET Framework 4.8 | .NET Framework 4.8 |         2 |     0.8167 ns | 0.0096 ns | 0.0090 ns |  1.00 |    0.00 |         - |
|    StructEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |         2 |     1.8558 ns | 0.0123 ns | 0.0109 ns |  2.27 |    0.03 |         - |
| RefStructEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |         2 |     4.8866 ns | 0.0164 ns | 0.0154 ns |  5.98 |    0.07 |         - |
|   ArrayEnumerableV1 | .NET Framework 4.8 | .NET Framework 4.8 |         2 |     2.0342 ns | 0.0089 ns | 0.0079 ns |  2.49 |    0.03 |         - |
|                     |                    |                    |           |               |           |           |       |         |           |
|          **SysForEach** |           **.NET 5.0** |           **.NET 5.0** |        **20** |    **10.0942 ns** | **0.0707 ns** | **0.0627 ns** |  **1.27** |    **0.01** |         **-** |
|    StructEnumerable |           .NET 5.0 |           .NET 5.0 |        20 |    11.4674 ns | 0.0279 ns | 0.0261 ns |  1.44 |    0.01 |         - |
| RefStructEnumerable |           .NET 5.0 |           .NET 5.0 |        20 |    27.2412 ns | 0.1107 ns | 0.1035 ns |  3.43 |    0.02 |         - |
|   ArrayEnumerableV1 |           .NET 5.0 |           .NET 5.0 |        20 |    10.5423 ns | 0.0610 ns | 0.0570 ns |  1.33 |    0.01 |         - |
|          SysForEach |           .NET 6.0 |           .NET 6.0 |        20 |     7.4516 ns | 0.0378 ns | 0.0353 ns |  0.94 |    0.01 |         - |
|    StructEnumerable |           .NET 6.0 |           .NET 6.0 |        20 |     8.1074 ns | 0.0535 ns | 0.0500 ns |  1.02 |    0.01 |         - |
| RefStructEnumerable |           .NET 6.0 |           .NET 6.0 |        20 |    36.6841 ns | 0.2613 ns | 0.2182 ns |  4.61 |    0.04 |         - |
|   ArrayEnumerableV1 |           .NET 6.0 |           .NET 6.0 |        20 |    11.5763 ns | 0.0417 ns | 0.0369 ns |  1.46 |    0.01 |         - |
|          SysForEach | .NET Framework 4.8 | .NET Framework 4.8 |        20 |     7.9523 ns | 0.0487 ns | 0.0456 ns |  1.00 |    0.00 |         - |
|    StructEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |        20 |    11.7250 ns | 0.0421 ns | 0.0394 ns |  1.47 |    0.01 |         - |
| RefStructEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |        20 |    41.9490 ns | 0.0673 ns | 0.0525 ns |  5.27 |    0.03 |         - |
|   ArrayEnumerableV1 | .NET Framework 4.8 | .NET Framework 4.8 |        20 |    12.8506 ns | 0.0901 ns | 0.0843 ns |  1.62 |    0.02 |         - |
|                     |                    |                    |           |               |           |           |       |         |           |
|          **SysForEach** |           **.NET 5.0** |           **.NET 5.0** |       **100** |    **43.1936 ns** | **0.0870 ns** | **0.0814 ns** |  **1.00** |    **0.00** |         **-** |
|    StructEnumerable |           .NET 5.0 |           .NET 5.0 |       100 |    57.3076 ns | 0.2284 ns | 0.2025 ns |  1.32 |    0.00 |         - |
| RefStructEnumerable |           .NET 5.0 |           .NET 5.0 |       100 |   134.4422 ns | 0.3317 ns | 0.2770 ns |  3.11 |    0.01 |         - |
|   ArrayEnumerableV1 |           .NET 5.0 |           .NET 5.0 |       100 |    64.0256 ns | 0.3043 ns | 0.2697 ns |  1.48 |    0.01 |         - |
|          SysForEach |           .NET 6.0 |           .NET 6.0 |       100 |    42.3607 ns | 0.1375 ns | 0.1148 ns |  0.98 |    0.00 |         - |
|    StructEnumerable |           .NET 6.0 |           .NET 6.0 |       100 |    46.2770 ns | 0.2064 ns | 0.1931 ns |  1.07 |    0.00 |         - |
| RefStructEnumerable |           .NET 6.0 |           .NET 6.0 |       100 |   184.5733 ns | 0.4382 ns | 0.3884 ns |  4.27 |    0.01 |         - |
|   ArrayEnumerableV1 |           .NET 6.0 |           .NET 6.0 |       100 |    63.1196 ns | 0.2341 ns | 0.2075 ns |  1.46 |    0.01 |         - |
|          SysForEach | .NET Framework 4.8 | .NET Framework 4.8 |       100 |    43.2745 ns | 0.0829 ns | 0.0735 ns |  1.00 |    0.00 |         - |
|    StructEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |       100 |    57.6171 ns | 0.1232 ns | 0.1092 ns |  1.33 |    0.00 |         - |
| RefStructEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |       100 |   212.5996 ns | 1.0991 ns | 0.9743 ns |  4.91 |    0.02 |         - |
|   ArrayEnumerableV1 | .NET Framework 4.8 | .NET Framework 4.8 |       100 |    64.6886 ns | 1.2799 ns | 1.1972 ns |  1.50 |    0.03 |         - |
|                     |                    |                    |           |               |           |           |       |         |           |
|          **SysForEach** |           **.NET 5.0** |           **.NET 5.0** |      **1000** |   **385.9852 ns** | **6.0947 ns** | **5.4028 ns** |  **0.99** |    **0.02** |         **-** |
|    StructEnumerable |           .NET 5.0 |           .NET 5.0 |      1000 |   516.4938 ns | 1.9643 ns | 1.7413 ns |  1.33 |    0.01 |         - |
| RefStructEnumerable |           .NET 5.0 |           .NET 5.0 |      1000 | 1,292.3309 ns | 5.5562 ns | 4.6397 ns |  3.32 |    0.02 |         - |
|   ArrayEnumerableV1 |           .NET 5.0 |           .NET 5.0 |      1000 |   579.2085 ns | 2.0621 ns | 1.9289 ns |  1.49 |    0.00 |         - |
|          SysForEach |           .NET 6.0 |           .NET 6.0 |      1000 |   383.5269 ns | 1.2144 ns | 1.1359 ns |  0.99 |    0.01 |         - |
|    StructEnumerable |           .NET 6.0 |           .NET 6.0 |      1000 |   411.9310 ns | 2.0419 ns | 1.8101 ns |  1.06 |    0.01 |         - |
| RefStructEnumerable |           .NET 6.0 |           .NET 6.0 |      1000 | 1,792.7233 ns | 4.2465 ns | 3.7644 ns |  4.61 |    0.01 |         - |
|   ArrayEnumerableV1 |           .NET 6.0 |           .NET 6.0 |      1000 |   601.6275 ns | 1.7171 ns | 1.4338 ns |  1.55 |    0.01 |         - |
|          SysForEach | .NET Framework 4.8 | .NET Framework 4.8 |      1000 |   388.8727 ns | 1.4132 ns | 1.1801 ns |  1.00 |    0.00 |         - |
|    StructEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |      1000 |   519.3742 ns | 1.8484 ns | 1.6385 ns |  1.34 |    0.00 |         - |
| RefStructEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |      1000 | 2,049.0026 ns | 6.9928 ns | 6.5410 ns |  5.27 |    0.02 |         - |
|   ArrayEnumerableV1 | .NET Framework 4.8 | .NET Framework 4.8 |      1000 |   584.2992 ns | 2.3181 ns | 2.1684 ns |  1.50 |    0.01 |         - |
