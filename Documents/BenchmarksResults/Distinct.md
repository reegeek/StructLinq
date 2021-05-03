## Distinct

### Source
[Distinct.cs](../../src/StructLinq.Benchmark/Distinct.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
  DefaultJob : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT


```
|                 Method |     Mean |   Error |  StdDev | Ratio |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
|----------------------- |---------:|--------:|--------:|------:|--------:|--------:|--------:|----------:|
|                   Linq | 544.3 μs | 7.98 μs | 7.08 μs |  1.00 | 90.8203 | 90.8203 | 90.8203 |  524784 B |
|             StructLinq | 215.7 μs | 2.56 μs | 2.14 μs |  0.40 |       - |       - |       - |      32 B |
|    StructLinqZeroAlloc | 220.7 μs | 0.77 μs | 0.64 μs |  0.41 |       - |       - |       - |         - |
| StructLinqZeroAllocSum | 152.6 μs | 0.53 μs | 0.44 μs |  0.28 |       - |       - |       - |         - |
