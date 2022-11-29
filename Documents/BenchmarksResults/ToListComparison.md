## ToListComparison

### Source
[ToListComparison.cs](../../src/StructLinq.Benchmark/ToListComparison.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]             : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  .NET 6.0           : .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
  .NET 7.0           : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  .NET Framework 4.8 : .NET Framework 4.8.1 (4.8.9105.0), X64 RyuJIT VectorSize=256


```
|                      Method |                Job |            Runtime |     Mean |    Error |   StdDev | Ratio |    Gen0 |   Gen1 | Allocated | Alloc Ratio |
|---------------------------- |------------------- |------------------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
|                   AddInList |           .NET 6.0 |           .NET 6.0 | 20.36 μs | 0.139 μs | 0.123 μs |  0.70 | 27.7710 | 9.2468 | 128.32 KB |        1.00 |
|                   AddInList |           .NET 7.0 |           .NET 7.0 | 19.85 μs | 0.092 μs | 0.086 μs |  0.68 | 27.7710 | 9.2468 | 128.32 KB |        1.00 |
|                   AddInList | .NET Framework 4.8 | .NET Framework 4.8 | 29.12 μs | 0.221 μs | 0.206 μs |  1.00 | 27.7710 | 9.2468 | 128.48 KB |        1.00 |
|                             |                    |                    |          |          |          |       |         |        |           |             |
|          ToArrayThenNewList |           .NET 6.0 |           .NET 6.0 | 26.07 μs | 0.096 μs | 0.085 μs |  1.12 | 16.9373 | 2.1057 |   78.2 KB |        1.00 |
|          ToArrayThenNewList |           .NET 7.0 |           .NET 7.0 | 26.48 μs | 0.138 μs | 0.129 μs |  1.14 | 16.9373 | 2.1057 |   78.2 KB |        1.00 |
|          ToArrayThenNewList | .NET Framework 4.8 | .NET Framework 4.8 | 23.29 μs | 0.145 μs | 0.135 μs |  1.00 | 16.9373 | 2.1057 |  78.35 KB |        1.00 |
|                             |                    |                    |          |          |          |       |         |        |           |             |
| ToArrayThenNewListAndLayout |           .NET 6.0 |           .NET 6.0 | 24.59 μs | 0.142 μs | 0.133 μs |  1.13 | 16.9373 | 2.1057 |   78.2 KB |        1.00 |
| ToArrayThenNewListAndLayout |           .NET 7.0 |           .NET 7.0 | 25.84 μs | 0.255 μs | 0.238 μs |  1.18 | 16.9373 | 2.1057 |   78.2 KB |        1.00 |
| ToArrayThenNewListAndLayout | .NET Framework 4.8 | .NET Framework 4.8 | 21.83 μs | 0.078 μs | 0.073 μs |  1.00 | 16.9373 | 2.1057 |  78.35 KB |        1.00 |
|                             |                    |                    |          |          |          |       |         |        |           |             |
|                 WithVisitor |           .NET 6.0 |           .NET 6.0 | 18.81 μs | 0.058 μs | 0.054 μs |  0.94 |  8.4534 | 1.6785 |  39.12 KB |        1.00 |
|                 WithVisitor |           .NET 7.0 |           .NET 7.0 | 18.81 μs | 0.211 μs | 0.197 μs |  0.94 |  8.4534 | 1.6785 |  39.12 KB |        1.00 |
|                 WithVisitor | .NET Framework 4.8 | .NET Framework 4.8 | 19.95 μs | 0.066 μs | 0.061 μs |  1.00 |  8.4534 | 1.0376 |  39.18 KB |        1.00 |
