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
|              Method |     Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated | Code Size |
|-------------------- |---------:|---------:|---------:|------:|------:|------:|------:|----------:|----------:|
|                Linq | 31.42 μs | 0.110 μs | 0.098 μs |  1.00 |     - |     - |     - |      48 B |    1257 B |
|               Array | 31.45 μs | 0.107 μs | 0.095 μs |  1.00 |     - |     - |     - |      48 B |    1257 B |
|          StructLinq | 14.98 μs | 0.136 μs | 0.114 μs |  0.48 |     - |     - |     - |      64 B |     401 B |
| StructLinqZeroAlloc | 13.78 μs | 0.041 μs | 0.035 μs |  0.44 |     - |     - |     - |         - |     771 B |
