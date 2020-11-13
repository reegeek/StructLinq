## EnumeratorsComparison

### Source
[EnumeratorsComparison.cs](../../src/StructLinq.Benchmark/EnumeratorsComparison.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  Job-ILXHKQ : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  Job-DKIKQP : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|              Method |       Runtime | ItemCount |        Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |-------------- |---------- |------------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
|          **SysForEach** |      **.NET 4.8** |         **2** |   **0.4484 ns** | **0.0098 ns** | **0.0076 ns** |  **1.00** |    **0.00** |     **-** |     **-** |     **-** |         **-** |
|    StructEnumerable |      .NET 4.8 |         2 |   2.1040 ns | 0.0072 ns | 0.0068 ns |  4.69 |    0.07 |     - |     - |     - |         - |
| RefStructEnumerable |      .NET 4.8 |         2 |   2.1028 ns | 0.0058 ns | 0.0051 ns |  4.69 |    0.08 |     - |     - |     - |         - |
|   ArrayEnumerableV1 |      .NET 4.8 |         2 |   2.1392 ns | 0.0065 ns | 0.0061 ns |  4.77 |    0.07 |     - |     - |     - |         - |
|                     |               |           |             |           |           |       |         |       |       |       |           |
|          SysForEach | .NET Core 3.1 |         2 |   0.5380 ns | 0.0044 ns | 0.0039 ns |  1.00 |    0.00 |     - |     - |     - |         - |
|    StructEnumerable | .NET Core 3.1 |         2 |   1.9507 ns | 0.0035 ns | 0.0033 ns |  3.63 |    0.03 |     - |     - |     - |         - |
| RefStructEnumerable | .NET Core 3.1 |         2 |   1.9069 ns | 0.0055 ns | 0.0052 ns |  3.54 |    0.03 |     - |     - |     - |         - |
|   ArrayEnumerableV1 | .NET Core 3.1 |         2 |   2.2002 ns | 0.0094 ns | 0.0088 ns |  4.09 |    0.04 |     - |     - |     - |         - |
|                     |               |           |             |           |           |       |         |       |       |       |           |
|          **SysForEach** |      **.NET 4.8** |        **20** |   **7.3736 ns** | **0.0592 ns** | **0.0554 ns** |  **1.00** |    **0.00** |     **-** |     **-** |     **-** |         **-** |
|    StructEnumerable |      .NET 4.8 |        20 |  12.9366 ns | 0.0443 ns | 0.0414 ns |  1.75 |    0.01 |     - |     - |     - |         - |
| RefStructEnumerable |      .NET 4.8 |        20 |  12.8157 ns | 0.0268 ns | 0.0251 ns |  1.74 |    0.01 |     - |     - |     - |         - |
|   ArrayEnumerableV1 |      .NET 4.8 |        20 |  11.8658 ns | 0.0415 ns | 0.0368 ns |  1.61 |    0.01 |     - |     - |     - |         - |
|                     |               |           |             |           |           |       |         |       |       |       |           |
|          SysForEach | .NET Core 3.1 |        20 |   6.5285 ns | 0.0322 ns | 0.0269 ns |  1.00 |    0.00 |     - |     - |     - |         - |
|    StructEnumerable | .NET Core 3.1 |        20 |   8.6173 ns | 0.0532 ns | 0.0472 ns |  1.32 |    0.01 |     - |     - |     - |         - |
| RefStructEnumerable | .NET Core 3.1 |        20 |   9.2558 ns | 0.0910 ns | 0.0851 ns |  1.42 |    0.01 |     - |     - |     - |         - |
|   ArrayEnumerableV1 | .NET Core 3.1 |        20 |  12.2821 ns | 0.0601 ns | 0.0562 ns |  1.88 |    0.01 |     - |     - |     - |         - |
|                     |               |           |             |           |           |       |         |       |       |       |           |
|          **SysForEach** |      **.NET 4.8** |       **100** |  **48.1415 ns** | **0.1041 ns** | **0.0973 ns** |  **1.00** |    **0.00** |     **-** |     **-** |     **-** |         **-** |
|    StructEnumerable |      .NET 4.8 |       100 |  63.5524 ns | 0.1121 ns | 0.0994 ns |  1.32 |    0.00 |     - |     - |     - |         - |
| RefStructEnumerable |      .NET 4.8 |       100 |  63.4868 ns | 0.0991 ns | 0.0927 ns |  1.32 |    0.00 |     - |     - |     - |         - |
|   ArrayEnumerableV1 |      .NET 4.8 |       100 |  68.9299 ns | 0.1164 ns | 0.1089 ns |  1.43 |    0.00 |     - |     - |     - |         - |
|                     |               |           |             |           |           |       |         |       |       |       |           |
|          SysForEach | .NET Core 3.1 |       100 |  46.0724 ns | 0.0816 ns | 0.0763 ns |  1.00 |    0.00 |     - |     - |     - |         - |
|    StructEnumerable | .NET Core 3.1 |       100 |  50.3486 ns | 0.0590 ns | 0.0552 ns |  1.09 |    0.00 |     - |     - |     - |         - |
| RefStructEnumerable | .NET Core 3.1 |       100 |  49.7810 ns | 0.0591 ns | 0.0553 ns |  1.08 |    0.00 |     - |     - |     - |         - |
|   ArrayEnumerableV1 | .NET Core 3.1 |       100 |  70.3017 ns | 0.0804 ns | 0.0712 ns |  1.53 |    0.00 |     - |     - |     - |         - |
|                     |               |           |             |           |           |       |         |       |       |       |           |
|          **SysForEach** |      **.NET 4.8** |      **1000** | **419.3232 ns** | **0.6016 ns** | **0.5627 ns** |  **1.00** |    **0.00** |     **-** |     **-** |     **-** |         **-** |
|    StructEnumerable |      .NET 4.8 |      1000 | 570.6018 ns | 0.8941 ns | 0.7926 ns |  1.36 |    0.00 |     - |     - |     - |         - |
| RefStructEnumerable |      .NET 4.8 |      1000 | 570.3248 ns | 0.8759 ns | 0.8193 ns |  1.36 |    0.00 |     - |     - |     - |         - |
|   ArrayEnumerableV1 |      .NET 4.8 |      1000 | 625.6834 ns | 0.7310 ns | 0.6837 ns |  1.49 |    0.00 |     - |     - |     - |         - |
|                     |               |           |             |           |           |       |         |       |       |       |           |
|          SysForEach | .NET Core 3.1 |      1000 | 417.6499 ns | 0.4182 ns | 0.3708 ns |  1.00 |    0.00 |     - |     - |     - |         - |
|    StructEnumerable | .NET Core 3.1 |      1000 | 433.1075 ns | 0.7834 ns | 0.7328 ns |  1.04 |    0.00 |     - |     - |     - |         - |
| RefStructEnumerable | .NET Core 3.1 |      1000 | 431.8222 ns | 0.3714 ns | 0.3292 ns |  1.03 |    0.00 |     - |     - |     - |         - |
|   ArrayEnumerableV1 | .NET Core 3.1 |      1000 | 631.1543 ns | 0.7293 ns | 0.6822 ns |  1.51 |    0.00 |     - |     - |     - |         - |
