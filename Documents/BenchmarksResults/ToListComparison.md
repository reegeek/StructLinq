## ToListComparison

### Source
[ToListComparison.cs](../../src/StructLinq.Benchmark/ToListComparison.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.202
  [Host]        : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4341.0), X64 RyuJIT
  .NET Core 5.0 : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT


```
|                      Method |           Job |       Runtime |     Mean |    Error |   StdDev | Code Size |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|---------------------------- |-------------- |-------------- |---------:|---------:|---------:|----------:|--------:|-------:|------:|----------:|
|                   AddInList |      .NET 4.8 |      .NET 4.8 | 27.49 μs | 0.221 μs | 0.184 μs |   0.54 KB | 27.7710 | 0.0305 |     - | 128.48 KB |
|          ToArrayThenNewList |      .NET 4.8 |      .NET 4.8 | 27.04 μs | 0.196 μs | 0.153 μs |   2.77 KB | 16.9373 | 0.0305 |     - |  78.35 KB |
| ToArrayThenNewListAndLayout |      .NET 4.8 |      .NET 4.8 | 25.55 μs | 0.108 μs | 0.101 μs |   2.98 KB | 16.9373 | 0.0305 |     - |  78.35 KB |
|                 WithVisitor |      .NET 4.8 |      .NET 4.8 | 19.86 μs | 0.105 μs | 0.082 μs |   1.72 KB |  8.4534 | 0.0305 |     - |  39.18 KB |
|                   AddInList | .NET Core 5.0 | .NET Core 5.0 | 20.22 μs | 0.178 μs | 0.166 μs |   0.62 KB | 27.7710 | 9.2468 |     - | 128.32 KB |
|          ToArrayThenNewList | .NET Core 5.0 | .NET Core 5.0 | 22.28 μs | 0.118 μs | 0.110 μs |    1.8 KB | 16.9373 | 2.1057 |     - |   78.2 KB |
| ToArrayThenNewListAndLayout | .NET Core 5.0 | .NET Core 5.0 | 21.00 μs | 0.079 μs | 0.070 μs |   1.46 KB | 16.9373 | 2.1057 |     - |   78.2 KB |
|                 WithVisitor | .NET Core 5.0 | .NET Core 5.0 | 19.42 μs | 0.100 μs | 0.088 μs |   1.39 KB |  8.4534 | 1.0376 |     - |  39.12 KB |
