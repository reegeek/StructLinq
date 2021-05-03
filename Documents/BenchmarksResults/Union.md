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
|                              Linq | 424.0 μs | 8.27 μs | 7.74 μs |  1.00 | 90.8203 | 90.8203 | 90.8203 |  524824 B |
|                        StructLinq | 184.9 μs | 2.72 μs | 2.42 μs |  0.44 |       - |       - |       - |      64 B |
|               StructLinqZeroAlloc | 184.4 μs | 1.89 μs | 1.58 μs |  0.43 |       - |       - |       - |         - |
|    StructLinqZeroAllocAndComparer | 149.1 μs | 0.82 μs | 0.69 μs |  0.35 |       - |       - |       - |         - |
| StructLinqZeroAllocAndComparerSum | 132.7 μs | 0.41 μs | 0.37 μs |  0.31 |       - |       - |       - |         - |
