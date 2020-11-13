## ToArrayOnArraySelect

### Source
[ToArrayOnArraySelect.cs](../../src/StructLinq.Benchmark/ToArrayOnArraySelect.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|           Method |     Mean |    Error |   StdDev | Ratio |  Gen 0 |  Gen 1 | Gen 2 | Allocated | Code Size |
|----------------- |---------:|---------:|---------:|------:|-------:|-------:|------:|----------:|----------:|
|             Linq | 16.38 μs | 0.098 μs | 0.092 μs |  1.00 | 8.4534 | 1.0376 |     - |  39.13 KB |   0.96 KB |
|       StructLinq | 22.07 μs | 0.079 μs | 0.074 μs |  1.35 | 8.4534 | 1.0376 |     - |  39.12 KB |   0.43 KB |
| StructLinqFaster | 17.50 μs | 0.066 μs | 0.059 μs |  1.07 | 8.4534 | 1.0376 |     - |  39.09 KB |   0.74 KB |
