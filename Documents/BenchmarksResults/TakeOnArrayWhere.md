## TakeOnArrayWhere

### Source
[TakeOnArrayWhere.cs](../../src/StructLinq.Benchmark/TakeOnArrayWhere.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|           Method |     Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------- |---------:|---------:|---------:|------:|------:|------:|------:|----------:|
|             Linq | 52.74 μs | 0.338 μs | 0.299 μs |  1.00 |     - |     - |     - |     104 B |
|       StructLinq | 16.43 μs | 0.117 μs | 0.109 μs |  0.31 |     - |     - |     - |      64 B |
| StructLinqFaster | 15.76 μs | 0.128 μs | 0.119 μs |  0.30 |     - |     - |     - |         - |
