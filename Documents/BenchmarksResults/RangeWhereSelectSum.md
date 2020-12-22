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
|                            SysSum |  7.019 μs | 0.0157 μs | 0.0147 μs |  1.00 |    0.00 |     - |     - |     - |         - |
|            SysRangeWhereSelectSum | 83.535 μs | 0.5238 μs | 0.4900 μs | 11.90 |    0.08 |     - |     - |     - |     160 B |
| ConvertWhereSelectSumWithDelegate | 64.815 μs | 0.2524 μs | 0.2238 μs |  9.23 |    0.03 |     - |     - |     - |      40 B |
|         StructRangeWhereSelectSum |  7.437 μs | 0.0332 μs | 0.0310 μs |  1.06 |    0.00 |     - |     - |     - |         - |
