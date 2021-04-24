## ToArrayOnArrayWhere

### Source
[ToArrayOnArrayWhere.cs](../../src/StructLinq.Benchmark/ToArrayOnArrayWhere.cs)

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
|                   Linq | 24.99 μs | 0.122 μs | 0.108 μs |  1.00 | 11.3220 | 1.4038 |     - |  52.19 KB |
|             StructLinq | 32.34 μs | 0.259 μs | 0.242 μs |  1.29 |  4.2114 | 0.2441 |     - |  19.62 KB |
|    StructLinqZeroAlloc | 26.59 μs | 0.140 μs | 0.131 μs |  1.06 |  4.2114 | 0.2747 |     - |  19.55 KB |
| StructLinqWithFunction | 11.46 μs | 0.034 μs | 0.028 μs |  0.46 |  4.2267 | 0.2747 |     - |  19.55 KB |
