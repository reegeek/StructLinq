## ToArrayOnArrayWhere

### Source
[ToArrayOnArrayWhere.cs](../../src/StructLinq.Benchmark/ToArrayOnArrayWhere.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|                 Method |     Mean |    Error |   StdDev | Ratio |   Gen 0 |  Gen 1 | Allocated |
|----------------------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|
|                   Linq | 37.13 μs | 0.197 μs | 0.185 μs |  1.00 | 11.2915 | 1.4038 |     52 KB |
|             StructLinq | 26.38 μs | 0.196 μs | 0.183 μs |  0.71 |  4.2419 | 0.2747 |     20 KB |
|    StructLinqZeroAlloc | 26.29 μs | 0.100 μs | 0.089 μs |  0.71 |  4.2114 | 0.2747 |     20 KB |
| StructLinqWithFunction | 11.63 μs | 0.110 μs | 0.097 μs |  0.31 |  4.2267 | 0.2747 |     20 KB |
