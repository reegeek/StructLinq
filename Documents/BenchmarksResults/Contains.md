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
|              Method |     Mean |     Error |    StdDev | Ratio | Code Size |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |---------:|----------:|----------:|------:|----------:|-------:|------:|------:|----------:|
|               Array | 1.128 μs | 0.0031 μs | 0.0026 μs |  1.00 |      98 B |      - |     - |     - |         - |
|          StructLinq | 2.592 μs | 0.0129 μs | 0.0114 μs |  2.30 |     176 B | 0.0038 |     - |     - |      32 B |
| StructLinqZeroAlloc | 3.803 μs | 0.0059 μs | 0.0053 μs |  3.37 |     256 B |      - |     - |     - |         - |
