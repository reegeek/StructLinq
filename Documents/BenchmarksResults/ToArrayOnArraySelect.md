## ToArrayOnArraySelect

### Source
[ToArrayOnArraySelect.cs](../../src/StructLinq.Benchmark/ToArrayOnArraySelect.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
  DefaultJob : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT


```
|                 Method |      Mean |     Error |    StdDev | Ratio |  Gen 0 |  Gen 1 | Gen 2 | Allocated | Code Size |
|----------------------- |----------:|----------:|----------:|------:|-------:|-------:|------:|----------:|----------:|
|                   Linq | 16.353 μs | 0.0435 μs | 0.0340 μs |  1.00 | 8.4534 | 1.0376 |     - |  39.13 KB |   0.96 KB |
|             StructLinq | 16.378 μs | 0.0595 μs | 0.0556 μs |  1.00 | 8.4534 | 1.0376 |     - |  39.15 KB |   0.42 KB |
|    StructLinqZeroAlloc | 18.904 μs | 0.1015 μs | 0.0950 μs |  1.16 | 8.4534 | 1.0376 |     - |  39.12 KB |   0.58 KB |
| StructLinqWithFunction |  7.727 μs | 0.0387 μs | 0.0362 μs |  0.47 | 8.4686 | 1.0529 |     - |  39.09 KB |   0.78 KB |
