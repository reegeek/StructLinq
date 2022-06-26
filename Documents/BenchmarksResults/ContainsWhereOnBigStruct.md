## ContainsWhereOnBigStruct

### Source
[ContainsWhereOnBigStruct.cs](../../src/StructLinq.Benchmark/ContainsWhereOnBigStruct.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|                                   Method |     Mean |    Error |   StdDev | Ratio | RatioSD | Allocated |
|----------------------------------------- |---------:|---------:|---------:|------:|--------:|----------:|
|                                     Linq | 47.28 μs | 0.150 μs | 0.125 μs |  1.00 |    0.00 |      80 B |
|                                    Array | 47.72 μs | 0.760 μs | 0.674 μs |  1.01 |    0.02 |      80 B |
|                               StructLinq | 57.76 μs | 0.303 μs | 0.269 μs |  1.22 |    0.00 |         - |
|                            RefStructLinq | 27.01 μs | 0.052 μs | 0.046 μs |  0.57 |    0.00 |         - |
|             StructLinqWithCustomComparer | 20.67 μs | 0.158 μs | 0.140 μs |  0.44 |    0.00 |         - |
| RefStructLinqZeroAllocwithCustomComparer | 13.05 μs | 0.097 μs | 0.091 μs |  0.28 |    0.00 |         - |
