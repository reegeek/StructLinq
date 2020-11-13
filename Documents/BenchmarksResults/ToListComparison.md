## ToListComparison

### Source
[ToListComparison.cs](../../src/StructLinq.Benchmark/ToListComparison.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]        : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4250.0), X64 RyuJIT
  .NET Core 5.0 : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|                      Method |           Job |       Runtime |     Mean |    Error |   StdDev | Code Size |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|---------------------------- |-------------- |-------------- |---------:|---------:|---------:|----------:|--------:|-------:|------:|----------:|
|                   AddInList |      .NET 4.8 |      .NET 4.8 | 28.76 μs | 0.519 μs | 0.675 μs |    0.5 KB | 27.7710 | 0.0305 |     - | 128.48 KB |
|          ToArrayThenNewList |      .NET 4.8 |      .NET 4.8 | 21.93 μs | 0.175 μs | 0.164 μs |   2.72 KB | 16.9373 | 0.0305 |     - |  78.35 KB |
| ToArrayThenNewListAndLayout |      .NET 4.8 |      .NET 4.8 | 18.97 μs | 0.111 μs | 0.103 μs |   1.63 KB |  8.4534 | 0.0305 |     - |  39.18 KB |
|                   AddInList | .NET Core 5.0 | .NET Core 5.0 | 21.39 μs | 0.097 μs | 0.086 μs |   0.59 KB | 27.7710 | 9.2468 |     - | 128.32 KB |
|          ToArrayThenNewList | .NET Core 5.0 | .NET Core 5.0 | 21.53 μs | 0.109 μs | 0.102 μs |   1.76 KB | 16.9373 | 2.1057 |     - |   78.2 KB |
| ToArrayThenNewListAndLayout | .NET Core 5.0 | .NET Core 5.0 | 18.70 μs | 0.134 μs | 0.125 μs |   1.32 KB |  8.4534 | 1.0376 |     - |  39.12 KB |
