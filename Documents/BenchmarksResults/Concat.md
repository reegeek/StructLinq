## Concat

### Source
[Concat.cs](../../src/StructLinq.Benchmark/Concat.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|              Method |     Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |---------:|---------:|---------:|------:|------:|------:|------:|----------:|
|                Linq | 80.56 μs | 0.346 μs | 0.289 μs |  1.00 |     - |     - |     - |     120 B |
|          StructLinq | 18.12 μs | 0.030 μs | 0.024 μs |  0.22 |     - |     - |     - |      64 B |
| StructLinqZeroAlloc | 18.39 μs | 0.249 μs | 0.233 μs |  0.23 |     - |     - |     - |         - |
