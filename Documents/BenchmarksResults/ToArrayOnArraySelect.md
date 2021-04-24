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
|                 Method |     Mean |    Error |   StdDev | Ratio | Code Size |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|----------------------- |---------:|---------:|---------:|------:|----------:|-------:|-------:|------:|----------:|
|                   Linq | 18.95 μs | 0.081 μs | 0.072 μs |  1.00 |   0.96 KB | 8.4534 | 1.0376 |     - |  39.13 KB |
|             StructLinq | 18.33 μs | 0.128 μs | 0.113 μs |  0.97 |   0.51 KB | 8.4534 | 1.0376 |     - |  39.15 KB |
|    StructLinqZeroAlloc | 20.81 μs | 0.108 μs | 0.090 μs |  1.10 |   0.66 KB | 8.4534 | 1.0376 |     - |  39.12 KB |
| StructLinqWithFunction | 10.48 μs | 0.035 μs | 0.031 μs |  0.55 |   0.87 KB | 8.4686 | 1.0529 |     - |  39.09 KB |
