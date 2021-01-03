## ImmutableArrayWhereSelectSum

### Source
[ImmutableArrayWhereSelectSum.cs](../../src/StructLinq.Benchmark/ImmutableArrayWhereSelectSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|             Method |     Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------- |---------:|---------:|---------:|------:|------:|------:|------:|----------:|
|               LINQ | 46.70 μs | 0.200 μs | 0.167 μs |  1.00 |     - |     - |     - |     104 B |
|         StructLinq | 41.55 μs | 0.444 μs | 0.416 μs |  0.89 |     - |     - |     - |         - |
| StructLinqFunction | 22.16 μs | 0.218 μs | 0.204 μs |  0.48 |     - |     - |     - |         - |
