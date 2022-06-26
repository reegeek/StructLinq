## ToArrayOnArraySelectOfClass

### Source
[ToArrayOnArraySelectOfClass.cs](../../src/StructLinq.Benchmark/ToArrayOnArraySelectOfClass.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|                 Method |      Mean |     Error |    StdDev | Ratio |  Gen 0 |  Gen 1 | Allocated |
|----------------------- |----------:|----------:|----------:|------:|-------:|-------:|----------:|
|                   Linq | 17.742 μs | 0.2037 μs | 0.1806 μs |  1.00 | 8.4534 | 1.0376 |     39 KB |
|             StructLinq | 17.144 μs | 0.0813 μs | 0.0720 μs |  0.97 | 8.4534 | 1.0376 |     39 KB |
|    StructLinqZeroAlloc | 18.888 μs | 0.1028 μs | 0.0961 μs |  1.06 | 8.4534 | 1.0376 |     39 KB |
| StructLinqWithFunction |  8.500 μs | 0.0733 μs | 0.0686 μs |  0.48 | 8.4686 | 1.0529 |     39 KB |
