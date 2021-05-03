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
|                            Method |     Mean |   Error |   StdDev | Ratio |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
|---------------------------------- |---------:|--------:|---------:|------:|--------:|--------:|--------:|----------:|
|                              Linq | 501.7 μs | 9.40 μs | 16.47 μs |  1.00 | 90.8203 | 90.8203 | 90.8203 |  524848 B |
|                        StructLinq | 176.3 μs | 0.64 μs |  0.57 μs |  0.36 |       - |       - |       - |      64 B |
|               StructLinqZeroAlloc | 177.2 μs | 1.65 μs |  1.54 μs |  0.36 |       - |       - |       - |         - |
|    StructLinqZeroAllocAndComparer | 147.7 μs | 1.51 μs |  1.34 μs |  0.30 |       - |       - |       - |         - |
| StructLinqZeroAllocAndComparerSum | 113.7 μs | 1.06 μs |  0.94 μs |  0.23 |       - |       - |       - |         - |
