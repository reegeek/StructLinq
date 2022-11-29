## Union

### Source
[Union.cs](../../src/StructLinq.Benchmark/Union.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                            Method |     Mean |   Error |  StdDev | Ratio |    Gen0 |    Gen1 |    Gen2 | Allocated | Alloc Ratio |
|---------------------------------- |---------:|--------:|--------:|------:|--------:|--------:|--------:|----------:|------------:|
|                              Linq | 286.0 μs | 3.39 μs | 3.01 μs |  1.00 | 95.2148 | 95.2148 | 95.2148 |  538688 B |       1.000 |
|                        StructLinq | 139.0 μs | 0.47 μs | 0.44 μs |  0.49 |       - |       - |       - |      64 B |       0.000 |
|               StructLinqZeroAlloc | 144.6 μs | 0.81 μs | 0.76 μs |  0.51 |       - |       - |       - |         - |       0.000 |
|    StructLinqZeroAllocAndComparer | 113.9 μs | 0.55 μs | 0.52 μs |  0.40 |       - |       - |       - |         - |       0.000 |
| StructLinqZeroAllocAndComparerSum | 101.2 μs | 0.30 μs | 0.27 μs |  0.35 |       - |       - |       - |         - |       0.000 |
