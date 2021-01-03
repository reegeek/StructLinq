## ToArrayOnArrayWhere

### Source
[ToArrayOnArrayWhere.cs](../../src/StructLinq.Benchmark/ToArrayOnArrayWhere.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                 Method |     Mean |    Error |   StdDev | Ratio |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|----------------------- |---------:|---------:|---------:|------:|--------:|-------:|------:|----------:|
|                   Linq | 26.40 μs | 0.166 μs | 0.147 μs |  1.00 | 11.3220 | 1.4038 |     - |  52.19 KB |
|             StructLinq | 27.52 μs | 0.096 μs | 0.090 μs |  1.04 |  4.2419 | 0.2747 |     - |  19.62 KB |
|    StructLinqZeroAlloc | 25.91 μs | 0.092 μs | 0.086 μs |  0.98 |  4.2114 | 0.2747 |     - |  19.55 KB |
| StructLinqWithFunction | 11.43 μs | 0.052 μs | 0.049 μs |  0.43 |  4.2267 | 0.2747 |     - |  19.55 KB |
