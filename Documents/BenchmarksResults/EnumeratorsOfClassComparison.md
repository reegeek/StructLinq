## EnumeratorsOfClassComparison

### Source
[EnumeratorsOfClassComparison.cs](../../src/StructLinq.Benchmark/EnumeratorsOfClassComparison.cs)

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
|              Method |                Job |            Runtime | ItemCount |          Mean |     Error |    StdDev | Ratio | RatioSD | Allocated | Alloc Ratio |
|-------------------- |------------------- |------------------- |---------- |--------------:|----------:|----------:|------:|--------:|----------:|------------:|
|          **SysForEach** |           **.NET 6.0** |           **.NET 6.0** |         **2** |     **0.5343 ns** | **0.0078 ns** | **0.0065 ns** |  **0.61** |    **0.01** |         **-** |          **NA** |
|    StructEnumerable |           .NET 6.0 |           .NET 6.0 |         2 |     1.1754 ns | 0.0072 ns | 0.0067 ns |  1.35 |    0.01 |         - |          NA |
| RefStructEnumerable |           .NET 6.0 |           .NET 6.0 |         2 |     4.2659 ns | 0.0223 ns | 0.0209 ns |  4.89 |    0.05 |         - |          NA |
|   ArrayEnumerableV1 |           .NET 6.0 |           .NET 6.0 |         2 |     1.9187 ns | 0.0064 ns | 0.0057 ns |  2.20 |    0.02 |         - |          NA |
|          SysForEach |           .NET 7.0 |           .NET 7.0 |         2 |     0.3236 ns | 0.0070 ns | 0.0066 ns |  0.37 |    0.01 |         - |          NA |
|    StructEnumerable |           .NET 7.0 |           .NET 7.0 |         2 |     1.1216 ns | 0.0161 ns | 0.0125 ns |  1.29 |    0.02 |         - |          NA |
| RefStructEnumerable |           .NET 7.0 |           .NET 7.0 |         2 |     3.5145 ns | 0.0151 ns | 0.0141 ns |  4.03 |    0.03 |         - |          NA |
|   ArrayEnumerableV1 |           .NET 7.0 |           .NET 7.0 |         2 |     2.6961 ns | 0.0417 ns | 0.0370 ns |  3.09 |    0.04 |         - |          NA |
|          SysForEach | .NET Framework 4.8 | .NET Framework 4.8 |         2 |     0.8715 ns | 0.0068 ns | 0.0064 ns |  1.00 |    0.00 |         - |          NA |
|    StructEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |         2 |     1.7980 ns | 0.0106 ns | 0.0099 ns |  2.06 |    0.02 |         - |          NA |
| RefStructEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |         2 |     4.7799 ns | 0.0471 ns | 0.0418 ns |  5.48 |    0.05 |         - |          NA |
|   ArrayEnumerableV1 | .NET Framework 4.8 | .NET Framework 4.8 |         2 |     1.9630 ns | 0.0120 ns | 0.0112 ns |  2.25 |    0.02 |         - |          NA |
|                     |                    |                    |           |               |           |           |       |         |           |             |
|          **SysForEach** |           **.NET 6.0** |           **.NET 6.0** |        **20** |     **7.3636 ns** | **0.0330 ns** | **0.0292 ns** |  **0.80** |    **0.01** |         **-** |          **NA** |
|    StructEnumerable |           .NET 6.0 |           .NET 6.0 |        20 |     8.0347 ns | 0.0536 ns | 0.0475 ns |  0.87 |    0.01 |         - |          NA |
| RefStructEnumerable |           .NET 6.0 |           .NET 6.0 |        20 |    36.4098 ns | 0.1259 ns | 0.1178 ns |  3.94 |    0.02 |         - |          NA |
|   ArrayEnumerableV1 |           .NET 6.0 |           .NET 6.0 |        20 |    10.3801 ns | 0.0524 ns | 0.0438 ns |  1.12 |    0.01 |         - |          NA |
|          SysForEach |           .NET 7.0 |           .NET 7.0 |        20 |     7.1847 ns | 0.0162 ns | 0.0151 ns |  0.78 |    0.01 |         - |          NA |
|    StructEnumerable |           .NET 7.0 |           .NET 7.0 |        20 |     7.4567 ns | 0.0371 ns | 0.0347 ns |  0.81 |    0.01 |         - |          NA |
| RefStructEnumerable |           .NET 7.0 |           .NET 7.0 |        20 |    27.0646 ns | 0.0761 ns | 0.0712 ns |  2.93 |    0.02 |         - |          NA |
|   ArrayEnumerableV1 |           .NET 7.0 |           .NET 7.0 |        20 |    11.7025 ns | 0.0531 ns | 0.0497 ns |  1.27 |    0.01 |         - |          NA |
|          SysForEach | .NET Framework 4.8 | .NET Framework 4.8 |        20 |     9.2473 ns | 0.0676 ns | 0.0633 ns |  1.00 |    0.00 |         - |          NA |
|    StructEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |        20 |     8.4576 ns | 0.0449 ns | 0.0375 ns |  0.91 |    0.01 |         - |          NA |
| RefStructEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |        20 |    41.2686 ns | 0.1452 ns | 0.1358 ns |  4.46 |    0.03 |         - |          NA |
|   ArrayEnumerableV1 | .NET Framework 4.8 | .NET Framework 4.8 |        20 |    12.5941 ns | 0.1933 ns | 0.1808 ns |  1.36 |    0.02 |         - |          NA |
|                     |                    |                    |           |               |           |           |       |         |           |             |
|          **SysForEach** |           **.NET 6.0** |           **.NET 6.0** |       **100** |    **41.8216 ns** | **0.1131 ns** | **0.0883 ns** |  **0.98** |    **0.00** |         **-** |          **NA** |
|    StructEnumerable |           .NET 6.0 |           .NET 6.0 |       100 |    50.7101 ns | 0.2273 ns | 0.2126 ns |  1.18 |    0.01 |         - |          NA |
| RefStructEnumerable |           .NET 6.0 |           .NET 6.0 |       100 |   182.2898 ns | 0.4978 ns | 0.4413 ns |  4.26 |    0.02 |         - |          NA |
|   ArrayEnumerableV1 |           .NET 6.0 |           .NET 6.0 |       100 |    64.5356 ns | 0.1247 ns | 0.1106 ns |  1.51 |    0.01 |         - |          NA |
|          SysForEach |           .NET 7.0 |           .NET 7.0 |       100 |    38.2186 ns | 0.1173 ns | 0.1097 ns |  0.89 |    0.00 |         - |          NA |
|    StructEnumerable |           .NET 7.0 |           .NET 7.0 |       100 |    48.4332 ns | 0.1263 ns | 0.1119 ns |  1.13 |    0.01 |         - |          NA |
| RefStructEnumerable |           .NET 7.0 |           .NET 7.0 |       100 |   132.0450 ns | 0.6168 ns | 0.5769 ns |  3.08 |    0.02 |         - |          NA |
|   ArrayEnumerableV1 |           .NET 7.0 |           .NET 7.0 |       100 |    63.0986 ns | 0.3804 ns | 0.3177 ns |  1.47 |    0.01 |         - |          NA |
|          SysForEach | .NET Framework 4.8 | .NET Framework 4.8 |       100 |    42.8077 ns | 0.2121 ns | 0.1984 ns |  1.00 |    0.00 |         - |          NA |
|    StructEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |       100 |    45.0511 ns | 0.1275 ns | 0.1193 ns |  1.05 |    0.01 |         - |          NA |
| RefStructEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |       100 |   209.8996 ns | 2.0086 ns | 1.8788 ns |  4.90 |    0.04 |         - |          NA |
|   ArrayEnumerableV1 | .NET Framework 4.8 | .NET Framework 4.8 |       100 |    63.1082 ns | 0.2940 ns | 0.2750 ns |  1.47 |    0.01 |         - |          NA |
|                     |                    |                    |           |               |           |           |       |         |           |             |
|          **SysForEach** |           **.NET 6.0** |           **.NET 6.0** |      **1000** |   **380.0392 ns** | **1.0106 ns** | **0.8959 ns** |  **0.99** |    **0.00** |         **-** |          **NA** |
|    StructEnumerable |           .NET 6.0 |           .NET 6.0 |      1000 |   459.3685 ns | 1.9569 ns | 1.5279 ns |  1.19 |    0.01 |         - |          NA |
| RefStructEnumerable |           .NET 6.0 |           .NET 6.0 |      1000 | 1,774.3384 ns | 5.4550 ns | 4.8357 ns |  4.61 |    0.01 |         - |          NA |
|   ArrayEnumerableV1 |           .NET 6.0 |           .NET 6.0 |      1000 |   589.4086 ns | 1.9439 ns | 1.8184 ns |  1.53 |    0.01 |         - |          NA |
|          SysForEach |           .NET 7.0 |           .NET 7.0 |      1000 |   341.6170 ns | 1.1088 ns | 0.9829 ns |  0.89 |    0.00 |         - |          NA |
|    StructEnumerable |           .NET 7.0 |           .NET 7.0 |      1000 |   427.3177 ns | 1.7373 ns | 1.6250 ns |  1.11 |    0.01 |         - |          NA |
| RefStructEnumerable |           .NET 7.0 |           .NET 7.0 |      1000 | 1,151.8379 ns | 4.3133 ns | 3.8237 ns |  3.00 |    0.01 |         - |          NA |
|   ArrayEnumerableV1 |           .NET 7.0 |           .NET 7.0 |      1000 |   592.2095 ns | 1.6298 ns | 1.4448 ns |  1.54 |    0.00 |         - |          NA |
|          SysForEach | .NET Framework 4.8 | .NET Framework 4.8 |      1000 |   384.5781 ns | 1.0437 ns | 0.9762 ns |  1.00 |    0.00 |         - |          NA |
|    StructEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |      1000 |   399.2857 ns | 1.6379 ns | 1.3677 ns |  1.04 |    0.00 |         - |          NA |
| RefStructEnumerable | .NET Framework 4.8 | .NET Framework 4.8 |      1000 | 2,024.1282 ns | 7.7783 ns | 7.2758 ns |  5.26 |    0.03 |         - |          NA |
|   ArrayEnumerableV1 | .NET Framework 4.8 | .NET Framework 4.8 |      1000 |   579.7843 ns | 4.6360 ns | 3.8713 ns |  1.51 |    0.01 |         - |          NA |
