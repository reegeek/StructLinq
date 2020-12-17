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
|                            SysSum |  6.937 μs | 0.0217 μs | 0.0170 μs |  1.00 |    0.00 |     - |     - |     - |         - |
|            SysRangeWhereSelectSum | 84.396 μs | 0.6779 μs | 0.6010 μs | 12.18 |    0.11 |     - |     - |     - |     160 B |
| ConvertWhereSelectSumWithDelegate | 72.316 μs | 0.3989 μs | 0.3732 μs | 10.43 |    0.06 |     - |     - |     - |      40 B |
|         StructRangeWhereSelectSum | 15.050 μs | 0.0400 μs | 0.0374 μs |  2.17 |    0.01 |     - |     - |     - |         - |
