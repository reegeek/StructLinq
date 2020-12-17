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
|                         HandmadedCode |  6.940 μs | 0.0296 μs | 0.0262 μs |  1.00 |    0.00 |     - |     - |     - |         - |
|                               SysLinq | 47.216 μs | 0.1839 μs | 0.1630 μs |  6.80 |    0.03 |     - |     - |     - |     104 B |
| StructRangeWhereSelectSumWithDelegate | 33.590 μs | 0.1206 μs | 0.1128 μs |  4.84 |    0.03 |     - |     - |     - |         - |
|             StructRangeWhereSelectSum | 13.593 μs | 0.0352 μs | 0.0329 μs |  1.96 |    0.01 |     - |     - |     - |         - |
