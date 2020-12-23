## ToArrayOnArrayWhereOfClass

### Source
[ToArrayOnArrayWhereOfClass.cs](../../src/StructLinq.Benchmark/ToArrayOnArrayWhereOfClass.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                 Method |      Mean |    Error |   StdDev | Ratio | RatioSD |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|----------------------- |----------:|---------:|---------:|------:|--------:|--------:|-------:|------:|----------:|
|                   Linq |  88.43 μs | 0.446 μs | 0.418 μs |  1.00 |    0.00 | 25.2686 | 6.2256 |     - | 103.73 KB |
|             StructLinq | 137.20 μs | 2.045 μs | 1.707 μs |  1.55 |    0.02 |  9.5215 | 0.9766 |     - |  39.15 KB |
|    StructLinqZeroAlloc | 134.83 μs | 1.592 μs | 1.490 μs |  1.52 |    0.02 |  9.5215 | 0.9766 |     - |  39.09 KB |
| StructLinqWithFunction | 108.88 μs | 1.301 μs | 1.016 μs |  1.23 |    0.01 |  9.5215 | 1.0986 |     - |  39.09 KB |
