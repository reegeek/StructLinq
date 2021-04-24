## ToArrayOnArrayWhereOfClass

### Source
[ToArrayOnArrayWhereOfClass.cs](../../src/StructLinq.Benchmark/ToArrayOnArrayWhereOfClass.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
  DefaultJob : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT


```
|                 Method |      Mean |    Error |   StdDev | Ratio | RatioSD |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|----------------------- |----------:|---------:|---------:|------:|--------:|--------:|-------:|------:|----------:|
|                   Linq |  59.20 μs | 0.296 μs | 0.247 μs |  1.00 |    0.00 | 22.4609 | 5.6152 |     - | 103.73 KB |
|             StructLinq | 106.67 μs | 0.345 μs | 0.323 μs |  1.80 |    0.01 |  8.4229 | 0.9766 |     - |  39.15 KB |
|    StructLinqZeroAlloc | 109.09 μs | 0.883 μs | 0.826 μs |  1.84 |    0.02 |  8.4229 | 0.9766 |     - |  39.09 KB |
| StructLinqWithFunction | 100.58 μs | 0.640 μs | 0.567 μs |  1.70 |    0.01 |  8.4229 | 0.9766 |     - |  39.09 KB |
