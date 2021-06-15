## SelectManyOnArray

### Source
[SelectManyOnArray.cs](../../src/StructLinq.Benchmark/SelectManyOnArray.cs)

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
|                                    LINQ | 4,341.2 μs | 21.54 μs | 19.10 μs |  1.00 |      - |     - |     - |   32064 B |
|                              StructLINQ | 1,977.8 μs |  7.98 μs |  6.66 μs |  0.46 | 3.9063 |     - |     - |   32000 B |
| StructLINQWhereReturnIsStructEnumerable |   879.2 μs |  2.63 μs |  2.46 μs |  0.20 |      - |     - |     - |      32 B |
|                  StructLINQWithFunction |   883.2 μs |  3.12 μs |  2.77 μs |  0.20 |      - |     - |     - |         - |
