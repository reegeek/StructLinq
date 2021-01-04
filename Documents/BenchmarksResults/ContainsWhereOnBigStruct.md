## ContainsWhereOnBigStruct

### Source
[ContainsWhereOnBigStruct.cs](../../src/StructLinq.Benchmark/ContainsWhereOnBigStruct.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                                   Method |     Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------------------------- |---------:|---------:|---------:|------:|------:|------:|------:|----------:|
|                                     Linq | 49.68 μs | 0.315 μs | 0.294 μs |  1.00 |     - |     - |     - |      80 B |
|                                    Array | 52.62 μs | 0.214 μs | 0.190 μs |  1.06 |     - |     - |     - |      80 B |
|                               StructLinq | 52.99 μs | 0.331 μs | 0.310 μs |  1.07 |     - |     - |     - |         - |
|                            RefStructLinq | 30.43 μs | 0.039 μs | 0.030 μs |  0.61 |     - |     - |     - |         - |
|             StructLinqWithCustomComparer | 22.06 μs | 0.198 μs | 0.165 μs |  0.44 |     - |     - |     - |         - |
| RefStructLinqZeroAllocwithCustomComparer | 18.84 μs | 0.052 μs | 0.046 μs |  0.38 |     - |     - |     - |         - |
