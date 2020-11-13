## Distinct

### Source
[Distinct.cs](../../src/StructLinq.Benchmark/Distinct.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|                 Method |     Mean |   Error |  StdDev | Ratio |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
|----------------------- |---------:|--------:|--------:|------:|--------:|--------:|--------:|----------:|
|                   Linq | 486.1 μs | 1.64 μs | 1.45 μs |  1.00 | 90.8203 | 90.8203 | 90.8203 |  524784 B |
|             StructLinq | 174.1 μs | 0.72 μs | 0.68 μs |  0.36 |       - |       - |       - |      32 B |
|    StructLinqZeroAlloc | 176.2 μs | 0.92 μs | 0.82 μs |  0.36 |       - |       - |       - |         - |
| StructLinqZeroAllocSum | 183.5 μs | 0.77 μs | 0.68 μs |  0.38 |       - |       - |       - |         - |
