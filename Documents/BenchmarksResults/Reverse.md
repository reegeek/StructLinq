## Reverse

### Source
[Reverse.cs](../../src/StructLinq.Benchmark/Reverse.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|              Method |     Mean |    Error |   StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |---------:|---------:|---------:|------:|-------:|------:|------:|----------:|
|                Linq | 50.89 μs | 0.368 μs | 0.344 μs |  1.00 | 8.4229 |     - |     - |   40072 B |
|          StructLinq | 15.23 μs | 0.071 μs | 0.066 μs |  0.30 |      - |     - |     - |      32 B |
| StructLinqZeroAlloc | 15.37 μs | 0.069 μs | 0.064 μs |  0.30 |      - |     - |     - |         - |
