## ArrayWhereSelectSum

### Source
[ArrayWhereSelectSum.cs](../../src/StructLinq.Benchmark/ArrayWhereSelectSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100-preview.7.20366.6
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  DefaultJob : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT


```
|                                Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
|                         HandmadedCode |  7.212 us | 0.0292 us | 0.0273 us |  1.00 |    0.00 |     - |     - |     - |         - |
|                               SysLinq | 47.778 us | 0.7669 us | 0.6798 us |  6.63 |    0.11 |     - |     - |     - |     104 B |
| StructRangeWhereSelectSumWithDelegate | 42.487 us | 0.5549 us | 0.5191 us |  5.89 |    0.08 |     - |     - |     - |      48 B |
|             StructRangeWhereSelectSum | 14.323 us | 0.1230 us | 0.1090 us |  1.99 |    0.02 |     - |     - |     - |         - |
|                           WithVisitor | 11.721 us | 0.0354 us | 0.0331 us |  1.63 |    0.01 |     - |     - |     - |         - |
