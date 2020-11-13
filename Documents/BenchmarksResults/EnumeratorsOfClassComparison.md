## EnumeratorsOfClassComparison

### Source
[EnumeratorsOfClassComparison.cs](../../src/StructLinq.Benchmark/EnumeratorsOfClassComparison.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]        : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4250.0), X64 RyuJIT
  .NET Core 5.0 : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|              Method |           Job |       Runtime | ItemCount |          Mean |      Error |     StdDev | Ratio | RatioSD | Code Size | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |-------------- |-------------- |---------- |--------------:|-----------:|-----------:|------:|--------:|----------:|------:|------:|------:|----------:|
|          **SysForEach** |      **.NET 4.8** |      **.NET 4.8** |         **2** |     **0.8891 ns** |  **0.0126 ns** |  **0.0117 ns** |  **1.00** |    **0.00** |      **37 B** |     **-** |     **-** |     **-** |         **-** |
|    StructEnumerable |      .NET 4.8 |      .NET 4.8 |         2 |     1.7005 ns |  0.0324 ns |  0.0303 ns |  1.91 |    0.05 |      73 B |     - |     - |     - |         - |
| RefStructEnumerable |      .NET 4.8 |      .NET 4.8 |         2 |     5.0029 ns |  0.0245 ns |  0.0205 ns |  5.64 |    0.06 |      87 B |     - |     - |     - |         - |
|   ArrayEnumerableV1 |      .NET 4.8 |      .NET 4.8 |         2 |     1.9446 ns |  0.0270 ns |  0.0253 ns |  2.19 |    0.04 |      63 B |     - |     - |     - |         - |
|                     |               |               |           |               |            |            |       |         |           |       |       |       |           |
|          SysForEach | .NET Core 5.0 | .NET Core 5.0 |         2 |     0.7345 ns |  0.0182 ns |  0.0170 ns |  1.00 |    0.00 |      37 B |     - |     - |     - |         - |
|    StructEnumerable | .NET Core 5.0 | .NET Core 5.0 |         2 |     1.8493 ns |  0.0338 ns |  0.0316 ns |  2.52 |    0.07 |      73 B |     - |     - |     - |         - |
| RefStructEnumerable | .NET Core 5.0 | .NET Core 5.0 |         2 |     4.2221 ns |  0.0380 ns |  0.0355 ns |  5.75 |    0.16 |      77 B |     - |     - |     - |         - |
|   ArrayEnumerableV1 | .NET Core 5.0 | .NET Core 5.0 |         2 |     1.9934 ns |  0.0109 ns |  0.0091 ns |  2.71 |    0.07 |      63 B |     - |     - |     - |         - |
|                     |               |               |           |               |            |            |       |         |           |       |       |       |           |
|          **SysForEach** |      **.NET 4.8** |      **.NET 4.8** |        **20** |     **8.2904 ns** |  **0.0759 ns** |  **0.0672 ns** |  **1.00** |    **0.00** |      **37 B** |     **-** |     **-** |     **-** |         **-** |
|    StructEnumerable |      .NET 4.8 |      .NET 4.8 |        20 |     8.9049 ns |  0.0690 ns |  0.0612 ns |  1.07 |    0.01 |      73 B |     - |     - |     - |         - |
| RefStructEnumerable |      .NET 4.8 |      .NET 4.8 |        20 |    43.1781 ns |  0.4346 ns |  0.4066 ns |  5.21 |    0.07 |      87 B |     - |     - |     - |         - |
|   ArrayEnumerableV1 |      .NET 4.8 |      .NET 4.8 |        20 |    11.3624 ns |  0.0931 ns |  0.0871 ns |  1.37 |    0.01 |      63 B |     - |     - |     - |         - |
|                     |               |               |           |               |            |            |       |         |           |       |       |       |           |
|          SysForEach | .NET Core 5.0 | .NET Core 5.0 |        20 |     7.6385 ns |  0.0945 ns |  0.0884 ns |  1.00 |    0.00 |      37 B |     - |     - |     - |         - |
|    StructEnumerable | .NET Core 5.0 | .NET Core 5.0 |        20 |    10.5177 ns |  0.0583 ns |  0.0517 ns |  1.38 |    0.02 |      73 B |     - |     - |     - |         - |
| RefStructEnumerable | .NET Core 5.0 | .NET Core 5.0 |        20 |    29.1397 ns |  0.2558 ns |  0.2268 ns |  3.81 |    0.05 |      77 B |     - |     - |     - |         - |
|   ArrayEnumerableV1 | .NET Core 5.0 | .NET Core 5.0 |        20 |    10.7863 ns |  0.1074 ns |  0.0952 ns |  1.41 |    0.02 |      63 B |     - |     - |     - |         - |
|                     |               |               |           |               |            |            |       |         |           |       |       |       |           |
|          **SysForEach** |      **.NET 4.8** |      **.NET 4.8** |       **100** |    **44.4191 ns** |  **0.4729 ns** |  **0.4424 ns** |  **1.00** |    **0.00** |      **37 B** |     **-** |     **-** |     **-** |         **-** |
|    StructEnumerable |      .NET 4.8 |      .NET 4.8 |       100 |    46.1254 ns |  0.1831 ns |  0.1713 ns |  1.04 |    0.01 |      73 B |     - |     - |     - |         - |
| RefStructEnumerable |      .NET 4.8 |      .NET 4.8 |       100 |   214.2349 ns |  1.1711 ns |  1.0381 ns |  4.83 |    0.07 |      87 B |     - |     - |     - |         - |
|   ArrayEnumerableV1 |      .NET 4.8 |      .NET 4.8 |       100 |    65.3192 ns |  0.3765 ns |  0.3522 ns |  1.47 |    0.01 |      63 B |     - |     - |     - |         - |
|                     |               |               |           |               |            |            |       |         |           |       |       |       |           |
|          SysForEach | .NET Core 5.0 | .NET Core 5.0 |       100 |    58.4147 ns |  0.4693 ns |  0.4160 ns |  1.00 |    0.00 |      37 B |     - |     - |     - |         - |
|    StructEnumerable | .NET Core 5.0 | .NET Core 5.0 |       100 |    58.9210 ns |  0.3907 ns |  0.3654 ns |  1.01 |    0.01 |      73 B |     - |     - |     - |         - |
| RefStructEnumerable | .NET Core 5.0 | .NET Core 5.0 |       100 |   140.0976 ns |  0.8180 ns |  0.7252 ns |  2.40 |    0.02 |      77 B |     - |     - |     - |         - |
|   ArrayEnumerableV1 | .NET Core 5.0 | .NET Core 5.0 |       100 |    65.7077 ns |  0.5277 ns |  0.4936 ns |  1.13 |    0.01 |      63 B |     - |     - |     - |         - |
|                     |               |               |           |               |            |            |       |         |           |       |       |       |           |
|          **SysForEach** |      **.NET 4.8** |      **.NET 4.8** |      **1000** |   **422.0889 ns** |  **6.0149 ns** |  **5.6263 ns** |  **1.00** |    **0.00** |      **37 B** |     **-** |     **-** |     **-** |         **-** |
|    StructEnumerable |      .NET 4.8 |      .NET 4.8 |      1000 |   435.4433 ns |  7.3475 ns |  6.8728 ns |  1.03 |    0.02 |      73 B |     - |     - |     - |         - |
| RefStructEnumerable |      .NET 4.8 |      .NET 4.8 |      1000 | 2,211.0461 ns | 38.4301 ns | 32.0909 ns |  5.25 |    0.12 |      87 B |     - |     - |     - |         - |
|   ArrayEnumerableV1 |      .NET 4.8 |      .NET 4.8 |      1000 |   612.4093 ns |  2.3588 ns |  2.2065 ns |  1.45 |    0.02 |      63 B |     - |     - |     - |         - |
|                     |               |               |           |               |            |            |       |         |           |       |       |       |           |
|          SysForEach | .NET Core 5.0 | .NET Core 5.0 |      1000 |   541.3223 ns |  3.2808 ns |  3.0688 ns |  1.00 |    0.00 |      37 B |     - |     - |     - |         - |
|    StructEnumerable | .NET Core 5.0 | .NET Core 5.0 |      1000 |   542.2775 ns |  4.1721 ns |  3.9026 ns |  1.00 |    0.01 |      73 B |     - |     - |     - |         - |
| RefStructEnumerable | .NET Core 5.0 | .NET Core 5.0 |      1000 | 1,373.2894 ns | 20.0412 ns | 18.7465 ns |  2.54 |    0.05 |      77 B |     - |     - |     - |         - |
|   ArrayEnumerableV1 | .NET Core 5.0 | .NET Core 5.0 |      1000 |   603.9942 ns | 10.7628 ns | 16.1093 ns |  1.13 |    0.03 |      63 B |     - |     - |     - |         - |
