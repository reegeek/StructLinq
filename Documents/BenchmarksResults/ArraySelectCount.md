## ArraySelectCount

### Source
[ArraySelectCount.cs](../../src/StructLinq.Benchmark/ArraySelectCount.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|              Method |     Mean |    Error |   StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |---------:|---------:|---------:|------:|------:|------:|----------:|
|                Linq | 17.86 μs | 0.107 μs | 0.100 μs |     - |     - |     - |      48 B |
|          StructLinq | 13.46 μs | 0.069 μs | 0.065 μs |     - |     - |     - |      64 B |
| StructLinqZeroAlloc | 13.37 μs | 0.055 μs | 0.049 μs |     - |     - |     - |         - |
