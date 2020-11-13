## ContainsWhereOnBigStruct

### Source
[ContainsWhereOnBigStruct.cs](../../src/StructLinq.Benchmark/ContainsWhereOnBigStruct.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|                                   Method |     Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------------------------- |---------:|---------:|---------:|------:|------:|------:|------:|----------:|
|                                     Linq | 49.50 μs | 0.116 μs | 0.097 μs |  1.00 |     - |     - |     - |      80 B |
|                                    Array | 49.58 μs | 0.211 μs | 0.198 μs |  1.00 |     - |     - |     - |      80 B |
|                               StructLinq | 44.66 μs | 0.097 μs | 0.081 μs |  0.90 |     - |     - |     - |         - |
|                            RefStructLinq | 31.08 μs | 0.159 μs | 0.149 μs |  0.63 |     - |     - |     - |         - |
|             StructLinqWithCustomComparer | 34.49 μs | 0.324 μs | 0.287 μs |  0.70 |     - |     - |     - |         - |
| RefStructLinqZeroAllocwithCustomComparer | 19.08 μs | 0.157 μs | 0.147 μs |  0.39 |     - |     - |     - |         - |
