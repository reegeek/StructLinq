## ArrayWhereSelectSum

### Source
[ArrayWhereSelectSum.cs](../../src/StructLinq.Benchmark/ArrayWhereSelectSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                                Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Allocated | Alloc Ratio |
|-------------------------------------- |----------:|----------:|----------:|------:|--------:|----------:|------------:|
|                         HandmadedCode |  6.918 μs | 0.0265 μs | 0.0235 μs |  1.00 |    0.00 |         - |          NA |
|                               SysLinq | 50.241 μs | 0.8903 μs | 0.8328 μs |  7.25 |    0.11 |     104 B |          NA |
| StructRangeWhereSelectSumWithDelegate | 33.576 μs | 0.1525 μs | 0.1426 μs |  4.86 |    0.03 |         - |          NA |
|             StructRangeWhereSelectSum |  6.996 μs | 0.0287 μs | 0.0240 μs |  1.01 |    0.00 |         - |          NA |
