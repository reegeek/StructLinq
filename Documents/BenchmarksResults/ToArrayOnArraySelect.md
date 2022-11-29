## ToArrayOnArraySelect

### Source
[ToArrayOnArraySelect.cs](../../src/StructLinq.Benchmark/ToArrayOnArraySelect.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                 Method |      Mean |     Error |    StdDev | Ratio |   Gen0 |   Gen1 | Allocated | Alloc Ratio |
|----------------------- |----------:|----------:|----------:|------:|-------:|-------:|----------:|------------:|
|                   Linq | 21.585 μs | 0.0875 μs | 0.0776 μs |  1.00 | 8.4534 | 1.1902 |  39.13 KB |        1.00 |
|             StructLinq | 21.075 μs | 0.0755 μs | 0.0670 μs |  0.98 | 8.4534 | 1.1902 |  39.15 KB |        1.00 |
|    StructLinqZeroAlloc | 18.512 μs | 0.0607 μs | 0.0538 μs |  0.86 | 8.4534 | 1.1902 |  39.12 KB |        1.00 |
| StructLinqWithFunction |  6.129 μs | 0.0301 μs | 0.0281 μs |  0.28 | 8.4686 | 1.2054 |  39.09 KB |        1.00 |
