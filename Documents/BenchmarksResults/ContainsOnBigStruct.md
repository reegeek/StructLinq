## ContainsOnBigStruct

### Source
[ContainsOnBigStruct.cs](../../src/StructLinq.Benchmark/ContainsOnBigStruct.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|                                   Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Allocated |
|----------------------------------------- |----------:|----------:|----------:|------:|--------:|----------:|
|                                     Linq |  5.258 μs | 0.0165 μs | 0.0146 μs |  1.00 |    0.00 |         - |
|                                    Array |  4.692 μs | 0.0224 μs | 0.0199 μs |  0.89 |    0.00 |         - |
|                               StructLinq | 19.716 μs | 0.1674 μs | 0.1566 μs |  3.75 |    0.03 |         - |
|                            RefStructLinq | 16.784 μs | 0.0169 μs | 0.0132 μs |  3.19 |    0.01 |         - |
|             StructLinqWithCustomComparer | 12.565 μs | 0.1083 μs | 0.1013 μs |  2.39 |    0.02 |         - |
| RefStructLinqZeroAllocwithCustomComparer |  3.865 μs | 0.0092 μs | 0.0077 μs |  0.74 |    0.00 |         - |
