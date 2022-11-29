## ToArrayOnArraySelectOfClass

### Source
[ToArrayOnArraySelectOfClass.cs](../../src/StructLinq.Benchmark/ToArrayOnArraySelectOfClass.cs)

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
|                   Linq | 19.964 μs | 0.1384 μs | 0.1295 μs |  1.00 | 8.4534 | 1.0376 |  39.13 KB |        1.00 |
|             StructLinq | 21.246 μs | 0.1101 μs | 0.1030 μs |  1.06 | 8.4534 | 1.0376 |  39.15 KB |        1.00 |
|    StructLinqZeroAlloc | 18.519 μs | 0.1631 μs | 0.1446 μs |  0.93 | 8.4534 | 1.0376 |  39.09 KB |        1.00 |
| StructLinqWithFunction |  7.587 μs | 0.0321 μs | 0.0285 μs |  0.38 | 8.4686 | 1.0529 |  39.09 KB |        1.00 |
