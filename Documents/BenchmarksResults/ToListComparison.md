## ToListComparison

### Source
[ToListComparison.cs](../../src/StructLinq.Benchmark/ToListComparison.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]             : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  .NET 5.0           : .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT
  .NET 6.0           : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  .NET Framework 4.8 : .NET Framework 4.8 (4.8.4515.0), X64 RyuJIT


```
|                      Method |                Job |            Runtime |     Mean |    Error |   StdDev | Ratio | RatioSD |   Gen 0 |  Gen 1 | Allocated |
|---------------------------- |------------------- |------------------- |---------:|---------:|---------:|------:|--------:|--------:|-------:|----------:|
|                   AddInList |           .NET 5.0 |           .NET 5.0 | 20.92 μs | 0.203 μs | 0.190 μs |  0.70 |    0.01 | 27.7710 | 9.2468 |    128 KB |
|                   AddInList |           .NET 6.0 |           .NET 6.0 | 21.06 μs | 0.165 μs | 0.146 μs |  0.71 |    0.01 | 27.7710 | 9.2468 |    128 KB |
|                   AddInList | .NET Framework 4.8 | .NET Framework 4.8 | 29.82 μs | 0.357 μs | 0.334 μs |  1.00 |    0.00 | 27.7710 | 9.2468 |    128 KB |
|                             |                    |                    |          |          |          |       |         |         |        |           |
|          ToArrayThenNewList |           .NET 5.0 |           .NET 5.0 | 22.62 μs | 0.114 μs | 0.101 μs |  0.95 |    0.01 | 16.9373 | 2.1057 |     78 KB |
|          ToArrayThenNewList |           .NET 6.0 |           .NET 6.0 | 26.90 μs | 0.236 μs | 0.221 μs |  1.13 |    0.01 | 16.9373 | 2.1057 |     78 KB |
|          ToArrayThenNewList | .NET Framework 4.8 | .NET Framework 4.8 | 23.87 μs | 0.173 μs | 0.162 μs |  1.00 |    0.00 | 16.9373 | 2.1057 |     78 KB |
|                             |                    |                    |          |          |          |       |         |         |        |           |
| ToArrayThenNewListAndLayout |           .NET 5.0 |           .NET 5.0 | 21.23 μs | 0.135 μs | 0.126 μs |  0.95 |    0.01 | 16.9373 | 2.1057 |     78 KB |
| ToArrayThenNewListAndLayout |           .NET 6.0 |           .NET 6.0 | 25.29 μs | 0.138 μs | 0.129 μs |  1.13 |    0.01 | 16.9373 | 2.1057 |     78 KB |
| ToArrayThenNewListAndLayout | .NET Framework 4.8 | .NET Framework 4.8 | 22.36 μs | 0.160 μs | 0.141 μs |  1.00 |    0.00 | 16.9373 | 2.1057 |     78 KB |
|                             |                    |                    |          |          |          |       |         |         |        |           |
|                 WithVisitor |           .NET 5.0 |           .NET 5.0 | 19.72 μs | 0.118 μs | 0.111 μs |  0.91 |    0.03 |  8.4534 | 1.6785 |     39 KB |
|                 WithVisitor |           .NET 6.0 |           .NET 6.0 | 19.49 μs | 0.147 μs | 0.138 μs |  0.90 |    0.02 |  8.4534 | 1.6785 |     39 KB |
|                 WithVisitor | .NET Framework 4.8 | .NET Framework 4.8 | 21.48 μs | 0.419 μs | 0.559 μs |  1.00 |    0.00 |  8.4229 | 1.0376 |     39 KB |
