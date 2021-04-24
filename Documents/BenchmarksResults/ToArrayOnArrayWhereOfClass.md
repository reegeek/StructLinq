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
|                   Linq |  59.35 μs | 0.443 μs | 0.393 μs |  1.00 |    0.00 | 22.4609 | 5.6152 |     - | 103.73 KB |
|             StructLinq | 121.58 μs | 0.616 μs | 0.481 μs |  2.05 |    0.02 |  8.3008 | 0.9766 |     - |  39.15 KB |
|    StructLinqZeroAlloc | 111.41 μs | 0.519 μs | 0.485 μs |  1.88 |    0.01 |  8.4229 | 0.9766 |     - |  39.09 KB |
| StructLinqWithFunction |  87.99 μs | 0.383 μs | 0.359 μs |  1.48 |    0.01 |  8.4229 | 0.9766 |     - |  39.09 KB |
