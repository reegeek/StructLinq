## ContainsWhere

### Source
[ContainsWhere.cs](../../src/StructLinq.Benchmark/ContainsWhere.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|              Method |     Mean |    Error |   StdDev | Ratio | Code Size | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |---------:|---------:|---------:|------:|----------:|------:|------:|------:|----------:|
|                Linq | 30.23 μs | 0.176 μs | 0.164 μs |  1.00 |    1257 B |     - |     - |     - |      48 B |
|               Array | 30.19 μs | 0.144 μs | 0.135 μs |  1.00 |    1257 B |     - |     - |     - |      48 B |
|          StructLinq | 14.95 μs | 0.121 μs | 0.113 μs |  0.49 |     401 B |     - |     - |     - |      64 B |
| StructLinqZeroAlloc | 15.09 μs | 0.067 μs | 0.063 μs |  0.50 |     771 B |     - |     - |     - |         - |
