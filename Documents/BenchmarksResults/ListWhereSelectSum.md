## ListWhereSelectSum

### Source
[ListWhereSelectSum.cs](../../src/StructLinq.Benchmark/ListWhereSelectSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100-preview.7.20366.6
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  DefaultJob : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT


```
|                          Method |     Mean |    Error |   StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------- |---------:|---------:|---------:|------:|--------:|------:|------:|------:|----------:|
|                            LINQ | 75.13 us | 1.548 us | 2.792 us |  1.00 |    0.00 |     - |     - |     - |     152 B |
|          StructLinqWithDelegate | 45.13 us | 0.302 us | 0.267 us |  0.60 |    0.02 |     - |     - |     - |     104 B |
| StructLinqWithDelegateZeroAlloc | 41.71 us | 0.505 us | 0.448 us |  0.55 |    0.02 |     - |     - |     - |         - |
|             StructLinqZeroAlloc | 16.23 us | 0.360 us | 0.455 us |  0.21 |    0.01 |     - |     - |     - |         - |
|                       WithVisit | 11.85 us | 0.077 us | 0.068 us |  0.16 |    0.01 |     - |     - |     - |         - |
