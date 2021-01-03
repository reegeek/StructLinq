## Except

### Source
[Except.cs](../../src/StructLinq.Benchmark/Except.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                         Method |     Mean |   Error |  StdDev | Ratio |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
|------------------------------- |---------:|--------:|--------:|------:|--------:|--------:|--------:|----------:|
|                           Linq | 331.1 μs | 1.51 μs | 1.41 μs |  1.00 | 90.8203 | 90.8203 | 90.8203 |  524848 B |
|                     StructLinq | 142.5 μs | 0.68 μs | 0.63 μs |  0.43 |       - |       - |       - |      64 B |
|            StructLinqZeroAlloc | 155.3 μs | 0.60 μs | 0.53 μs |  0.47 |       - |       - |       - |         - |
| StructLinqZeroAllocAndComparer | 118.3 μs | 0.29 μs | 0.25 μs |  0.36 |       - |       - |       - |         - |
