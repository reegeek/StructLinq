## SumOnSelectMany

### Source
[SumOnSelectMany.cs](../../src/StructLinq.Benchmark/SumOnSelectMany.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                                  Method |       Mean |    Error |   StdDev | Ratio |   Gen0 | Allocated | Alloc Ratio |
|---------------------------------------- |-----------:|---------:|---------:|------:|-------:|----------:|------------:|
|                                    LINQ | 4,144.8 μs | 19.67 μs | 18.40 μs |  1.00 |      - |   32068 B |       1.000 |
|                              StructLINQ | 2,052.2 μs |  5.77 μs |  5.11 μs |  0.50 | 3.9063 |   32034 B |       0.999 |
| StructLINQWhereReturnIsStructEnumerable |   601.5 μs |  3.67 μs |  3.43 μs |  0.15 |      - |      32 B |       0.001 |
|                  StructLINQWithFunction |   685.4 μs |  2.03 μs |  1.70 μs |  0.17 |      - |         - |       0.000 |
|       StructLINQWithFunctionWithForeach |   848.3 μs |  3.89 μs |  3.44 μs |  0.20 |      - |         - |       0.000 |
