## ContainsWhereOnBigStruct

### Source
[ContainsWhereOnBigStruct.cs](../../src/StructLinq.Benchmark/ContainsWhereOnBigStruct.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19043
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.301
  [Host]     : .NET Core 5.0.7 (CoreCLR 5.0.721.25508, CoreFX 5.0.721.25508), X64 RyuJIT
  DefaultJob : .NET Core 5.0.7 (CoreCLR 5.0.721.25508, CoreFX 5.0.721.25508), X64 RyuJIT


```
|                                   Method |     Mean |    Error |   StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------------------------- |---------:|---------:|---------:|------:|--------:|------:|------:|------:|----------:|
|                                     Linq | 53.77 μs | 0.441 μs | 0.412 μs |  1.00 |    0.00 |     - |     - |     - |      80 B |
|                                    Array | 53.76 μs | 0.703 μs | 0.658 μs |  1.00 |    0.02 |     - |     - |     - |      80 B |
|                               StructLinq | 65.74 μs | 0.509 μs | 0.476 μs |  1.22 |    0.01 |     - |     - |     - |         - |
|                            RefStructLinq | 31.68 μs | 0.424 μs | 0.397 μs |  0.59 |    0.01 |     - |     - |     - |         - |
|             StructLinqWithCustomComparer | 25.44 μs | 0.177 μs | 0.166 μs |  0.47 |    0.00 |     - |     - |     - |         - |
| RefStructLinqZeroAllocwithCustomComparer | 19.39 μs | 0.171 μs | 0.159 μs |  0.36 |    0.00 |     - |     - |     - |         - |
