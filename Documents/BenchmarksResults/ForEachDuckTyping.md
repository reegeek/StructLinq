## ForEachDuckTyping

### Source
[ForEachDuckTyping.cs](../../src/StructLinq.Benchmark/ForEachDuckTyping.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|                                      Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Allocated |
|-------------------------------------------- |----------:|----------:|----------:|------:|--------:|----------:|
|                                  ForOnArray |  5.382 μs | 0.0154 μs | 0.0136 μs |  1.00 |    0.00 |         - |
|                              ForEachOnArray |  3.769 μs | 0.0210 μs | 0.0186 μs |  0.70 |    0.00 |         - |
|                    ForEachOnYieldEnumerable | 46.374 μs | 0.2828 μs | 0.2507 μs |  8.62 |    0.05 |      56 B |
|                        ForEachOnIEnumerable | 38.284 μs | 0.0625 μs | 0.0554 μs |  7.11 |    0.02 |      32 B |
|              ForEachOnArrayStructEnumerable |  3.857 μs | 0.0194 μs | 0.0162 μs |  0.72 |    0.00 |         - |
| ForEachOnArrayStructEnumerableAsIEnumerable | 47.409 μs | 0.1686 μs | 0.1577 μs |  8.81 |    0.04 |      72 B |
