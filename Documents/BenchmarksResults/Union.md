## Union

### Source
[Union.cs](../../src/StructLinq.Benchmark/Union.cs)

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
|                           Linq | 360.7 μs | 1.89 μs | 1.77 μs |  1.00 | 90.8203 | 90.8203 | 90.8203 |  524824 B |
|                     StructLinq | 163.5 μs | 0.78 μs | 0.73 μs |  0.45 |       - |       - |       - |      64 B |
|            StructLinqZeroAlloc | 158.8 μs | 0.72 μs | 0.60 μs |  0.44 |       - |       - |       - |         - |
| StructLinqZeroAllocAndComparer | 121.4 μs | 0.47 μs | 0.44 μs |  0.34 |       - |       - |       - |         - |
