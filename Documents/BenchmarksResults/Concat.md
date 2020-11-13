## Concat

### Source
[Concat.cs](../../src/StructLinq.Benchmark/Concat.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|              Method |     Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |---------:|---------:|---------:|------:|------:|------:|------:|----------:|
|                Linq | 82.01 μs | 0.435 μs | 0.407 μs |  1.00 |     - |     - |     - |     120 B |
|          StructLinq | 18.22 μs | 0.076 μs | 0.067 μs |  0.22 |     - |     - |     - |      64 B |
| StructLinqZeroAlloc | 17.57 μs | 0.068 μs | 0.063 μs |  0.21 |     - |     - |     - |         - |
