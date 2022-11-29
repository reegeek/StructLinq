## Except

### Source
[Except.cs](../../src/StructLinq.Benchmark/Except.cs)

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
|                              Linq | 201.1 μs | 1.03 μs | 0.96 μs |  1.00 | 45.4102 | 45.4102 | 45.4102 |  288063 B |       1.000 |
|                        StructLinq | 143.6 μs | 0.67 μs | 0.62 μs |  0.71 |       - |       - |       - |      64 B |       0.000 |
|               StructLinqZeroAlloc | 143.6 μs | 0.89 μs | 0.83 μs |  0.71 |       - |       - |       - |         - |       0.000 |
|    StructLinqZeroAllocAndComparer | 116.5 μs | 0.47 μs | 0.41 μs |  0.58 |       - |       - |       - |         - |       0.000 |
| StructLinqZeroAllocAndComparerSum | 102.8 μs | 0.13 μs | 0.12 μs |  0.51 |       - |       - |       - |         - |       0.000 |
