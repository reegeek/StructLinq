## ContainsOnBigStruct

### Source
[ContainsOnBigStruct.cs](../../src/StructLinq.Benchmark/ContainsOnBigStruct.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                                   Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------------------------------- |----------:|----------:|----------:|------:|--------:|----------:|------------:|
|                                     Linq |  5.218 μs | 0.0134 μs | 0.0125 μs |  1.00 |    0.00 |         - |          NA |
|                                    Array |  3.928 μs | 0.0122 μs | 0.0108 μs |  0.75 |    0.00 |         - |          NA |
|                               StructLinq | 20.267 μs | 0.0624 μs | 0.0583 μs |  3.88 |    0.02 |         - |          NA |
|                            RefStructLinq | 15.268 μs | 0.0831 μs | 0.0777 μs |  2.93 |    0.01 |         - |          NA |
|             StructLinqWithCustomComparer | 10.703 μs | 0.0795 μs | 0.0705 μs |  2.05 |    0.02 |         - |          NA |
| RefStructLinqZeroAllocwithCustomComparer |  2.550 μs | 0.0121 μs | 0.0113 μs |  0.49 |    0.00 |         - |          NA |
