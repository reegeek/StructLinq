## Union

### Source
[Union.cs](../../src/StructLinq.Benchmark/Union.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
  DefaultJob : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT


```
|                            Method |     Mean |   Error |  StdDev | Ratio |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
|---------------------------------- |---------:|--------:|--------:|------:|--------:|--------:|--------:|----------:|
|                              Linq | 430.9 μs | 3.74 μs | 3.12 μs |  1.00 | 90.8203 | 90.8203 | 90.8203 |  524824 B |
|                        StructLinq | 182.4 μs | 3.57 μs | 3.34 μs |  0.42 |       - |       - |       - |      64 B |
|               StructLinqZeroAlloc | 187.4 μs | 3.61 μs | 3.71 μs |  0.43 |       - |       - |       - |         - |
|    StructLinqZeroAllocAndComparer | 152.3 μs | 2.96 μs | 3.40 μs |  0.36 |       - |       - |       - |         - |
| StructLinqZeroAllocAndComparerSum | 109.8 μs | 2.19 μs | 3.48 μs |  0.25 |       - |       - |       - |         - |
