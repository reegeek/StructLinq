## Intersect

### Source
[Intersect.cs](../../src/StructLinq.Benchmark/Intersect.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                         Method |      Mean |    Error |   StdDev | Ratio |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
|------------------------------- |----------:|---------:|---------:|------:|--------:|--------:|--------:|----------:|
|                           Linq | 194.89 μs | 0.749 μs | 0.664 μs |  1.00 | 62.2559 | 31.0059 | 31.0059 |  262664 B |
|                     StructLinq | 105.17 μs | 0.341 μs | 0.319 μs |  0.54 |       - |       - |       - |      64 B |
|            StructLinqZeroAlloc | 107.99 μs | 0.240 μs | 0.187 μs |  0.55 |       - |       - |       - |         - |
| StructLinqZeroAllocAndComparer |  83.26 μs | 0.353 μs | 0.330 μs |  0.43 |       - |       - |       - |         - |
