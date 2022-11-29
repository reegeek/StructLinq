## ToArrayOnArrayWhereOfClass

### Source
[ToArrayOnArrayWhereOfClass.cs](../../src/StructLinq.Benchmark/ToArrayOnArrayWhereOfClass.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                 Method |      Mean |    Error |   StdDev | Ratio | RatioSD |    Gen0 |   Gen1 | Allocated | Alloc Ratio |
|----------------------- |----------:|---------:|---------:|------:|--------:|--------:|-------:|----------:|------------:|
|                   Linq |  53.12 μs | 0.521 μs | 0.462 μs |  1.00 |    0.00 | 22.4609 | 4.4556 | 103.73 KB |        1.00 |
|             StructLinq | 101.32 μs | 0.394 μs | 0.369 μs |  1.91 |    0.02 |  8.4229 | 0.9766 |  39.15 KB |        0.38 |
|    StructLinqZeroAlloc | 102.37 μs | 0.457 μs | 0.405 μs |  1.93 |    0.02 |  8.4229 | 0.9766 |  39.09 KB |        0.38 |
| StructLinqWithFunction |  88.80 μs | 0.426 μs | 0.399 μs |  1.67 |    0.02 |  8.4229 | 0.9766 |  39.09 KB |        0.38 |
