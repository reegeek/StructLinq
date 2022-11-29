## SelectManyOnArray

### Source
[SelectManyOnArray.cs](../../src/StructLinq.Benchmark/SelectManyOnArray.cs)

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
|                                    LINQ | 4,065.7 μs | 18.96 μs | 17.73 μs |  1.00 |      - |   32068 B |       1.000 |
|                              StructLINQ | 2,171.6 μs |  4.44 μs |  4.15 μs |  0.53 | 3.9063 |   32002 B |       0.998 |
| StructLINQWhereReturnIsStructEnumerable |   852.4 μs |  2.80 μs |  2.62 μs |  0.21 |      - |      32 B |       0.001 |
|                  StructLINQWithFunction |   848.3 μs |  4.35 μs |  4.07 μs |  0.21 |      - |         - |       0.000 |
