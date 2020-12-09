## ImmutableArrayWhereSelectSum

### Source
[ImmutableArrayWhereSelectSum.cs](../../src/StructLinq.Benchmark/ImmutableArrayWhereSelectSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 3.1.10 (CoreCLR 4.700.20.51601, CoreFX 4.700.20.51901), X64 RyuJIT
  DefaultJob : .NET Core 3.1.10 (CoreCLR 4.700.20.51601, CoreFX 4.700.20.51901), X64 RyuJIT


```
|             Method |     Mean |    Error |   StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------- |---------:|---------:|---------:|------:|--------:|------:|------:|------:|----------:|
|               LINQ | 49.04 μs | 0.481 μs | 0.376 μs |  1.00 |    0.00 |     - |     - |     - |     104 B |
|         StructLinq | 73.57 μs | 1.075 μs | 0.953 μs |  1.50 |    0.02 |     - |     - |     - |         - |
| StructLinqFunction | 37.30 μs | 0.707 μs | 0.756 μs |  0.76 |    0.01 |     - |     - |     - |         - |
