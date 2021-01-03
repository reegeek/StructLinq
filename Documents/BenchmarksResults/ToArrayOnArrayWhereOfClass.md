## ToArrayOnArrayWhereOfClass

### Source
[ToArrayOnArrayWhereOfClass.cs](../../src/StructLinq.Benchmark/ToArrayOnArrayWhereOfClass.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                 Method |      Mean |    Error |   StdDev | Ratio |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|----------------------- |----------:|---------:|---------:|------:|--------:|-------:|------:|----------:|
|                   Linq |  64.38 μs | 0.495 μs | 0.413 μs |  1.00 | 22.4609 | 5.6152 |     - | 103.73 KB |
|             StructLinq | 109.23 μs | 0.397 μs | 0.352 μs |  1.70 |  8.4229 | 0.9766 |     - |  39.15 KB |
|    StructLinqZeroAlloc | 108.44 μs | 0.659 μs | 0.617 μs |  1.69 |  8.4229 | 0.9766 |     - |  39.09 KB |
| StructLinqWithFunction |  92.31 μs | 0.396 μs | 0.351 μs |  1.43 |  8.4229 | 0.9766 |     - |  39.09 KB |
