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
|           Method |     Mean |    Error |   StdDev | Ratio | RatioSD |   Gen 0 |  Gen 1 |  Gen 2 | Allocated |
|----------------- |---------:|---------:|---------:|------:|--------:|--------:|-------:|-------:|----------:|
|             Linq | 28.19 μs | 0.540 μs | 0.505 μs |  1.00 |    0.00 | 11.3220 | 1.4038 |      - |  52.19 KB |
|       StructLinq | 25.55 μs | 0.358 μs | 0.317 μs |  0.91 |    0.02 |  4.2419 | 0.3052 | 0.1526 |  19.63 KB |
| StructLinqFaster | 12.24 μs | 0.123 μs | 0.115 μs |  0.43 |    0.01 |  4.2267 | 0.2747 |      - |  19.56 KB |
