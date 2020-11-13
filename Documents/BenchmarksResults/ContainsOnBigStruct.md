## ContainsOnBigStruct

### Source
[ContainsOnBigStruct.cs](../../src/StructLinq.Benchmark/ContainsOnBigStruct.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|                                   Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------------------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
|                                     Linq |  6.319 μs | 0.0319 μs | 0.0299 μs |  1.00 |    0.00 |     - |     - |     - |         - |
|                                    Array |  6.300 μs | 0.0308 μs | 0.0273 μs |  1.00 |    0.00 |     - |     - |     - |         - |
|                               StructLinq | 23.324 μs | 0.2476 μs | 0.2195 μs |  3.69 |    0.04 |     - |     - |     - |         - |
|                            RefStructLinq | 17.720 μs | 0.0653 μs | 0.0546 μs |  2.80 |    0.02 |     - |     - |     - |         - |
|             StructLinqWithCustomComparer | 15.060 μs | 0.0833 μs | 0.0779 μs |  2.38 |    0.02 |     - |     - |     - |         - |
| RefStructLinqZeroAllocwithCustomComparer |  5.034 μs | 0.0262 μs | 0.0245 μs |  0.80 |    0.01 |     - |     - |     - |         - |
