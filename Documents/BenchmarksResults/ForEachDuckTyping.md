## ForEachDuckTyping

### Source
[ForEachDuckTyping.cs](../../src/StructLinq.Benchmark/ForEachDuckTyping.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                                      Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Allocated | Alloc Ratio |
|-------------------------------------------- |----------:|----------:|----------:|------:|--------:|----------:|------------:|
|                                  ForOnArray |  4.115 μs | 0.0095 μs | 0.0085 μs |  1.00 |    0.00 |         - |          NA |
|                              ForEachOnArray |  3.022 μs | 0.0297 μs | 0.0278 μs |  0.73 |    0.01 |         - |          NA |
|                    ForEachOnYieldEnumerable | 45.379 μs | 0.1692 μs | 0.1413 μs | 11.03 |    0.03 |      56 B |          NA |
|                        ForEachOnIEnumerable | 41.546 μs | 0.1132 μs | 0.1003 μs | 10.10 |    0.04 |      32 B |          NA |
|              ForEachOnArrayStructEnumerable |  3.609 μs | 0.0409 μs | 0.0362 μs |  0.88 |    0.01 |         - |          NA |
| ForEachOnArrayStructEnumerableAsIEnumerable | 22.910 μs | 0.0430 μs | 0.0403 μs |  5.57 |    0.01 |      72 B |          NA |
