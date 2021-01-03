## Union

### Source
[Union.cs](../../src/StructLinq.Benchmark/Union.cs)

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
|                           Linq | 347.2 μs | 2.02 μs | 1.88 μs |  1.00 | 90.8203 | 90.8203 | 90.8203 |  524824 B |
|                     StructLinq | 155.0 μs | 0.73 μs | 0.68 μs |  0.45 |       - |       - |       - |      64 B |
|            StructLinqZeroAlloc | 155.6 μs | 0.47 μs | 0.41 μs |  0.45 |       - |       - |       - |         - |
| StructLinqZeroAllocAndComparer | 121.2 μs | 0.43 μs | 0.40 μs |  0.35 |       - |       - |       - |         - |
