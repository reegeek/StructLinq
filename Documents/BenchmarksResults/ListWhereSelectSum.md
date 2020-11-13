## ListWhereSelectSum

### Source
[ListWhereSelectSum.cs](../../src/StructLinq.Benchmark/ListWhereSelectSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|                          Method |     Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------- |---------:|---------:|---------:|------:|------:|------:|------:|----------:|
|                            LINQ | 64.21 μs | 0.375 μs | 0.351 μs |  1.00 |     - |     - |     - |     152 B |
|          StructLinqWithDelegate | 32.70 μs | 0.171 μs | 0.160 μs |  0.51 |     - |     - |     - |     104 B |
| StructLinqWithDelegateZeroAlloc | 31.83 μs | 0.209 μs | 0.186 μs |  0.50 |     - |     - |     - |         - |
|             StructLinqZeroAlloc | 13.63 μs | 0.039 μs | 0.033 μs |  0.21 |     - |     - |     - |         - |
