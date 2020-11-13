## Reverse

### Source
[Reverse.cs](../../src/StructLinq.Benchmark/Reverse.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|              Method |     Mean |    Error |   StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |---------:|---------:|---------:|------:|-------:|------:|------:|----------:|
|                Linq | 50.60 μs | 0.170 μs | 0.159 μs |  1.00 | 8.4229 |     - |     - |   40072 B |
|          StructLinq | 32.62 μs | 0.158 μs | 0.148 μs |  0.64 |      - |     - |     - |      32 B |
| StructLinqZeroAlloc | 15.25 μs | 0.079 μs | 0.074 μs |  0.30 |      - |     - |     - |         - |
