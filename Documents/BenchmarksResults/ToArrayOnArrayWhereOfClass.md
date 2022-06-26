## ToArrayOnArrayWhereOfClass

### Source
[ToArrayOnArrayWhereOfClass.cs](../../src/StructLinq.Benchmark/ToArrayOnArrayWhereOfClass.cs)

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
|                   Linq | 57.68 μs | 0.337 μs | 0.315 μs |  1.00 | 22.4609 | 5.5542 |    104 KB |
|             StructLinq | 97.24 μs | 0.319 μs | 0.282 μs |  1.69 |  8.4229 | 0.9766 |     39 KB |
|    StructLinqZeroAlloc | 97.18 μs | 0.767 μs | 0.718 μs |  1.68 |  8.4229 | 0.9766 |     39 KB |
| StructLinqWithFunction | 79.77 μs | 0.372 μs | 0.330 μs |  1.38 |  8.4229 | 0.9766 |     39 KB |
