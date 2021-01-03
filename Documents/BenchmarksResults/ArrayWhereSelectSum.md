## ArrayWhereSelectSum

### Source
[ArrayWhereSelectSum.cs](../../src/StructLinq.Benchmark/ArrayWhereSelectSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                                Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
|                         HandmadedCode | 11.260 μs | 0.0438 μs | 0.0410 μs |  1.00 |    0.00 |     - |     - |     - |         - |
|                               SysLinq | 47.419 μs | 0.2339 μs | 0.2188 μs |  4.21 |    0.03 |     - |     - |     - |     104 B |
| StructRangeWhereSelectSumWithDelegate | 30.242 μs | 0.4029 μs | 0.3769 μs |  2.69 |    0.04 |     - |     - |     - |         - |
|             StructRangeWhereSelectSum |  6.918 μs | 0.0304 μs | 0.0284 μs |  0.61 |    0.00 |     - |     - |     - |         - |
