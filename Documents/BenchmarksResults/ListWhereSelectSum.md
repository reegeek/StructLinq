## ListWhereSelectSum

### Source
[ListWhereSelectSum.cs](../../src/StructLinq.Benchmark/ListWhereSelectSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                          Method |     Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------- |---------:|---------:|---------:|------:|------:|------:|------:|----------:|
|                            LINQ | 65.57 μs | 0.596 μs | 0.557 μs |  1.00 |     - |     - |     - |     152 B |
|          StructLinqWithDelegate | 29.12 μs | 0.101 μs | 0.095 μs |  0.44 |     - |     - |     - |      96 B |
| StructLinqWithDelegateZeroAlloc | 33.27 μs | 0.240 μs | 0.200 μs |  0.51 |     - |     - |     - |         - |
|             StructLinqZeroAlloc | 13.71 μs | 0.034 μs | 0.032 μs |  0.21 |     - |     - |     - |         - |
