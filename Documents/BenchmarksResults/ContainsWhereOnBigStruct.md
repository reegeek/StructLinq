## ContainsWhereOnBigStruct

### Source
[ContainsWhereOnBigStruct.cs](../../src/StructLinq.Benchmark/ContainsWhereOnBigStruct.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                                   Method |     Mean |    Error |   StdDev | Ratio | Allocated | Alloc Ratio |
|----------------------------------------- |---------:|---------:|---------:|------:|----------:|------------:|
|                                     Linq | 36.38 μs | 0.190 μs | 0.148 μs |  1.00 |      80 B |        1.00 |
|                                    Array | 35.75 μs | 0.081 μs | 0.076 μs |  0.98 |      80 B |        1.00 |
|                               StructLinq | 53.47 μs | 0.216 μs | 0.202 μs |  1.47 |         - |        0.00 |
|                            RefStructLinq | 27.90 μs | 0.261 μs | 0.244 μs |  0.77 |         - |        0.00 |
|             StructLinqWithCustomComparer | 16.82 μs | 0.089 μs | 0.074 μs |  0.46 |         - |        0.00 |
| RefStructLinqZeroAllocwithCustomComparer | 15.18 μs | 0.057 μs | 0.051 μs |  0.42 |         - |        0.00 |
