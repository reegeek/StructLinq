## ToListOnArrayWhere

### Source
[ToListOnArrayWhere.cs](../../src/StructLinq.Benchmark/ToListOnArrayWhere.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|           Method |     Mean |    Error |   StdDev | Ratio |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|----------------- |---------:|---------:|---------:|------:|--------:|-------:|------:|----------:|
|             Linq | 32.49 μs | 0.377 μs | 0.335 μs |  1.00 | 13.9771 | 2.7466 |     - |  64.34 KB |
|       StructLinq | 27.68 μs | 0.117 μs | 0.110 μs |  0.85 |  4.2419 | 0.2747 |     - |  19.65 KB |
| StructLinqFaster | 12.30 μs | 0.095 μs | 0.088 μs |  0.38 |  4.2419 | 0.2747 |     - |  19.59 KB |
|        WithVisit | 12.28 μs | 0.050 μs | 0.044 μs |  0.38 |  4.2419 | 0.2747 |     - |  19.59 KB |
