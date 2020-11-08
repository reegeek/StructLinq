## ArrayWhereSelectSum

### Source
[ArrayWhereSelectSum.cs](../../src/StructLinq.Benchmark/ArrayWhereSelectSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100-preview.7.20366.6
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  DefaultJob : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT


```
|                                Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
|                         HandmadedCode | 11.677 us | 0.0370 us | 0.0346 us |  1.00 |    0.00 |     - |     - |     - |         - |
|                               SysLinq | 48.733 us | 0.5036 us | 0.4464 us |  4.17 |    0.04 |     - |     - |     - |     104 B |
| StructRangeWhereSelectSumWithDelegate | 44.478 us | 0.3072 us | 0.2873 us |  3.81 |    0.03 |     - |     - |     - |      48 B |
|             StructRangeWhereSelectSum |  7.657 us | 0.0492 us | 0.0460 us |  0.66 |    0.00 |     - |     - |     - |         - |
