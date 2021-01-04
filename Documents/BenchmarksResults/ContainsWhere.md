## ContainsWhere

### Source
[ContainsWhere.cs](../../src/StructLinq.Benchmark/ContainsWhere.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|              Method |     Mean |    Error |   StdDev | Ratio | Code Size | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |---------:|---------:|---------:|------:|----------:|------:|------:|------:|----------:|
|                Linq | 31.71 μs | 0.122 μs | 0.095 μs |  1.00 |    1257 B |     - |     - |     - |      48 B |
|               Array | 30.42 μs | 0.065 μs | 0.054 μs |  0.96 |    1257 B |     - |     - |     - |      48 B |
|          StructLinq | 11.24 μs | 0.051 μs | 0.045 μs |  0.35 |     302 B |     - |     - |     - |      64 B |
| StructLinqZeroAlloc | 10.39 μs | 0.071 μs | 0.063 μs |  0.33 |     716 B |     - |     - |     - |         - |
