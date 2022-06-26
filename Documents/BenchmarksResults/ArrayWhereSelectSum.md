## ArrayWhereSelectSum

### Source
[ArrayWhereSelectSum.cs](../../src/StructLinq.Benchmark/ArrayWhereSelectSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|                                Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Allocated |
|-------------------------------------- |----------:|----------:|----------:|------:|--------:|----------:|
|                         HandmadedCode |  7.026 μs | 0.0145 μs | 0.0135 μs |  1.00 |    0.00 |         - |
|                               SysLinq | 48.862 μs | 0.2721 μs | 0.2545 μs |  6.95 |    0.04 |     104 B |
| StructRangeWhereSelectSumWithDelegate | 29.650 μs | 0.0730 μs | 0.0570 μs |  4.22 |    0.01 |         - |
|             StructRangeWhereSelectSum | 11.515 μs | 0.0347 μs | 0.0325 μs |  1.64 |    0.01 |         - |
