## EnumeratorsComparison

### Source
[EnumeratorsComparison.cs](../../src/StructLinq.Benchmark/EnumeratorsComparison.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]        : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4250.0), X64 RyuJIT
  .NET Core 5.0 : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|              Method |           Job |       Runtime | ItemCount |        Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated | Code Size |
|-------------------- |-------------- |-------------- |---------- |------------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|----------:|
|          **SysForEach** |      **.NET 4.8** |      **.NET 4.8** |         **2** |   **1.0254 ns** | **0.0152 ns** | **0.0142 ns** |  **1.00** |    **0.00** |     **-** |     **-** |     **-** |         **-** |      **36 B** |
|    StructEnumerable |      .NET 4.8 |      .NET 4.8 |         2 |   1.7000 ns | 0.0385 ns | 0.0361 ns |  1.66 |    0.04 |     - |     - |     - |         - |      72 B |
| RefStructEnumerable |      .NET 4.8 |      .NET 4.8 |         2 |   1.6780 ns | 0.0186 ns | 0.0174 ns |  1.64 |    0.03 |     - |     - |     - |         - |      72 B |
|   ArrayEnumerableV1 |      .NET 4.8 |      .NET 4.8 |         2 |   2.0070 ns | 0.0575 ns | 0.0538 ns |  1.96 |    0.06 |     - |     - |     - |         - |      62 B |
|                     |               |               |           |             |           |           |       |         |       |       |       |           |           |
|          SysForEach | .NET Core 5.0 | .NET Core 5.0 |         2 |   0.7697 ns | 0.0219 ns | 0.0183 ns |  1.00 |    0.00 |     - |     - |     - |         - |      36 B |
|    StructEnumerable | .NET Core 5.0 | .NET Core 5.0 |         2 |   1.8563 ns | 0.0240 ns | 0.0213 ns |  2.41 |    0.06 |     - |     - |     - |         - |      72 B |
| RefStructEnumerable | .NET Core 5.0 | .NET Core 5.0 |         2 |   1.8548 ns | 0.0092 ns | 0.0086 ns |  2.41 |    0.05 |     - |     - |     - |         - |      72 B |
|   ArrayEnumerableV1 | .NET Core 5.0 | .NET Core 5.0 |         2 |   1.9729 ns | 0.0165 ns | 0.0155 ns |  2.56 |    0.06 |     - |     - |     - |         - |      62 B |
|                     |               |               |           |             |           |           |       |         |       |       |       |           |           |
|          **SysForEach** |      **.NET 4.8** |      **.NET 4.8** |        **20** |  **10.4803 ns** | **0.0725 ns** | **0.0678 ns** |  **1.00** |    **0.00** |     **-** |     **-** |     **-** |         **-** |      **36 B** |
|    StructEnumerable |      .NET 4.8 |      .NET 4.8 |        20 |   8.4597 ns | 0.0450 ns | 0.0376 ns |  0.81 |    0.01 |     - |     - |     - |         - |      72 B |
| RefStructEnumerable |      .NET 4.8 |      .NET 4.8 |        20 |   8.5590 ns | 0.0585 ns | 0.0547 ns |  0.82 |    0.01 |     - |     - |     - |         - |      72 B |
|   ArrayEnumerableV1 |      .NET 4.8 |      .NET 4.8 |        20 |  11.0326 ns | 0.0312 ns | 0.0277 ns |  1.05 |    0.01 |     - |     - |     - |         - |      62 B |
|                     |               |               |           |             |           |           |       |         |       |       |       |           |           |
|          SysForEach | .NET Core 5.0 | .NET Core 5.0 |        20 |   7.1173 ns | 0.1710 ns | 0.1756 ns |  1.00 |    0.00 |     - |     - |     - |         - |      36 B |
|    StructEnumerable | .NET Core 5.0 | .NET Core 5.0 |        20 |   7.9055 ns | 0.0364 ns | 0.0341 ns |  1.11 |    0.03 |     - |     - |     - |         - |      72 B |
| RefStructEnumerable | .NET Core 5.0 | .NET Core 5.0 |        20 |   8.0814 ns | 0.1132 ns | 0.1059 ns |  1.13 |    0.03 |     - |     - |     - |         - |      72 B |
|   ArrayEnumerableV1 | .NET Core 5.0 | .NET Core 5.0 |        20 |  12.7757 ns | 0.1141 ns | 0.1068 ns |  1.79 |    0.04 |     - |     - |     - |         - |      62 B |
|                     |               |               |           |             |           |           |       |         |       |       |       |           |           |
|          **SysForEach** |      **.NET 4.8** |      **.NET 4.8** |       **100** |  **58.4095 ns** | **0.5859 ns** | **0.5481 ns** |  **1.00** |    **0.00** |     **-** |     **-** |     **-** |         **-** |      **36 B** |
|    StructEnumerable |      .NET 4.8 |      .NET 4.8 |       100 |  46.8707 ns | 0.3890 ns | 0.3448 ns |  0.80 |    0.01 |     - |     - |     - |         - |      72 B |
| RefStructEnumerable |      .NET 4.8 |      .NET 4.8 |       100 |  46.1693 ns | 0.2040 ns | 0.1908 ns |  0.79 |    0.01 |     - |     - |     - |         - |      72 B |
|   ArrayEnumerableV1 |      .NET 4.8 |      .NET 4.8 |       100 |  63.1994 ns | 0.2711 ns | 0.2264 ns |  1.08 |    0.01 |     - |     - |     - |         - |      62 B |
|                     |               |               |           |             |           |           |       |         |       |       |       |           |           |
|          SysForEach | .NET Core 5.0 | .NET Core 5.0 |       100 |  43.5358 ns | 0.1196 ns | 0.1119 ns |  1.00 |    0.00 |     - |     - |     - |         - |      36 B |
|    StructEnumerable | .NET Core 5.0 | .NET Core 5.0 |       100 |  46.7477 ns | 0.2604 ns | 0.2308 ns |  1.07 |    0.01 |     - |     - |     - |         - |      72 B |
| RefStructEnumerable | .NET Core 5.0 | .NET Core 5.0 |       100 |  46.3547 ns | 0.3105 ns | 0.2752 ns |  1.06 |    0.01 |     - |     - |     - |         - |      72 B |
|   ArrayEnumerableV1 | .NET Core 5.0 | .NET Core 5.0 |       100 |  64.1099 ns | 0.2696 ns | 0.2522 ns |  1.47 |    0.01 |     - |     - |     - |         - |      62 B |
|                     |               |               |           |             |           |           |       |         |       |       |       |           |           |
|          **SysForEach** |      **.NET 4.8** |      **.NET 4.8** |      **1000** | **524.4196 ns** | **3.2416 ns** | **3.0322 ns** |  **1.00** |    **0.00** |     **-** |     **-** |     **-** |         **-** |      **36 B** |
|    StructEnumerable |      .NET 4.8 |      .NET 4.8 |      1000 | 407.2377 ns | 8.1047 ns | 7.9599 ns |  0.78 |    0.02 |     - |     - |     - |         - |      72 B |
| RefStructEnumerable |      .NET 4.8 |      .NET 4.8 |      1000 | 401.5708 ns | 2.5982 ns | 2.4304 ns |  0.77 |    0.01 |     - |     - |     - |         - |      72 B |
|   ArrayEnumerableV1 |      .NET 4.8 |      .NET 4.8 |      1000 | 585.7822 ns | 4.7982 ns | 4.4882 ns |  1.12 |    0.01 |     - |     - |     - |         - |      62 B |
|                     |               |               |           |             |           |           |       |         |       |       |       |           |           |
|          SysForEach | .NET Core 5.0 | .NET Core 5.0 |      1000 | 392.8156 ns | 3.3804 ns | 3.1620 ns |  1.00 |    0.00 |     - |     - |     - |         - |      36 B |
|    StructEnumerable | .NET Core 5.0 | .NET Core 5.0 |      1000 | 400.6280 ns | 1.2286 ns | 1.0259 ns |  1.02 |    0.01 |     - |     - |     - |         - |      72 B |
| RefStructEnumerable | .NET Core 5.0 | .NET Core 5.0 |      1000 | 398.7407 ns | 1.7288 ns | 1.6171 ns |  1.02 |    0.01 |     - |     - |     - |         - |      72 B |
|   ArrayEnumerableV1 | .NET Core 5.0 | .NET Core 5.0 |      1000 | 576.6521 ns | 1.8377 ns | 1.6290 ns |  1.47 |    0.01 |     - |     - |     - |         - |      62 B |
