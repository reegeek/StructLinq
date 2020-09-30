## RangeWhereSelectSum

### Source
[RangeWhereSelectSum.cs](../../src/StructLinq.Benchmark/RangeWhereSelectSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|                            Method |       Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |-----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
|                            SysSum |   8.140 us | 0.0072 us | 0.0063 us |  1.00 |    0.00 |     - |     - |     - |         - |
|            SysRangeWhereSelectSum | 102.472 us | 0.1501 us | 0.1404 us | 12.59 |    0.02 |     - |     - |     - |     160 B |
| ConvertWhereSelectSumWithDelegate |  95.443 us | 0.1460 us | 0.1294 us | 11.72 |    0.02 |     - |     - |     - |      80 B |
|         StructRangeWhereSelectSum |  16.697 us | 0.0150 us | 0.0133 us |  2.05 |    0.00 |     - |     - |     - |         - |
