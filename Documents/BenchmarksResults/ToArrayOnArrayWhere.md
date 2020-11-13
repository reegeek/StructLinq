## ToArrayOnArrayWhere

### Source
[ToArrayOnArrayWhere.cs](../../src/StructLinq.Benchmark/ToArrayOnArrayWhere.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|           Method |     Mean |    Error |   StdDev | Ratio |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|----------------- |---------:|---------:|---------:|------:|--------:|-------:|------:|----------:|
|             Linq | 32.18 μs | 0.119 μs | 0.105 μs |  1.00 | 11.2915 | 1.4038 |     - |  52.19 KB |
|       StructLinq | 31.41 μs | 0.241 μs | 0.225 μs |  0.98 |  4.2114 | 0.2441 |     - |  19.62 KB |
| StructLinqFaster | 22.42 μs | 0.078 μs | 0.073 μs |  0.70 |  4.2114 | 0.2747 |     - |  19.55 KB |
