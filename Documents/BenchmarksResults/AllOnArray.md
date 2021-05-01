## AllOnArray

### Source
[AllOnArray.cs](../../src/StructLinq.Benchmark/AllOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
  DefaultJob : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT


```
|                                         Method |       Mean |    Error |   StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------------------------------- |-----------:|---------:|---------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
|                                            For |   188.3 ns |  3.76 ns |  4.33 ns |   187.0 ns |  0.07 |    0.00 |      - |     - |     - |         - |
|                                           Linq | 2,767.4 ns | 54.49 ns | 96.85 ns | 2,758.2 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      32 B |
|                                     StructLinq |   953.2 ns | 10.07 ns |  8.93 ns |   956.3 ns |  0.34 |    0.01 | 0.0057 |     - |     - |      32 B |
|                            StructLinqZeroAlloc |   822.0 ns | 15.38 ns | 31.76 ns |   808.2 ns |  0.30 |    0.02 |      - |     - |     - |         - |
|                   StructLinqIFunctionZeroAlloc |   278.4 ns |  4.46 ns |  4.17 ns |   278.3 ns |  0.10 |    0.00 |      - |     - |     - |         - |
| StructLinqIFunctionZeroAllocOnStructEnumerable |   277.3 ns |  5.48 ns |  7.32 ns |   276.9 ns |  0.10 |    0.00 |      - |     - |     - |         - |
