## Except

### Source
[Except.cs](../../src/StructLinq.Benchmark/Except.cs)

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
|                              Linq | 405.5 μs | 4.10 μs | 3.64 μs |  1.00 | 90.8203 | 90.8203 | 90.8203 |  524848 B |
|                        StructLinq | 169.1 μs | 1.25 μs | 1.05 μs |  0.42 |       - |       - |       - |      64 B |
|               StructLinqZeroAlloc | 169.5 μs | 1.44 μs | 1.28 μs |  0.42 |       - |       - |       - |         - |
|    StructLinqZeroAllocAndComparer | 148.6 μs | 0.81 μs | 0.76 μs |  0.37 |       - |       - |       - |         - |
| StructLinqZeroAllocAndComparerSum | 129.5 μs | 0.62 μs | 0.52 μs |  0.32 |       - |       - |       - |         - |
