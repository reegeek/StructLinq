## SumOnSelectMany

### Source
[SumOnSelectMany.cs](../../src/StructLinq.Benchmark/SumOnSelectMany.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19043
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.301
  [Host]     : .NET Core 5.0.7 (CoreCLR 5.0.721.25508, CoreFX 5.0.721.25508), X64 RyuJIT
  DefaultJob : .NET Core 5.0.7 (CoreCLR 5.0.721.25508, CoreFX 5.0.721.25508), X64 RyuJIT


```
|                                  Method |       Mean |    Error |   StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------------- |-----------:|---------:|---------:|------:|-------:|------:|------:|----------:|
|                                    LINQ | 4,219.9 μs | 34.79 μs | 29.05 μs |  1.00 |      - |     - |     - |   32064 B |
|                              StructLINQ | 1,862.5 μs |  6.40 μs |  5.99 μs |  0.44 | 5.8594 |     - |     - |   32032 B |
| StructLINQWhereReturnIsStructEnumerable |   622.8 μs |  2.54 μs |  2.12 μs |  0.15 |      - |     - |     - |      32 B |
|                  StructLINQWithFunction |   712.0 μs |  3.99 μs |  3.73 μs |  0.17 |      - |     - |     - |         - |
|       StructLINQWithFunctionWithForeach |   817.3 μs |  7.96 μs |  7.44 μs |  0.19 |      - |     - |     - |       1 B |
