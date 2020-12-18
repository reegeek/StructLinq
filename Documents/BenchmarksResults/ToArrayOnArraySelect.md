## ToArrayOnArraySelect

### Source
[ToArrayOnArraySelect.cs](../../src/StructLinq.Benchmark/ToArrayOnArraySelect.cs)

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
|                   Linq | 22.55 μs | 0.293 μs | 0.274 μs |  1.00 |    0.00 | 9.5215 | 0.0305 |     - |  39.13 KB |   0.96 KB |
|             StructLinq | 25.62 μs | 0.391 μs | 0.366 μs |  1.14 |    0.02 | 9.5215 | 0.0305 |     - |  39.12 KB |    0.4 KB |
|       StructLinqFaster | 25.44 μs | 0.294 μs | 0.275 μs |  1.13 |    0.02 | 9.5215 | 0.0305 |     - |  39.12 KB |    0.5 KB |
| StructLinqWithFunction | 23.60 μs | 0.175 μs | 0.146 μs |  1.05 |    0.01 | 9.5215 | 0.0305 |     - |  39.09 KB |   0.74 KB |
