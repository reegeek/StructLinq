## Distinct

### Source
[Distinct.cs](../../src/StructLinq.Benchmark/Distinct.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|                 Method |     Mean |   Error |  StdDev | Ratio |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
|----------------------- |---------:|--------:|--------:|------:|--------:|--------:|--------:|----------:|
|                   Linq | 345.3 μs | 2.85 μs | 2.67 μs |  1.00 | 95.2148 | 95.2148 | 95.2148 | 538,648 B |
|             StructLinq | 177.9 μs | 0.77 μs | 0.64 μs |  0.52 |       - |       - |       - |      32 B |
|    StructLinqZeroAlloc | 177.9 μs | 1.03 μs | 0.91 μs |  0.52 |       - |       - |       - |         - |
| StructLinqZeroAllocSum | 142.8 μs | 0.34 μs | 0.28 μs |  0.41 |       - |       - |       - |         - |
