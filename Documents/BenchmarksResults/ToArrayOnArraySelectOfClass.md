## ToArrayOnArraySelectOfClass

### Source
[ToArrayOnArraySelectOfClass.cs](../../src/StructLinq.Benchmark/ToArrayOnArraySelectOfClass.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                 Method |     Mean |    Error |   StdDev | Ratio |  Gen 0 |  Gen 1 | Gen 2 | Allocated | Code Size |
|----------------------- |---------:|---------:|---------:|------:|-------:|-------:|------:|----------:|----------:|
|                   Linq | 32.17 μs | 0.423 μs | 0.375 μs |  1.00 | 9.5215 | 1.1902 |     - |  39.13 KB |   0.05 KB |
|             StructLinq | 32.12 μs | 0.222 μs | 0.185 μs |  1.00 | 9.5215 | 1.1902 |     - |  39.12 KB |   0.42 KB |
|       StructLinqFaster | 32.09 μs | 0.279 μs | 0.261 μs |  1.00 | 9.5215 | 1.1902 |     - |  39.12 KB |   0.51 KB |
| StructLinqWithFunction | 22.32 μs | 0.184 μs | 0.172 μs |  0.69 | 9.5215 | 1.1902 |     - |  39.09 KB |   0.74 KB |
