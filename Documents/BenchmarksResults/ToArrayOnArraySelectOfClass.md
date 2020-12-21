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
|                 Method |     Mean |    Error |   StdDev | Ratio |  Gen 0 |  Gen 1 | Gen 2 | Allocated | Code Size |
|----------------------- |---------:|---------:|---------:|------:|-------:|-------:|------:|----------:|----------:|
|                   Linq | 25.31 μs | 0.106 μs | 0.094 μs |  1.00 | 8.4534 | 1.0376 |     - |  39.13 KB |   0.05 KB |
|             StructLinq | 25.34 μs | 0.236 μs | 0.184 μs |  1.00 | 8.4534 | 1.0376 |     - |  39.15 KB |   0.44 KB |
|       StructLinqFaster | 27.77 μs | 0.240 μs | 0.225 μs |  1.10 | 8.4534 | 1.0376 |     - |  39.12 KB |   0.05 KB |
| StructLinqWithFunction | 10.22 μs | 0.203 μs | 0.333 μs |  0.40 | 8.4686 | 1.0529 |     - |  39.09 KB |   0.78 KB |
