## ArrayWhereSelectSum

### Source
[ArrayWhereSelectSum.cs](../../src/StructLinq.Benchmark/ArrayWhereSelectSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|                                Method |     Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------------- |---------:|---------:|---------:|------:|------:|------:|------:|----------:|
|                         HandmadedCode | 12.61 us | 0.017 us | 0.016 us |  1.00 |     - |     - |     - |         - |
|                               SysLinq | 45.15 us | 0.092 us | 0.086 us |  3.58 |     - |     - |     - |     104 B |
| StructRangeWhereSelectSumWithDelegate | 43.71 us | 0.148 us | 0.124 us |  3.47 |     - |     - |     - |      48 B |
|             StructRangeWhereSelectSum | 15.21 us | 0.033 us | 0.031 us |  1.21 |     - |     - |     - |         - |
