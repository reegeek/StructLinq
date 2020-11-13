## ArrayWhereSelectSum

### Source
[ArrayWhereSelectSum.cs](../../src/StructLinq.Benchmark/ArrayWhereSelectSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|                                Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
|                         HandmadedCode |  6.922 μs | 0.0292 μs | 0.0273 μs |  1.00 |    0.00 |     - |     - |     - |         - |
|                               SysLinq | 46.802 μs | 0.2560 μs | 0.2394 μs |  6.76 |    0.04 |     - |     - |     - |     104 B |
| StructRangeWhereSelectSumWithDelegate | 34.003 μs | 0.1542 μs | 0.1367 μs |  4.91 |    0.03 |     - |     - |     - |      48 B |
|             StructRangeWhereSelectSum | 13.526 μs | 0.0602 μs | 0.0534 μs |  1.95 |    0.01 |     - |     - |     - |         - |
