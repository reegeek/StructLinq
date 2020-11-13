## ToListOnArrayWhere

### Source
[ToListOnArrayWhere.cs](../../src/StructLinq.Benchmark/ToListOnArrayWhere.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|           Method |     Mean |    Error |   StdDev | Ratio |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|----------------- |---------:|---------:|---------:|------:|--------:|-------:|------:|----------:|
|             Linq | 30.38 μs | 0.098 μs | 0.087 μs |  1.00 | 13.9771 | 2.7466 |     - |  64.34 KB |
|       StructLinq | 28.00 μs | 0.176 μs | 0.156 μs |  0.92 |  4.2419 | 0.2747 |     - |  19.65 KB |
| StructLinqFaster | 20.16 μs | 0.124 μs | 0.104 μs |  0.66 |  4.2419 | 0.2747 |     - |  19.59 KB |
