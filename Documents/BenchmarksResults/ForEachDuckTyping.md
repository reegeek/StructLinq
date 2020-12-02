## ForEachDuckTyping

### Source
[ForEachDuckTyping.cs](../../src/StructLinq.Benchmark/ForEachDuckTyping.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|                                      Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
|                                  ForOnArray |  5.922 us | 0.0048 us | 0.0042 us |  1.00 |    0.00 |     - |     - |     - |         - |
|                              ForEachOnArray |  4.146 us | 0.0067 us | 0.0060 us |  0.70 |    0.00 |     - |     - |     - |         - |
|                    ForEachOnYieldEnumerable | 50.883 us | 0.4692 us | 0.4159 us |  8.59 |    0.07 |     - |     - |     - |      56 B |
|                        ForEachOnIEnumerable | 39.397 us | 0.0656 us | 0.0582 us |  6.65 |    0.01 |     - |     - |     - |      32 B |
|              ForEachOnArrayStructEnumerable |  5.641 us | 0.0115 us | 0.0102 us |  0.95 |    0.00 |     - |     - |     - |         - |
| ForEachOnArrayStructEnumerableAsIEnumerable | 59.610 us | 0.0723 us | 0.0676 us | 10.07 |    0.02 |     - |     - |     - |      64 B |
