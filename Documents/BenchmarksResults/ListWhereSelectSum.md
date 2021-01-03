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
|                            LINQ | 65.45 μs | 0.587 μs | 0.549 μs |  1.00 |     - |     - |     - |     152 B |
|          StructLinqWithDelegate | 28.71 μs | 0.119 μs | 0.111 μs |  0.44 |     - |     - |     - |      96 B |
| StructLinqWithDelegateZeroAlloc | 27.96 μs | 0.139 μs | 0.123 μs |  0.43 |     - |     - |     - |         - |
|             StructLinqZeroAlloc | 11.26 μs | 0.045 μs | 0.042 μs |  0.17 |     - |     - |     - |         - |
