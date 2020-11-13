## Contains

### Source
[Contains.cs](../../src/StructLinq.Benchmark/Contains.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|              Method |     Mean |     Error |    StdDev | Ratio | Code Size |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |---------:|----------:|----------:|------:|----------:|-------:|------:|------:|----------:|
|                Linq | 1.080 μs | 0.0040 μs | 0.0035 μs |  1.00 |      98 B |      - |     - |     - |         - |
|               Array | 1.121 μs | 0.0063 μs | 0.0059 μs |  1.04 |      98 B |      - |     - |     - |         - |
|          StructLinq | 1.914 μs | 0.0117 μs | 0.0091 μs |  1.77 |     156 B | 0.0038 |     - |     - |      32 B |
| StructLinqZeroAlloc | 2.519 μs | 0.0085 μs | 0.0080 μs |  2.33 |     236 B |      - |     - |     - |         - |
