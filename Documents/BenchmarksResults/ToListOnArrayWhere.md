## ToListOnArrayWhere

### Source
[ToListOnArrayWhere.cs](../../src/StructLinq.Benchmark/ToListOnArrayWhere.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
  DefaultJob : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT


```
|                 Method |     Mean |    Error |   StdDev | Ratio |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|----------------------- |---------:|---------:|---------:|------:|--------:|-------:|------:|----------:|
|                   Linq | 30.47 μs | 0.149 μs | 0.139 μs |  1.00 | 13.9771 | 2.7771 |     - |  64.34 KB |
|             StructLinq | 28.19 μs | 0.094 μs | 0.087 μs |  0.93 |  4.2419 | 0.2747 |     - |  19.65 KB |
|    StructLinqZeroAlloc | 26.52 μs | 0.125 μs | 0.117 μs |  0.87 |  4.2419 | 0.2747 |     - |  19.59 KB |
| StructLinqWithFunction | 11.47 μs | 0.029 μs | 0.027 μs |  0.38 |  4.2419 | 0.2747 |     - |  19.59 KB |
