## ToArrayOnArraySelect

### Source
[ToArrayOnArraySelect.cs](../../src/StructLinq.Benchmark/ToArrayOnArraySelect.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|           Method |     Mean |    Error |   StdDev | Ratio | Code Size |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|----------------- |---------:|---------:|---------:|------:|----------:|-------:|-------:|------:|----------:|
|             Linq | 17.07 μs | 0.058 μs | 0.054 μs |  1.00 |   0.96 KB | 8.4534 | 1.0376 |     - |  39.13 KB |
|       StructLinq | 30.48 μs | 0.141 μs | 0.117 μs |  1.79 |   1.52 KB | 8.4534 | 0.0305 |     - |  39.15 KB |
| StructLinqFaster | 18.31 μs | 0.083 μs | 0.077 μs |  1.07 |   0.74 KB | 8.4534 | 1.0376 |     - |  39.09 KB |
