## Contains

### Source
[Contains.cs](../../src/StructLinq.Benchmark/Contains.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|              Method |     Mean |     Error |    StdDev | Ratio | RatioSD | Code Size |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |---------:|----------:|----------:|------:|--------:|----------:|-------:|------:|------:|----------:|
|               Array | 1.135 μs | 0.0180 μs | 0.0169 μs |  1.00 |    0.00 |      98 B |      - |     - |     - |         - |
|          StructLinq | 1.908 μs | 0.0091 μs | 0.0086 μs |  1.68 |    0.02 |     156 B | 0.0038 |     - |     - |      32 B |
| StructLinqZeroAlloc | 2.513 μs | 0.0077 μs | 0.0072 μs |  2.21 |    0.03 |     236 B |      - |     - |     - |         - |
