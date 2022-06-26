## OrderByArrayOfInt

### Source
[OrderByArrayOfInt.cs](../../src/StructLinq.Benchmark/OrderByArrayOfInt.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|                     Method |       Mean |    Error |   StdDev | Ratio |   Gen 0 |  Gen 1 | Allocated |
|--------------------------- |-----------:|---------:|---------:|------:|--------:|-------:|----------:|
|                       LINQ | 1,353.1 μs |  9.28 μs |  7.75 μs |  1.00 | 25.3906 | 3.9063 | 120,313 B |
|            StructLinqOrder | 1,540.3 μs | 14.01 μs | 11.70 μs |  1.14 |       - |      - |      34 B |
|          StructLinqOrderBy | 1,545.6 μs |  6.72 μs |  6.29 μs |  1.14 |       - |      - |      34 B |
|   StructLinqOrderZeroAlloc |   972.7 μs |  5.46 μs |  4.84 μs |  0.72 |       - |      - |       4 B |
| StructLinqOrderByZeroAlloc |   985.0 μs |  7.71 μs |  6.83 μs |  0.73 |       - |      - |       2 B |
