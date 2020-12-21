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
|                 Method |      Mean |     Error |    StdDev | Ratio |  Gen 0 |  Gen 1 | Gen 2 | Allocated | Code Size |
|----------------------- |----------:|----------:|----------:|------:|-------:|-------:|------:|----------:|----------:|
|                   Linq | 17.323 μs | 0.0437 μs | 0.0387 μs |  1.00 | 8.4534 | 1.0376 |     - |  39.13 KB |   0.96 KB |
|             StructLinq | 22.315 μs | 0.0273 μs | 0.0228 μs |  1.29 | 8.4534 | 1.0376 |     - |  39.15 KB |   0.42 KB |
|       StructLinqFaster | 22.256 μs | 0.0598 μs | 0.0530 μs |  1.28 | 8.4534 | 1.0376 |     - |  39.12 KB |   0.58 KB |
| StructLinqWithFunction |  8.443 μs | 0.0467 μs | 0.0365 μs |  0.49 | 8.4686 | 1.0529 |     - |  39.09 KB |   0.78 KB |
