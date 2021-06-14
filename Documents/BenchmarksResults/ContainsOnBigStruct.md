## ContainsOnBigStruct

### Source
[ContainsOnBigStruct.cs](../../src/StructLinq.Benchmark/ContainsOnBigStruct.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19043
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.301
  [Host]     : .NET Core 5.0.7 (CoreCLR 5.0.721.25508, CoreFX 5.0.721.25508), X64 RyuJIT
  DefaultJob : .NET Core 5.0.7 (CoreCLR 5.0.721.25508, CoreFX 5.0.721.25508), X64 RyuJIT


```
|                                   Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------------------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
|                                     Linq |  6.444 μs | 0.0215 μs | 0.0201 μs |  1.00 |    0.00 |     - |     - |     - |         - |
|                                    Array |  6.426 μs | 0.0334 μs | 0.0312 μs |  1.00 |    0.00 |     - |     - |     - |         - |
|                               StructLinq | 25.566 μs | 0.4951 μs | 0.5503 μs |  3.98 |    0.09 |     - |     - |     - |         - |
|                            RefStructLinq | 18.115 μs | 0.1549 μs | 0.1373 μs |  2.81 |    0.02 |     - |     - |     - |         - |
|             StructLinqWithCustomComparer | 14.013 μs | 0.1160 μs | 0.1085 μs |  2.17 |    0.02 |     - |     - |     - |         - |
| RefStructLinqZeroAllocwithCustomComparer |  5.136 μs | 0.0308 μs | 0.0273 μs |  0.80 |    0.00 |     - |     - |     - |         - |
