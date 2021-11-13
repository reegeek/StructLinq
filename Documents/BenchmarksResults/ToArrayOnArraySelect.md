## ToArrayOnArraySelect

### Source
[ToArrayOnArraySelect.cs](../../src/StructLinq.Benchmark/ToArrayOnArraySelect.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19043.1081 (21H1/May2021Update)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=5.0.301
  [Host]     : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT
  DefaultJob : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT


```
|                 Method |     Mean |    Error |   StdDev | Ratio | Code Size |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|----------------------- |---------:|---------:|---------:|------:|----------:|-------:|-------:|------:|----------:|
|                   Linq | 19.33 μs | 0.087 μs | 0.081 μs |  1.00 |      1 KB | 8.4534 | 1.0376 |     - |     39 KB |
|             StructLinq | 21.59 μs | 0.127 μs | 0.119 μs |  1.12 |      1 KB | 8.4534 | 1.0376 |     - |     39 KB |
|    StructLinqZeroAlloc | 21.79 μs | 0.156 μs | 0.146 μs |  1.13 |      1 KB | 8.4534 | 1.0376 |     - |     39 KB |
| StructLinqWithFunction | 15.94 μs | 0.047 μs | 0.042 μs |  0.82 |      1 KB | 8.4534 | 1.0376 |     - |     39 KB |
