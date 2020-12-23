## Sum

### Source
[Sum.cs](../../src/StructLinq.Benchmark/Sum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|             Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated | Code Size |
|------------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|----------:|
|             ForSum |  3.080 μs | 0.0561 μs | 0.0600 μs |  1.00 |    0.00 |     - |     - |     - |         - |      17 B |
|             SysSum | 41.612 μs | 0.7726 μs | 0.7227 μs | 13.50 |    0.31 |     - |     - |     - |      40 B |     445 B |
|          StructSum |  5.692 μs | 0.0111 μs | 0.0104 μs |  1.85 |    0.04 |     - |     - |     - |      24 B |      93 B |
| StructSumZeroAlloc |  3.054 μs | 0.0545 μs | 0.0510 μs |  0.99 |    0.03 |     - |     - |     - |         - |     139 B |
|   StructForEachSum |  3.077 μs | 0.0591 μs | 0.0726 μs |  1.00 |    0.03 |     - |     - |     - |         - |      22 B |
|         ConvertSum | 41.976 μs | 0.6487 μs | 0.5750 μs | 13.63 |    0.30 |     - |     - |     - |      40 B |     594 B |
