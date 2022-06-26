## Except

### Source
[Except.cs](../../src/StructLinq.Benchmark/Except.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|                            Method |     Mean |   Error |  StdDev | Ratio |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
|---------------------------------- |---------:|--------:|--------:|------:|--------:|--------:|--------:|----------:|
|                              Linq | 193.2 μs | 1.21 μs | 1.01 μs |  1.00 | 45.4102 | 45.4102 | 45.4102 | 288,063 B |
|                        StructLinq | 146.9 μs | 0.47 μs | 0.41 μs |  0.76 |       - |       - |       - |      64 B |
|               StructLinqZeroAlloc | 144.4 μs | 0.49 μs | 0.44 μs |  0.75 |       - |       - |       - |         - |
|    StructLinqZeroAllocAndComparer | 124.0 μs | 0.68 μs | 0.57 μs |  0.64 |       - |       - |       - |         - |
| StructLinqZeroAllocAndComparerSum | 104.4 μs | 0.66 μs | 0.55 μs |  0.54 |       - |       - |       - |         - |
