## RangeWhereSelectSum

### Source
[RangeWhereSelectSum.cs](../../src/StructLinq.Benchmark/RangeWhereSelectSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                            Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
|                            SysSum |  6.855 μs | 0.0230 μs | 0.0215 μs |  1.00 |    0.00 |     - |     - |     - |         - |
|            SysRangeWhereSelectSum | 87.849 μs | 0.5660 μs | 0.5294 μs | 12.82 |    0.07 |     - |     - |     - |     160 B |
| ConvertWhereSelectSumWithDelegate | 61.777 μs | 0.4519 μs | 0.4227 μs |  9.01 |    0.06 |     - |     - |     - |      40 B |
|         StructRangeWhereSelectSum |  5.538 μs | 0.0150 μs | 0.0133 μs |  0.81 |    0.00 |     - |     - |     - |         - |
