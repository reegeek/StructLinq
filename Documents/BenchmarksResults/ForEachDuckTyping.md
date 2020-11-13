## ForEachDuckTyping

### Source
[ForEachDuckTyping.cs](../../src/StructLinq.Benchmark/ForEachDuckTyping.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|                                      Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Code Size | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------------------- |----------:|----------:|----------:|------:|--------:|----------:|------:|------:|------:|----------:|
|                                  ForOnArray |  5.311 μs | 0.0188 μs | 0.0176 μs |  1.00 |    0.00 |      53 B |     - |     - |     - |         - |
|                              ForEachOnArray |  5.030 μs | 0.0206 μs | 0.0182 μs |  0.95 |    0.00 |      36 B |     - |     - |     - |         - |
|                    ForEachOnYieldEnumerable | 45.170 μs | 0.2204 μs | 0.1953 μs |  8.50 |    0.05 |     330 B |     - |     - |     - |      56 B |
|                        ForEachOnIEnumerable | 35.247 μs | 0.1517 μs | 0.1419 μs |  6.64 |    0.03 |     194 B |     - |     - |     - |      32 B |
|              ForEachOnArrayStructEnumerable |  5.019 μs | 0.0225 μs | 0.0211 μs |  0.94 |    0.00 |      72 B |     - |     - |     - |         - |
| ForEachOnArrayStructEnumerableAsIEnumerable | 52.674 μs | 0.2354 μs | 0.2202 μs |  9.92 |    0.05 |     340 B |     - |     - |     - |      72 B |
