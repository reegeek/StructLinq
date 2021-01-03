## Aggregate

### Source
[Aggregate.cs](../../src/StructLinq.Benchmark/Aggregate.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                   Method |      Mean |     Error |    StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated | Code Size |
|------------------------- |----------:|----------:|----------:|------:|------:|------:|------:|----------:|----------:|
|             SysAggregate | 50.596 μs | 0.7067 μs | 0.6610 μs |  1.00 |     - |     - |     - |      40 B |     387 B |
|        DelegateAggregate | 15.115 μs | 0.1654 μs | 0.1548 μs |  0.30 |     - |     - |     - |      24 B |     208 B |
|          StructAggregate |  5.030 μs | 0.0277 μs | 0.0259 μs |  0.10 |     - |     - |     - |      24 B |      74 B |
| ZeroAllocStructAggregate | 13.445 μs | 0.0282 μs | 0.0264 μs |  0.27 |     - |     - |     - |         - |     173 B |
|         ConvertAggregate | 40.073 μs | 0.2062 μs | 0.1828 μs |  0.79 |     - |     - |     - |      64 B |     131 B |
