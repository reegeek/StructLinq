## EnumeratorsComparison

### Source
[EnumeratorsComparison.cs](../../src/StructLinq.Benchmark/EnumeratorsComparison.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]             : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  .NET 6.0           : .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
  .NET 7.0           : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  .NET Framework 4.8 : .NET Framework 4.8.1 (4.8.9105.0), X64 RyuJIT VectorSize=256


```
|              Method |                Job |            Runtime | ItemCount |        Mean |     Error |    StdDev | Ratio | RatioSD | Allocated | Alloc Ratio |
|-------------------- |------------------- |------------------- |---------- |------------:|----------:|----------:|------:|--------:|----------:|------------:|
|          **SysForEach** |           **.NET 6.0** |           **.NET 6.0** |         **2** |   **0.5395 ns** | **0.0089 ns** | **0.0084 ns** |  **0.53** |    **0.01** |         **-** |          **NA** |
|    StructEnumerable |           .NET 6.0 |           .NET 6.0 |         2 |   1.0813 ns | 0.0078 ns | 0.0073 ns |  1.06 |    0.01 |         - |          NA |
| RefStructEnumerable |           .NET 6.0 |           .NET 6.0 |         2 |   1.0727 ns | 0.0079 ns | 0.0074 ns |  1.05 |    0.01 |         - |          NA |
|   ArrayEnumerableV1 |           .NET 6.0 |           .NET 6.0 |         2 |   2.7919 ns | 0.0113 ns | 0.0100 ns |  2.74 |    0.03 |         - |          NA |
|          SysForEach |           .NET 7.0 |           .NET 7.0 |         2 |   0.7274 ns | 0.0090 ns | 0.0080 ns |  0.71 |    0.01 |         - |          NA |
|    StructEnumerable |           .NET 7.0 |           .NET 7.0 |         2 |   0.9126 ns | 0.0229 ns | 0.0214 ns |  0.90 |    0.02 |         - |          NA |
| RefStructEnumerable |           .NET 7.0 |           .NET 7.0 |         2 |   0.8818 ns | 0.0055 ns | 0.0049 ns |  0.87 |    0.01 |         - |          NA |
|   ArrayEnumerableV1 |           .NET 7.0 |           .NET 7.0 |         2 |   2.6261 ns | 0.0432 ns | 0.0404 ns |  2.58 |    0.04 |         - |          NA |
|          SysForEach | .NET Framework 4.8 | .NET Framework 4.8 |         2 |   1.0190 ns | 0.0093 ns | 0.0087 ns |  1.00 |    0.00 |         - |          NA |
|    StructEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |         2 |   1.7663 ns | 0.0099 ns | 0.0083 ns |  1.74 |    0.02 |         - |          NA |
| RefStructEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |         2 |   1.7838 ns | 0.0095 ns | 0.0079 ns |  1.75 |    0.02 |         - |          NA |
|   ArrayEnumerableV1 | .NET Framework 4.8 | .NET Framework 4.8 |         2 |   2.7393 ns | 0.0215 ns | 0.0201 ns |  2.69 |    0.04 |         - |          NA |
|                     |                    |                    |           |             |           |           |       |         |           |             |
|          **SysForEach** |           **.NET 6.0** |           **.NET 6.0** |        **20** |   **5.8328 ns** | **0.0136 ns** | **0.0113 ns** |  **0.58** |    **0.00** |         **-** |          **NA** |
|    StructEnumerable |           .NET 6.0 |           .NET 6.0 |        20 |   7.7520 ns | 0.0231 ns | 0.0193 ns |  0.77 |    0.00 |         - |          NA |
| RefStructEnumerable |           .NET 6.0 |           .NET 6.0 |        20 |   7.7400 ns | 0.0325 ns | 0.0288 ns |  0.77 |    0.00 |         - |          NA |
|   ArrayEnumerableV1 |           .NET 6.0 |           .NET 6.0 |        20 |  11.4317 ns | 0.0423 ns | 0.0395 ns |  1.13 |    0.01 |         - |          NA |
|          SysForEach |           .NET 7.0 |           .NET 7.0 |        20 |   5.2822 ns | 0.0334 ns | 0.0296 ns |  0.52 |    0.00 |         - |          NA |
|    StructEnumerable |           .NET 7.0 |           .NET 7.0 |        20 |   7.1606 ns | 0.0236 ns | 0.0210 ns |  0.71 |    0.01 |         - |          NA |
| RefStructEnumerable |           .NET 7.0 |           .NET 7.0 |        20 |   7.2399 ns | 0.1234 ns | 0.1155 ns |  0.72 |    0.01 |         - |          NA |
|   ArrayEnumerableV1 |           .NET 7.0 |           .NET 7.0 |        20 |  11.6708 ns | 0.0431 ns | 0.0382 ns |  1.16 |    0.01 |         - |          NA |
|          SysForEach | .NET Framework 4.8 | .NET Framework 4.8 |        20 |  10.0910 ns | 0.0602 ns | 0.0534 ns |  1.00 |    0.00 |         - |          NA |
|    StructEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |        20 |  11.2802 ns | 0.0461 ns | 0.0409 ns |  1.12 |    0.01 |         - |          NA |
| RefStructEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |        20 |  11.2868 ns | 0.0525 ns | 0.0491 ns |  1.12 |    0.01 |         - |          NA |
|   ArrayEnumerableV1 | .NET Framework 4.8 | .NET Framework 4.8 |        20 |  11.7509 ns | 0.1469 ns | 0.1374 ns |  1.17 |    0.01 |         - |          NA |
|                     |                    |                    |           |             |           |           |       |         |           |             |
|          **SysForEach** |           **.NET 6.0** |           **.NET 6.0** |       **100** |  **42.2655 ns** | **0.1662 ns** | **0.1554 ns** |  **0.75** |    **0.00** |         **-** |          **NA** |
|    StructEnumerable |           .NET 6.0 |           .NET 6.0 |       100 |  45.9079 ns | 0.1442 ns | 0.1349 ns |  0.81 |    0.00 |         - |          NA |
| RefStructEnumerable |           .NET 6.0 |           .NET 6.0 |       100 |  45.2104 ns | 0.3548 ns | 0.2963 ns |  0.80 |    0.01 |         - |          NA |
|   ArrayEnumerableV1 |           .NET 6.0 |           .NET 6.0 |       100 |  62.3430 ns | 0.3062 ns | 0.2864 ns |  1.11 |    0.01 |         - |          NA |
|          SysForEach |           .NET 7.0 |           .NET 7.0 |       100 |  38.9808 ns | 0.0955 ns | 0.0798 ns |  0.69 |    0.00 |         - |          NA |
|    StructEnumerable |           .NET 7.0 |           .NET 7.0 |       100 |  41.6850 ns | 0.2103 ns | 0.1967 ns |  0.74 |    0.00 |         - |          NA |
| RefStructEnumerable |           .NET 7.0 |           .NET 7.0 |       100 |  42.0053 ns | 0.2092 ns | 0.1957 ns |  0.74 |    0.00 |         - |          NA |
|   ArrayEnumerableV1 |           .NET 7.0 |           .NET 7.0 |       100 |  58.2898 ns | 0.1694 ns | 0.1584 ns |  1.03 |    0.00 |         - |          NA |
|          SysForEach | .NET Framework 4.8 | .NET Framework 4.8 |       100 |  56.4203 ns | 0.1987 ns | 0.1659 ns |  1.00 |    0.00 |         - |          NA |
|    StructEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |       100 |  56.9391 ns | 0.1976 ns | 0.1848 ns |  1.01 |    0.00 |         - |          NA |
| RefStructEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |       100 |  56.9231 ns | 0.1793 ns | 0.1677 ns |  1.01 |    0.00 |         - |          NA |
|   ArrayEnumerableV1 | .NET Framework 4.8 | .NET Framework 4.8 |       100 |  64.2843 ns | 1.2006 ns | 1.0643 ns |  1.14 |    0.02 |         - |          NA |
|                     |                    |                    |           |             |           |           |       |         |           |             |
|          **SysForEach** |           **.NET 6.0** |           **.NET 6.0** |      **1000** | **375.3040 ns** | **1.2134 ns** | **1.0756 ns** |  **0.73** |    **0.00** |         **-** |          **NA** |
|    StructEnumerable |           .NET 6.0 |           .NET 6.0 |      1000 | 387.3172 ns | 1.6300 ns | 1.5247 ns |  0.76 |    0.01 |         - |          NA |
| RefStructEnumerable |           .NET 6.0 |           .NET 6.0 |      1000 | 388.6788 ns | 3.0873 ns | 2.5780 ns |  0.76 |    0.01 |         - |          NA |
|   ArrayEnumerableV1 |           .NET 6.0 |           .NET 6.0 |      1000 | 576.8136 ns | 1.7095 ns | 1.5991 ns |  1.13 |    0.01 |         - |          NA |
|          SysForEach |           .NET 7.0 |           .NET 7.0 |      1000 | 335.6658 ns | 0.9673 ns | 0.9048 ns |  0.66 |    0.00 |         - |          NA |
|    StructEnumerable |           .NET 7.0 |           .NET 7.0 |      1000 | 362.2799 ns | 0.7993 ns | 0.6240 ns |  0.71 |    0.00 |         - |          NA |
| RefStructEnumerable |           .NET 7.0 |           .NET 7.0 |      1000 | 362.7813 ns | 0.7799 ns | 0.6913 ns |  0.71 |    0.00 |         - |          NA |
|   ArrayEnumerableV1 |           .NET 7.0 |           .NET 7.0 |      1000 | 548.3063 ns | 1.4988 ns | 1.4020 ns |  1.07 |    0.01 |         - |          NA |
|          SysForEach | .NET Framework 4.8 | .NET Framework 4.8 |      1000 | 511.3674 ns | 2.6135 ns | 2.4447 ns |  1.00 |    0.00 |         - |          NA |
|    StructEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |      1000 | 511.8095 ns | 2.4448 ns | 1.9087 ns |  1.00 |    0.01 |         - |          NA |
| RefStructEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |      1000 | 511.5876 ns | 2.7156 ns | 2.5402 ns |  1.00 |    0.01 |         - |          NA |
|   ArrayEnumerableV1 | .NET Framework 4.8 | .NET Framework 4.8 |      1000 | 575.1538 ns | 2.6253 ns | 2.4557 ns |  1.12 |    0.01 |         - |          NA |
