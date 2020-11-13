## ToArrayOnArrayWhereOfClass

### Source
[ToArrayOnArrayWhereOfClass.cs](../../src/StructLinq.Benchmark/ToArrayOnArrayWhereOfClass.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|           Method |     Mean |    Error |   StdDev | Ratio |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|----------------- |---------:|---------:|---------:|------:|--------:|-------:|------:|----------:|
|             Linq | 46.89 μs | 0.158 μs | 0.140 μs |  1.00 | 22.4609 | 5.6152 |     - | 103.73 KB |
|       StructLinq | 43.48 μs | 0.237 μs | 0.222 μs |  0.93 |  8.4229 | 1.0376 |     - |  39.15 KB |
| StructLinqFaster | 31.79 μs | 0.151 μs | 0.141 μs |  0.68 |  8.4229 | 1.0376 |     - |  39.09 KB |
