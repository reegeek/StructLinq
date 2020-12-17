## ToArrayOnArraySelectOfClass

### Source
[ToArrayOnArraySelectOfClass.cs](../../src/StructLinq.Benchmark/ToArrayOnArraySelectOfClass.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|           Method |     Mean |    Error |   StdDev | Ratio | RatioSD | Code Size |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|----------------- |---------:|---------:|---------:|------:|--------:|----------:|-------:|-------:|------:|----------:|
|             Linq | 22.50 μs | 0.077 μs | 0.072 μs |  1.00 |    0.00 |   0.15 KB | 8.4534 | 1.0376 |     - |  39.13 KB |
|       StructLinq | 34.01 μs | 0.340 μs | 0.392 μs |  1.51 |    0.02 |   0.05 KB | 8.4229 | 0.0610 |     - |  39.16 KB |
| StructLinqFaster | 17.36 μs | 0.091 μs | 0.085 μs |  0.77 |    0.00 |   0.05 KB | 8.4534 | 1.0376 |     - |  39.09 KB |
