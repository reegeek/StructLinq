## ToListOnArrayWhere

### Source
[ToListOnArrayWhere.cs](../../src/StructLinq.Benchmark/ToListOnArrayWhere.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                 Method |     Mean |    Error |   StdDev | Ratio |    Gen0 |   Gen1 | Allocated | Alloc Ratio |
|----------------------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
|                   Linq | 29.76 μs | 0.103 μs | 0.096 μs |  1.00 | 13.9771 | 3.4790 |  64.34 KB |        1.00 |
|             StructLinq | 29.69 μs | 0.356 μs | 0.333 μs |  1.00 |  4.2725 | 0.5798 |  19.65 KB |        0.31 |
|    StructLinqZeroAlloc | 25.85 μs | 0.083 μs | 0.065 μs |  0.87 |  4.2419 | 0.5798 |  19.59 KB |        0.30 |
| StructLinqWithFunction | 15.01 μs | 0.044 μs | 0.041 μs |  0.50 |  4.2419 | 0.5951 |  19.59 KB |        0.30 |
