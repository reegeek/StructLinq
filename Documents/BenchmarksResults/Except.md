## Except

### Source
[Except.cs](../../src/StructLinq.Benchmark/Except.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|                         Method |     Mean |   Error |  StdDev | Ratio |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
|------------------------------- |---------:|--------:|--------:|------:|--------:|--------:|--------:|----------:|
|                           Linq | 332.2 μs | 2.76 μs | 2.58 μs |  1.00 | 90.8203 | 90.8203 | 90.8203 |  524848 B |
|                     StructLinq | 154.3 μs | 0.71 μs | 0.66 μs |  0.46 |       - |       - |       - |      64 B |
|            StructLinqZeroAlloc | 154.2 μs | 0.64 μs | 0.56 μs |  0.46 |       - |       - |       - |         - |
| StructLinqZeroAllocAndComparer | 119.7 μs | 0.42 μs | 0.39 μs |  0.36 |       - |       - |       - |         - |
