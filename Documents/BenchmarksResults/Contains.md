## Contains

### Source
[Contains.cs](../../src/StructLinq.Benchmark/Contains.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19043
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.301
  [Host]     : .NET Core 5.0.7 (CoreCLR 5.0.721.25508, CoreFX 5.0.721.25508), X64 RyuJIT
  DefaultJob : .NET Core 5.0.7 (CoreCLR 5.0.721.25508, CoreFX 5.0.721.25508), X64 RyuJIT


```
|              Method |     Mean |     Error |    StdDev | Ratio | RatioSD | Code Size |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |---------:|----------:|----------:|------:|--------:|----------:|-------:|------:|------:|----------:|
|               Array | 1.096 μs | 0.0055 μs | 0.0052 μs |  1.00 |    0.00 |      98 B |      - |     - |     - |         - |
|          StructLinq | 3.203 μs | 0.0088 μs | 0.0083 μs |  2.92 |    0.02 |     148 B | 0.0038 |     - |     - |      32 B |
| StructLinqZeroAlloc | 1.910 μs | 0.0088 μs | 0.0078 μs |  1.74 |    0.01 |     347 B |      - |     - |     - |         - |
