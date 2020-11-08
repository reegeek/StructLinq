## RangeWhereSelectSum

### Source
[RangeWhereSelectSum.cs](../../src/StructLinq.Benchmark/RangeWhereSelectSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100-preview.7.20366.6
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  DefaultJob : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT


```
|                            Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
|                            SysSum |  7.116 us | 0.0270 us | 0.0225 us |  1.00 |    0.00 |     - |     - |     - |         - |
|            SysRangeWhereSelectSum | 92.341 us | 0.8213 us | 0.7682 us | 12.96 |    0.12 |     - |     - |     - |     160 B |
| ConvertWhereSelectSumWithDelegate | 69.940 us | 0.7227 us | 0.6760 us |  9.83 |    0.10 |     - |     - |     - |      80 B |
|         StructRangeWhereSelectSum |  7.083 us | 0.0420 us | 0.0393 us |  1.00 |    0.01 |     - |     - |     - |         - |
