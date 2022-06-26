## SumOnSelectMany

### Source
[SumOnSelectMany.cs](../../src/StructLinq.Benchmark/SumOnSelectMany.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|                                  Method |       Mean |    Error |   StdDev | Ratio |  Gen 0 | Allocated |
|---------------------------------------- |-----------:|---------:|---------:|------:|-------:|----------:|
|                                    LINQ | 4,202.0 μs | 45.29 μs | 42.36 μs |  1.00 |      - |  32,068 B |
|                              StructLINQ | 2,238.4 μs | 26.90 μs | 23.84 μs |  0.53 | 3.9063 |  32,034 B |
| StructLINQWhereReturnIsStructEnumerable |   612.7 μs |  2.67 μs |  2.23 μs |  0.15 |      - |      33 B |
|                  StructLINQWithFunction |   700.6 μs |  3.78 μs |  3.35 μs |  0.17 |      - |       1 B |
|       StructLINQWithFunctionWithForeach |   876.9 μs |  5.26 μs |  4.92 μs |  0.21 |      - |       1 B |
