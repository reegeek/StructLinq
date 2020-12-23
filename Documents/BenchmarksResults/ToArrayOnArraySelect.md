## ToArrayOnArraySelect

### Source
[ToArrayOnArraySelect.cs](../../src/StructLinq.Benchmark/ToArrayOnArraySelect.cs)

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
|                   Linq | 22.11 μs | 0.200 μs | 0.187 μs |  1.00 | 9.5215 | 0.0305 |     - |  39.13 KB |   0.96 KB |
|             StructLinq | 22.10 μs | 0.191 μs | 0.169 μs |  1.00 | 9.5215 | 0.0305 |     - |  39.15 KB |   0.42 KB |
|    StructLinqZeroAlloc | 27.75 μs | 0.144 μs | 0.135 μs |  1.26 | 9.5215 | 0.0305 |     - |  39.12 KB |   0.58 KB |
| StructLinqWithFunction | 12.03 μs | 0.155 μs | 0.145 μs |  0.54 | 9.5215 | 0.0153 |     - |  39.09 KB |   0.78 KB |
