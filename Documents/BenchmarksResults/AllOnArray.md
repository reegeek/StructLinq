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
|                                            For |   265.3 ns |  2.03 ns |  1.80 ns |  0.10 |      - |     - |     - |         - |
|                                           Linq | 2,577.2 ns |  7.17 ns |  6.35 ns |  1.00 | 0.0038 |     - |     - |      32 B |
|                                     StructLinq | 1,076.8 ns | 19.39 ns | 17.19 ns |  0.42 | 0.0057 |     - |     - |      32 B |
|                            StructLinqZeroAlloc |   905.9 ns |  2.40 ns |  2.12 ns |  0.35 |      - |     - |     - |         - |
|                   StructLinqIFunctionZeroAlloc |   287.5 ns |  2.15 ns |  2.01 ns |  0.11 |      - |     - |     - |         - |
| StructLinqIFunctionZeroAllocOnStructEnumerable |   390.4 ns |  1.34 ns |  1.26 ns |  0.15 |      - |     - |     - |         - |
