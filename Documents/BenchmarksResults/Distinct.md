## Distinct

### Source
[Distinct.cs](../../src/StructLinq.Benchmark/Distinct.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                 Method |     Mean |   Error |  StdDev | Ratio |    Gen0 |    Gen1 |    Gen2 | Allocated | Alloc Ratio |
|----------------------- |---------:|--------:|--------:|------:|--------:|--------:|--------:|----------:|------------:|
|                   Linq | 361.3 μs | 2.81 μs | 2.62 μs |  1.00 | 95.2148 | 95.2148 | 95.2148 |  538648 B |       1.000 |
|             StructLinq | 148.3 μs | 0.84 μs | 0.66 μs |  0.41 |       - |       - |       - |      32 B |       0.000 |
|    StructLinqZeroAlloc | 160.4 μs | 0.54 μs | 0.51 μs |  0.44 |       - |       - |       - |         - |       0.000 |
| StructLinqZeroAllocSum | 148.0 μs | 0.37 μs | 0.35 μs |  0.41 |       - |       - |       - |         - |       0.000 |
