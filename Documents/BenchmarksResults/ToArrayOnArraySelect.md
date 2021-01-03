## ToArrayOnArraySelect

### Source
[ToArrayOnArraySelect.cs](../../src/StructLinq.Benchmark/ToArrayOnArraySelect.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                 Method |      Mean |     Error |    StdDev | Ratio | Code Size |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|----------------------- |----------:|----------:|----------:|------:|----------:|-------:|-------:|------:|----------:|
|                   Linq | 16.450 μs | 0.1017 μs | 0.0951 μs |  1.00 |   0.96 KB | 8.4534 | 1.0376 |     - |  39.13 KB |
|             StructLinq | 16.355 μs | 0.1310 μs | 0.1162 μs |  0.99 |   0.42 KB | 8.4534 | 1.0376 |     - |  39.15 KB |
|    StructLinqZeroAlloc | 18.733 μs | 0.0474 μs | 0.0370 μs |  1.14 |   0.58 KB | 8.4534 | 1.0376 |     - |  39.12 KB |
| StructLinqWithFunction |  7.585 μs | 0.0283 μs | 0.0250 μs |  0.46 |   0.78 KB | 8.4686 | 1.0529 |     - |  39.09 KB |
