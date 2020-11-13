## Min

### Source
[Min.cs](../../src/StructLinq.Benchmark/Min.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|             Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated | Code Size |
|------------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|----------:|
|             RawMin |  7.522 μs | 0.0376 μs | 0.0352 μs |  1.00 |    0.00 |     - |     - |     - |         - |      24 B |
|             SysMin | 40.263 μs | 0.1849 μs | 0.1639 μs |  5.35 |    0.03 |     - |     - |     - |      40 B |     519 B |
|          StructMin | 13.080 μs | 0.0613 μs | 0.0574 μs |  1.74 |    0.01 |     - |     - |     - |      24 B |     177 B |
| ZeroAllocStructMin | 13.155 μs | 0.0440 μs | 0.0412 μs |  1.75 |    0.01 |     - |     - |     - |         - |     257 B |
|         ConvertMin | 40.179 μs | 0.1489 μs | 0.1320 μs |  5.34 |    0.02 |     - |     - |     - |      64 B |     526 B |
