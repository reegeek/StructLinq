## ToListOnArrayWhere

### Source
[ToListOnArrayWhere.cs](../../src/StructLinq.Benchmark/ToListOnArrayWhere.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                 Method |     Mean |    Error |   StdDev | Ratio |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|----------------------- |---------:|---------:|---------:|------:|--------:|-------:|------:|----------:|
|                   Linq | 40.79 μs | 0.252 μs | 0.224 μs |  1.00 | 15.6860 | 0.1221 |     - |  64.34 KB |
|             StructLinq | 32.81 μs | 0.165 μs | 0.138 μs |  0.80 |  4.7607 |      - |     - |  19.65 KB |
|    StructLinqZeroAlloc | 31.71 μs | 0.124 μs | 0.116 μs |  0.78 |  4.7607 |      - |     - |  19.59 KB |
| StructLinqWithFunction | 15.64 μs | 0.104 μs | 0.087 μs |  0.38 |  4.7760 |      - |     - |  19.59 KB |
