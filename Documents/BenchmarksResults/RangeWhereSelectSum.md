## RangeWhereSelectSum

### Source
[RangeWhereSelectSum.cs](../../src/StructLinq.Benchmark/RangeWhereSelectSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100-preview.7.20366.6
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  DefaultJob : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT


```
|                            Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
|                            SysSum |  7.164 us | 0.0155 us | 0.0145 us |  1.00 |    0.00 |     - |     - |     - |         - |
|            SysRangeWhereSelectSum | 91.269 us | 0.8590 us | 0.8035 us | 12.74 |    0.10 |     - |     - |     - |     160 B |
| ConvertWhereSelectSumWithDelegate | 81.073 us | 0.7158 us | 0.6696 us | 11.32 |    0.11 |     - |     - |     - |      81 B |
|         StructRangeWhereSelectSum | 15.399 us | 0.0805 us | 0.0753 us |  2.15 |    0.01 |     - |     - |     - |         - |
|                         WithVisit |  7.209 us | 0.0383 us | 0.0358 us |  1.01 |    0.01 |     - |     - |     - |         - |
|                        WithVisit2 | 41.304 us | 0.2032 us | 0.1901 us |  5.77 |    0.03 |     - |     - |     - |         - |
