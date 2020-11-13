## ImmutableArrayWhereSelectSum

### Source
[ImmutableArrayWhereSelectSum.cs](../../src/StructLinq.Benchmark/ImmutableArrayWhereSelectSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|             Method |     Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------- |---------:|---------:|---------:|------:|------:|------:|------:|----------:|
|               LINQ | 48.83 μs | 0.232 μs | 0.205 μs |  1.00 |     - |     - |     - |     104 B |
|         StructLinq | 48.67 μs | 0.259 μs | 0.242 μs |  1.00 |     - |     - |     - |         - |
| StructLinqFunction | 36.21 μs | 0.225 μs | 0.211 μs |  0.74 |     - |     - |     - |         - |
