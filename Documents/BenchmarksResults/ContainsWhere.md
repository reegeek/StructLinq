## ContainsWhere

### Source
[ContainsWhere.cs](../../src/StructLinq.Benchmark/ContainsWhere.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19043
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.301
  [Host]     : .NET Core 5.0.7 (CoreCLR 5.0.721.25508, CoreFX 5.0.721.25508), X64 RyuJIT
  DefaultJob : .NET Core 5.0.7 (CoreCLR 5.0.721.25508, CoreFX 5.0.721.25508), X64 RyuJIT


```
|              Method |     Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated | Code Size |
|-------------------- |---------:|---------:|---------:|------:|------:|------:|------:|----------:|----------:|
|                Linq | 28.27 μs | 0.174 μs | 0.155 μs |  1.00 |     - |     - |     - |      48 B |    1257 B |
|               Array | 30.77 μs | 0.272 μs | 0.255 μs |  1.09 |     - |     - |     - |      48 B |    1257 B |
|          StructLinq | 10.33 μs | 0.080 μs | 0.075 μs |  0.37 |     - |     - |     - |      64 B |     302 B |
| StructLinqZeroAlloc | 10.23 μs | 0.044 μs | 0.039 μs |  0.36 |     - |     - |     - |         - |     716 B |
