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
|                            LINQ | 65.640 μs | 0.3483 μs | 0.3258 μs |  1.00 |     - |     - |     - |     152 B |
|          StructLinqWithDelegate | 30.502 μs | 0.1173 μs | 0.1097 μs |  0.46 |     - |     - |     - |      96 B |
| StructLinqWithDelegateZeroAlloc | 29.441 μs | 0.1763 μs | 0.1563 μs |  0.45 |     - |     - |     - |         - |
|             StructLinqZeroAlloc |  6.303 μs | 0.0241 μs | 0.0201 μs |  0.10 |     - |     - |     - |         - |
