## SelectManyOnArray

### Source
[SelectManyOnArray.cs](../../src/StructLinq.Benchmark/SelectManyOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|                                  Method |       Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Allocated |
|---------------------------------------- |-----------:|---------:|---------:|------:|--------:|-------:|----------:|
|                                    LINQ | 4,190.7 μs | 35.83 μs | 33.51 μs |  1.00 |    0.00 |      - |  32,068 B |
|                              StructLINQ | 2,142.8 μs | 42.08 μs | 53.21 μs |  0.52 |    0.02 | 3.9063 |  32,002 B |
| StructLINQWhereReturnIsStructEnumerable |   878.0 μs |  6.62 μs |  5.53 μs |  0.21 |    0.00 |      - |      33 B |
|                  StructLINQWithFunction |   881.2 μs |  4.36 μs |  3.86 μs |  0.21 |    0.00 |      - |       1 B |
