## RangeWhereSelectSum

### Source
[RangeWhereSelectSum.cs](../../src/StructLinq.Benchmark/RangeWhereSelectSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|                            Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
|                            SysSum |  5.438 μs | 0.0271 μs | 0.0240 μs |  1.00 |    0.00 |     - |     - |     - |         - |
|            SysRangeWhereSelectSum | 82.446 μs | 0.3162 μs | 0.2803 μs | 15.16 |    0.06 |     - |     - |     - |     160 B |
| ConvertWhereSelectSumWithDelegate | 67.696 μs | 0.3058 μs | 0.2861 μs | 12.45 |    0.06 |     - |     - |     - |      80 B |
|         StructRangeWhereSelectSum | 14.971 μs | 0.0600 μs | 0.0561 μs |  2.75 |    0.02 |     - |     - |     - |         - |
