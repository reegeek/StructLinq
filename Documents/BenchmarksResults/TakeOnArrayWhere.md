## TakeOnArrayWhere

### Source
[TakeOnArrayWhere.cs](../../src/StructLinq.Benchmark/TakeOnArrayWhere.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|           Method |     Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------- |---------:|---------:|---------:|------:|------:|------:|------:|----------:|
|             Linq | 54.24 μs | 0.275 μs | 0.257 μs |  1.00 |     - |     - |     - |     104 B |
|       StructLinq | 17.12 μs | 0.098 μs | 0.092 μs |  0.32 |     - |     - |     - |      64 B |
| StructLinqFaster | 17.59 μs | 0.034 μs | 0.027 μs |  0.32 |     - |     - |     - |         - |
