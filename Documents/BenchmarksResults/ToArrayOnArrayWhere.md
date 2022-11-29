## ToArrayOnArrayWhere

### Source
[ToArrayOnArrayWhere.cs](../../src/StructLinq.Benchmark/ToArrayOnArrayWhere.cs)

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
|                   Linq | 33.33 μs | 0.138 μs | 0.115 μs |  1.00 | 11.2915 | 1.4038 |  52.19 KB |        1.00 |
|             StructLinq | 28.00 μs | 0.136 μs | 0.128 μs |  0.84 |  4.2419 | 0.2747 |  19.62 KB |        0.38 |
|    StructLinqZeroAlloc | 27.90 μs | 0.060 μs | 0.056 μs |  0.84 |  4.2114 | 0.2747 |  19.55 KB |        0.37 |
| StructLinqWithFunction | 14.68 μs | 0.075 μs | 0.071 μs |  0.44 |  4.2267 | 0.2899 |  19.55 KB |        0.37 |
