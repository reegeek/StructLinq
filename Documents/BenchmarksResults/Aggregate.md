## Aggregate

### Source
[Aggregate.cs](../../src/StructLinq.Benchmark/Aggregate.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|                   Method |      Mean |     Error |    StdDev | Ratio | Code Size | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------- |----------:|----------:|----------:|------:|----------:|------:|------:|------:|----------:|
|             SysAggregate | 53.261 μs | 0.1862 μs | 0.1742 μs |  1.00 |     387 B |     - |     - |     - |      40 B |
|        DelegateAggregate | 15.117 μs | 0.0396 μs | 0.0371 μs |  0.28 |     208 B |     - |     - |     - |      24 B |
|          StructAggregate |  5.061 μs | 0.0157 μs | 0.0139 μs |  0.10 |      74 B |     - |     - |     - |      24 B |
| ZeroAllocStructAggregate | 13.567 μs | 0.0488 μs | 0.0457 μs |  0.25 |     165 B |     - |     - |     - |         - |
|         ConvertAggregate | 40.415 μs | 0.1535 μs | 0.1436 μs |  0.76 |     131 B |     - |     - |     - |      64 B |
