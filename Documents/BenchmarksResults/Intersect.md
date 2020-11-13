## Intersect

### Source
[Intersect.cs](../../src/StructLinq.Benchmark/Intersect.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|                         Method |      Mean |    Error |   StdDev | Ratio |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
|------------------------------- |----------:|---------:|---------:|------:|--------:|--------:|--------:|----------:|
|                           Linq | 194.72 μs | 1.162 μs | 1.030 μs |  1.00 | 62.2559 | 31.0059 | 31.0059 |  262664 B |
|                     StructLinq | 109.28 μs | 0.665 μs | 0.622 μs |  0.56 |       - |       - |       - |      64 B |
|            StructLinqZeroAlloc | 108.94 μs | 0.572 μs | 0.535 μs |  0.56 |       - |       - |       - |         - |
| StructLinqZeroAllocAndComparer |  82.89 μs | 0.317 μs | 0.297 μs |  0.43 |       - |       - |       - |         - |
