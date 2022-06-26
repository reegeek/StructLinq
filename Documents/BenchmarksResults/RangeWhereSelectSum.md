## RangeWhereSelectSum

### Source
[RangeWhereSelectSum.cs](../../src/StructLinq.Benchmark/RangeWhereSelectSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|                            Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Allocated |
|---------------------------------- |----------:|----------:|----------:|------:|--------:|----------:|
|                            SysSum |  7.137 μs | 0.0439 μs | 0.0410 μs |  1.00 |    0.00 |         - |
|            SysRangeWhereSelectSum | 80.673 μs | 0.4691 μs | 0.4159 μs | 11.30 |    0.08 |     160 B |
| ConvertWhereSelectSumWithDelegate | 63.532 μs | 0.5326 μs | 0.4982 μs |  8.90 |    0.10 |      40 B |
|         StructRangeWhereSelectSum |  5.767 μs | 0.0306 μs | 0.0286 μs |  0.81 |    0.01 |         - |
