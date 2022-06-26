## ToArrayOnArraySelect

### Source
[ToArrayOnArraySelect.cs](../../src/StructLinq.Benchmark/ToArrayOnArraySelect.cs)

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
|                   Linq | 16.979 μs | 0.1210 μs | 0.1132 μs |  1.00 | 8.4534 | 1.0376 |     39 KB |
|             StructLinq | 16.403 μs | 0.1426 μs | 0.1334 μs |  0.97 | 8.4534 | 1.0376 |     39 KB |
|    StructLinqZeroAlloc | 18.938 μs | 0.1440 μs | 0.1347 μs |  1.12 | 8.4534 | 1.0376 |     39 KB |
| StructLinqWithFunction |  7.380 μs | 0.0579 μs | 0.0541 μs |  0.43 | 8.4686 | 1.0529 |     39 KB |
