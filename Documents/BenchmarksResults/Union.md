## Union

### Source
[Union.cs](../../src/StructLinq.Benchmark/Union.cs)

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
|                              Linq | 283.7 μs | 3.16 μs | 2.80 μs |  1.00 | 95.2148 | 95.2148 | 95.2148 | 538,688 B |
|                        StructLinq | 148.3 μs | 1.13 μs | 1.00 μs |  0.52 |       - |       - |       - |      64 B |
|               StructLinqZeroAlloc | 148.0 μs | 1.07 μs | 1.00 μs |  0.52 |       - |       - |       - |         - |
|    StructLinqZeroAllocAndComparer | 128.4 μs | 1.16 μs | 1.03 μs |  0.45 |       - |       - |       - |         - |
| StructLinqZeroAllocAndComparerSum | 103.1 μs | 1.13 μs | 1.00 μs |  0.36 |       - |       - |       - |         - |
