## ToArrayOnArrayWhere

### Source
[ToArrayOnArrayWhere.cs](../../src/StructLinq.Benchmark/ToArrayOnArrayWhere.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19043.1081 (21H1/May2021Update)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=5.0.301
  [Host]     : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT
  DefaultJob : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT


```
|                 Method |     Mean |    Error |   StdDev | Ratio |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|----------------------- |---------:|---------:|---------:|------:|--------:|-------:|------:|----------:|
|                   Linq | 33.58 μs | 0.199 μs | 0.176 μs |  1.00 | 11.2915 | 1.4038 |     - |     52 KB |
|             StructLinq | 29.87 μs | 0.276 μs | 0.245 μs |  0.89 |  4.2419 | 0.2747 |     - |     20 KB |
|    StructLinqZeroAlloc | 28.80 μs | 0.111 μs | 0.104 μs |  0.86 |  4.2114 | 0.2747 |     - |     20 KB |
| StructLinqWithFunction | 15.13 μs | 0.129 μs | 0.114 μs |  0.45 |  4.2267 | 0.2747 |     - |     20 KB |
