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
|                  Method |     Mean |    Error |   StdDev |   Median | Ratio | RatioSD |  Gen 0 |  Gen 1 | Gen 2 | Allocated | Code Size |
|------------------------ |---------:|---------:|---------:|---------:|------:|--------:|-------:|-------:|------:|----------:|----------:|
|                    Linq | 32.38 μs | 1.323 μs | 3.902 μs | 34.26 μs |  1.00 |    0.00 | 9.5215 | 0.0305 |     - |  39.13 KB |   0.96 KB |
|              StructLinq | 40.07 μs | 1.155 μs | 3.332 μs | 40.56 μs |  1.26 |    0.20 | 9.5215 | 0.0610 |     - |  39.12 KB |    0.4 KB |
|             StructLinq2 | 72.25 μs | 1.577 μs | 4.599 μs | 70.91 μs |  2.27 |    0.37 | 9.5215 | 0.1221 |     - |  39.12 KB |   0.47 KB |
|        StructLinqFaster | 33.73 μs | 1.273 μs | 3.733 μs | 34.10 μs |  1.06 |    0.17 | 9.5215 | 0.0305 |     - |  39.12 KB |    0.5 KB |
|       StructLinqFaster2 | 72.34 μs | 1.841 μs | 4.977 μs | 70.54 μs |  2.29 |    0.36 | 9.5215 | 0.1221 |     - |  39.12 KB |   0.55 KB |
|  StructLinqWithFunction | 26.86 μs | 0.236 μs | 0.184 μs | 26.91 μs |  0.83 |    0.03 | 9.5215 | 0.0305 |     - |  39.09 KB |   0.74 KB |
| StructLinqWithFunction2 | 23.96 μs | 0.463 μs | 0.410 μs | 24.08 μs |  0.73 |    0.03 | 9.5215 | 1.1902 |     - |  39.09 KB |   0.76 KB |
|             WithVisitor | 36.10 μs | 1.476 μs | 4.353 μs | 36.68 μs |  1.13 |    0.21 | 9.5215 | 0.0305 |     - |  39.09 KB |    0.3 KB |
