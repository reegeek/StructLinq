## ToArrayOnArraySelectOfClass

### Source
[ToArrayOnArraySelectOfClass.cs](../../src/StructLinq.Benchmark/ToArrayOnArraySelectOfClass.cs)

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
|             Linq | 17.38 μs | 0.145 μs | 0.136 μs |  1.00 | 8.4534 | 1.0376 |     - |  39.13 KB |   1.36 KB |
|       StructLinq | 21.93 μs | 0.093 μs | 0.087 μs |  1.26 | 8.4534 | 1.0376 |     - |  39.12 KB |   0.44 KB |
| StructLinqFaster | 16.54 μs | 0.089 μs | 0.083 μs |  0.95 | 8.4534 | 1.0376 |     - |  39.09 KB |   0.74 KB |
