## Intersect

### Source
[Intersect.cs](../../src/StructLinq.Benchmark/Intersect.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                         Method |     Mean |    Error |   StdDev | Ratio |    Gen0 |   Gen1 | Allocated | Alloc Ratio |
|------------------------------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
|                           Linq | 96.15 μs | 0.351 μs | 0.311 μs |  1.00 | 19.7754 | 4.8828 |   93704 B |       1.000 |
|                     StructLinq | 95.73 μs | 0.423 μs | 0.354 μs |  1.00 |       - |      - |      64 B |       0.001 |
|            StructLinqZeroAlloc | 93.66 μs | 0.238 μs | 0.211 μs |  0.97 |       - |      - |         - |       0.000 |
| StructLinqZeroAllocAndComparer | 72.41 μs | 0.322 μs | 0.301 μs |  0.75 |       - |      - |         - |       0.000 |
