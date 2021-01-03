## AllOnArray

### Source
[AllOnArray.cs](../../src/StructLinq.Benchmark/AllOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                                         Method |       Mean |    Error |   StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------------------------------- |-----------:|---------:|---------:|------:|-------:|------:|------:|----------:|
|                                            For |   175.7 ns |  0.37 ns |  0.32 ns |  0.07 |      - |     - |     - |         - |
|                                           Linq | 2,643.6 ns |  8.87 ns |  7.41 ns |  1.00 | 0.0038 |     - |     - |      32 B |
|                                     StructLinq | 1,144.9 ns |  5.55 ns |  5.19 ns |  0.43 | 0.0057 |     - |     - |      32 B |
|                            StructLinqZeroAlloc |   901.1 ns | 16.58 ns | 13.84 ns |  0.34 |      - |     - |     - |         - |
|                   StructLinqIFunctionZeroAlloc |   516.2 ns |  3.18 ns |  2.82 ns |  0.20 |      - |     - |     - |         - |
| StructLinqIFunctionZeroAllocOnStructEnumerable |   385.8 ns |  2.30 ns |  2.04 ns |  0.15 |      - |     - |     - |         - |
