## ForEachDuckTyping

### Source
[ForEachDuckTyping.cs](../../src/StructLinq.Benchmark/ForEachDuckTyping.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                                      Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Code Size | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------------------- |----------:|----------:|----------:|------:|--------:|----------:|------:|------:|------:|----------:|
|                                  ForOnArray |  5.297 μs | 0.0153 μs | 0.0143 μs |  1.00 |    0.00 |      53 B |     - |     - |     - |         - |
|                              ForEachOnArray |  5.000 μs | 0.0208 μs | 0.0195 μs |  0.94 |    0.00 |      36 B |     - |     - |     - |         - |
|                    ForEachOnYieldEnumerable | 45.206 μs | 0.1608 μs | 0.1255 μs |  8.54 |    0.02 |     330 B |     - |     - |     - |      56 B |
|                        ForEachOnIEnumerable | 37.558 μs | 0.1665 μs | 0.1476 μs |  7.09 |    0.04 |     194 B |     - |     - |     - |      32 B |
|              ForEachOnArrayStructEnumerable |  5.021 μs | 0.0223 μs | 0.0209 μs |  0.95 |    0.00 |      72 B |     - |     - |     - |         - |
| ForEachOnArrayStructEnumerableAsIEnumerable | 52.619 μs | 0.2447 μs | 0.2169 μs |  9.93 |    0.06 |     340 B |     - |     - |     - |      72 B |
