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
|                                     Linq | 52.22 μs | 0.204 μs | 0.181 μs |  1.00 |     - |     - |     - |      80 B |
|                                    Array | 49.59 μs | 0.290 μs | 0.271 μs |  0.95 |     - |     - |     - |      80 B |
|                               StructLinq | 39.00 μs | 0.216 μs | 0.191 μs |  0.75 |     - |     - |     - |         - |
|                            RefStructLinq | 28.34 μs | 0.126 μs | 0.118 μs |  0.54 |     - |     - |     - |         - |
|             StructLinqWithCustomComparer | 31.46 μs | 0.120 μs | 0.107 μs |  0.60 |     - |     - |     - |         - |
| RefStructLinqZeroAllocwithCustomComparer | 15.58 μs | 0.137 μs | 0.128 μs |  0.30 |     - |     - |     - |         - |
