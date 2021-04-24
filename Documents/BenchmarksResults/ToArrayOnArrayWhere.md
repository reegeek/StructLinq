## ToArrayOnArrayWhere

### Source
[ToArrayOnArrayWhere.cs](../../src/StructLinq.Benchmark/ToArrayOnArrayWhere.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
  DefaultJob : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT


```
|                 Method |     Mean |    Error |   StdDev | Ratio |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|----------------------- |---------:|---------:|---------:|------:|--------:|-------:|------:|----------:|
|                   Linq | 24.80 μs | 0.136 μs | 0.128 μs |  1.00 | 11.3220 | 1.4038 |     - |  52.19 KB |
|             StructLinq | 25.10 μs | 0.069 μs | 0.061 μs |  1.01 |  4.2419 | 0.2747 |     - |  19.62 KB |
|    StructLinqZeroAlloc | 27.87 μs | 0.170 μs | 0.159 μs |  1.12 |  4.2114 | 0.2747 |     - |  19.55 KB |
| StructLinqWithFunction | 11.15 μs | 0.065 μs | 0.057 μs |  0.45 |  4.2267 | 0.2747 |     - |  19.55 KB |
