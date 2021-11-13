## ToListComparison

### Source
[ToListComparison.cs](../../src/StructLinq.Benchmark/ToListComparison.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19043.1081 (21H1/May2021Update)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=5.0.301
  [Host]             : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT
  .NET 5.0           : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT
  .NET Framework 4.8 : .NET Framework 4.8 (4.8.4360.0), X64 RyuJIT


```
|                      Method |                Job |            Runtime |     Mean |    Error |   StdDev |   Gen 0 |  Gen 1 | Gen 2 | Allocated | Code Size |
|---------------------------- |------------------- |------------------- |---------:|---------:|---------:|--------:|-------:|------:|----------:|----------:|
|                   AddInList |           .NET 5.0 |           .NET 5.0 | 21.18 μs | 0.256 μs | 0.239 μs | 27.7710 | 9.2468 |     - |    128 KB |      1 KB |
|          ToArrayThenNewList |           .NET 5.0 |           .NET 5.0 | 23.17 μs | 0.457 μs | 0.954 μs | 16.9373 | 0.0305 |     - |     78 KB |      2 KB |
| ToArrayThenNewListAndLayout |           .NET 5.0 |           .NET 5.0 | 21.42 μs | 0.230 μs | 0.192 μs | 16.9373 | 0.0305 |     - |     78 KB |      2 KB |
|                 WithVisitor |           .NET 5.0 |           .NET 5.0 | 19.53 μs | 0.065 μs | 0.058 μs |  8.4534 | 0.0305 |     - |     39 KB |      1 KB |
|                   AddInList | .NET Framework 4.8 | .NET Framework 4.8 | 28.37 μs | 0.171 μs | 0.160 μs | 27.7710 | 0.0305 |     - |    128 KB |      1 KB |
|          ToArrayThenNewList | .NET Framework 4.8 | .NET Framework 4.8 | 23.78 μs | 0.107 μs | 0.100 μs | 16.9373 | 1.8616 |     - |     78 KB |      3 KB |
| ToArrayThenNewListAndLayout | .NET Framework 4.8 | .NET Framework 4.8 | 22.37 μs | 0.056 μs | 0.047 μs | 16.9373 | 1.8616 |     - |     78 KB |      3 KB |
|                 WithVisitor | .NET Framework 4.8 | .NET Framework 4.8 | 20.36 μs | 0.034 μs | 0.030 μs |  8.4534 | 0.9155 |     - |     39 KB |      2 KB |
