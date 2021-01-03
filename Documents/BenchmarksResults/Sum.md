## Sum

### Source
[Sum.cs](../../src/StructLinq.Benchmark/Sum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|             Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated | Code Size |
|------------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|----------:|
|             ForSum |  2.511 μs | 0.0088 μs | 0.0073 μs |  1.00 |    0.00 |     - |     - |     - |         - |      17 B |
|             SysSum | 35.108 μs | 0.1810 μs | 0.1604 μs | 13.98 |    0.06 |     - |     - |     - |      40 B |     445 B |
|          StructSum |  4.999 μs | 0.0182 μs | 0.0170 μs |  1.99 |    0.01 |     - |     - |     - |      24 B |      93 B |
| StructSumZeroAlloc |  2.509 μs | 0.0091 μs | 0.0085 μs |  1.00 |    0.00 |     - |     - |     - |         - |     139 B |
|   StructForEachSum |  4.999 μs | 0.0180 μs | 0.0169 μs |  1.99 |    0.01 |     - |     - |     - |         - |      22 B |
|         ConvertSum | 37.555 μs | 0.1864 μs | 0.1744 μs | 14.96 |    0.09 |     - |     - |     - |      40 B |     594 B |
