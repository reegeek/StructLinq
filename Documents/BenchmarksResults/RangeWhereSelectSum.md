## RangeWhereSelectSum

### Source
[RangeWhereSelectSum.cs](../../src/StructLinq.Benchmark/RangeWhereSelectSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                            Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Allocated | Alloc Ratio |
|---------------------------------- |----------:|----------:|----------:|------:|--------:|----------:|------------:|
|                            SysSum |  6.942 μs | 0.0163 μs | 0.0127 μs |  1.00 |    0.00 |         - |          NA |
|            SysRangeWhereSelectSum | 79.612 μs | 0.5985 μs | 0.5598 μs | 11.49 |    0.08 |     160 B |          NA |
| ConvertWhereSelectSumWithDelegate | 61.600 μs | 0.3007 μs | 0.2666 μs |  8.87 |    0.05 |      40 B |          NA |
|         StructRangeWhereSelectSum |  5.594 μs | 0.0075 μs | 0.0066 μs |  0.81 |    0.00 |         - |          NA |
