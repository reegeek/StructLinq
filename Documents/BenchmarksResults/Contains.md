## Contains

### Source
[Contains.cs](../../src/StructLinq.Benchmark/Contains.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|              Method |     Mean |     Error |    StdDev |   Median | Ratio | RatioSD | Code Size |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |---------:|----------:|----------:|---------:|------:|--------:|----------:|-------:|------:|------:|----------:|
|               Array | 1.191 μs | 0.0142 μs | 0.0126 μs | 1.190 μs |  1.00 |    0.00 |      98 B |      - |     - |     - |         - |
|          StructLinq | 2.902 μs | 0.0251 μs | 0.0209 μs | 2.896 μs |  2.44 |    0.03 |     156 B | 0.0076 |     - |     - |      32 B |
| StructLinqZeroAlloc | 2.923 μs | 0.0582 μs | 0.1253 μs | 2.866 μs |  2.58 |    0.13 |     236 B |      - |     - |     - |         - |
