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
|                          Method |      Mean |     Error |    StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------- |----------:|----------:|----------:|------:|------:|------:|------:|----------:|
|                            LINQ | 65.116 μs | 0.6153 μs | 0.5756 μs |  1.00 |     - |     - |     - |     152 B |
|          StructLinqWithDelegate | 26.146 μs | 0.2402 μs | 0.2247 μs |  0.40 |     - |     - |     - |      96 B |
| StructLinqWithDelegateZeroAlloc | 27.854 μs | 0.0938 μs | 0.0783 μs |  0.43 |     - |     - |     - |         - |
|             StructLinqZeroAlloc |  6.872 μs | 0.0155 μs | 0.0137 μs |  0.11 |     - |     - |     - |         - |
