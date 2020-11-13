## SkipOnArrayWhere

### Source
[SkipOnArrayWhere.cs](../../src/StructLinq.Benchmark/SkipOnArrayWhere.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|           Method |      Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------- |----------:|---------:|---------:|------:|------:|------:|------:|----------:|
|             Linq | 103.61 μs | 0.291 μs | 0.272 μs |  1.00 |     - |     - |     - |     104 B |
|       StructLinq |  27.41 μs | 0.081 μs | 0.076 μs |  0.26 |     - |     - |     - |      64 B |
| StructLinqFaster |  27.69 μs | 0.086 μs | 0.076 μs |  0.27 |     - |     - |     - |         - |
