## Distinct

### Source
[Distinct.cs](../../src/StructLinq.Benchmark/Distinct.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                 Method |     Mean |   Error |  StdDev | Ratio |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
|----------------------- |---------:|--------:|--------:|------:|--------:|--------:|--------:|----------:|
|                   Linq | 485.9 μs | 2.88 μs | 2.70 μs |  1.00 | 90.8203 | 90.8203 | 90.8203 |  524784 B |
|             StructLinq | 176.9 μs | 3.32 μs | 3.41 μs |  0.36 |       - |       - |       - |      32 B |
|    StructLinqZeroAlloc | 173.8 μs | 0.75 μs | 0.70 μs |  0.36 |       - |       - |       - |         - |
| StructLinqZeroAllocSum | 160.3 μs | 0.57 μs | 0.53 μs |  0.33 |       - |       - |       - |         - |
