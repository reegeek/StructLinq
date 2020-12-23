## ToListComparison

### Source
[ToListComparison.cs](../../src/StructLinq.Benchmark/ToListComparison.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.101
  [Host]        : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4250.0), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.10 (CoreCLR 4.700.20.51601, CoreFX 4.700.20.51901), X64 RyuJIT


```
|                      Method |           Job |       Runtime |     Mean |    Error |   StdDev | Code Size |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|---------------------------- |-------------- |-------------- |---------:|---------:|---------:|----------:|--------:|-------:|------:|----------:|
|                   AddInList |      .NET 4.8 |      .NET 4.8 | 40.57 μs | 0.794 μs | 0.779 μs |   0.54 KB | 31.1890 | 0.0610 |     - | 128.48 KB |
|          ToArrayThenNewList |      .NET 4.8 |      .NET 4.8 | 36.83 μs | 0.327 μs | 0.273 μs |   2.77 KB | 19.0430 | 0.0610 |     - |  78.37 KB |
| ToArrayThenNewListAndLayout |      .NET 4.8 |      .NET 4.8 | 35.33 μs | 0.704 μs | 1.269 μs |   2.98 KB | 19.0430 | 3.1738 |     - |  78.37 KB |
|                 WithVisitor |      .NET 4.8 |      .NET 4.8 | 24.82 μs | 0.276 μs | 0.258 μs |   1.72 KB |  9.5215 |      - |     - |  39.19 KB |
|                   AddInList | .NET Core 3.1 | .NET Core 3.1 | 35.36 μs | 0.434 μs | 0.406 μs |   0.43 KB | 31.2195 | 7.7820 |     - | 128.32 KB |
|          ToArrayThenNewList | .NET Core 3.1 | .NET Core 3.1 | 38.70 μs | 0.281 μs | 0.263 μs |   1.19 KB | 19.0430 | 3.7842 |     - |   78.2 KB |
| ToArrayThenNewListAndLayout | .NET Core 3.1 | .NET Core 3.1 | 36.82 μs | 0.313 μs | 0.293 μs |   0.82 KB | 19.0430 | 3.1738 |     - |   78.2 KB |
|                 WithVisitor | .NET Core 3.1 | .NET Core 3.1 | 25.79 μs | 0.159 μs | 0.141 μs |   0.77 KB |  9.5215 | 1.1902 |     - |  39.12 KB |
