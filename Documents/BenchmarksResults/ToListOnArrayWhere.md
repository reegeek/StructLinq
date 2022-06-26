## ToListOnArrayWhere

### Source
[ToListOnArrayWhere.cs](../../src/StructLinq.Benchmark/ToListOnArrayWhere.cs)

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
|                   Linq | 31.92 μs | 0.359 μs | 0.299 μs |  1.00 | 13.9771 | 2.7466 |     64 KB |
|             StructLinq | 27.40 μs | 0.312 μs | 0.292 μs |  0.86 |  4.2419 | 0.5188 |     20 KB |
|    StructLinqZeroAlloc | 29.27 μs | 0.265 μs | 0.235 μs |  0.92 |  4.2419 | 0.5188 |     20 KB |
| StructLinqWithFunction | 11.92 μs | 0.069 μs | 0.064 μs |  0.37 |  4.2419 | 0.5188 |     20 KB |
