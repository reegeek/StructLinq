## ToArrayOnArraySelectOfClass

### Source
[ToArrayOnArraySelectOfClass.cs](../../src/StructLinq.Benchmark/ToArrayOnArraySelectOfClass.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                 Method |     Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 |  Gen 1 | Gen 2 | Allocated | Code Size |
|----------------------- |---------:|---------:|---------:|------:|--------:|-------:|-------:|------:|----------:|----------:|
|                   Linq | 31.76 μs | 0.539 μs | 0.477 μs |  1.00 |    0.00 | 9.5215 | 1.1902 |     - |  39.13 KB |   0.05 KB |
|             StructLinq | 31.56 μs | 0.315 μs | 0.295 μs |  0.99 |    0.02 | 9.5215 | 1.1902 |     - |  39.15 KB |   0.44 KB |
|    StructLinqZeroAlloc | 34.57 μs | 0.637 μs | 0.497 μs |  1.09 |    0.02 | 9.5215 | 1.1597 |     - |  39.09 KB |   0.05 KB |
| StructLinqWithFunction | 13.82 μs | 0.214 μs | 0.189 μs |  0.44 |    0.01 | 9.5215 | 1.1902 |     - |  39.09 KB |   0.05 KB |
