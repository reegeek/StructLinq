## ImmutableArrayWhereSelectSum

### Source
[ImmutableArrayWhereSelectSum.cs](../../src/StructLinq.Benchmark/ImmutableArrayWhereSelectSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100-preview.7.20366.6
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  DefaultJob : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT


```
|             Method |     Mean |    Error |   StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------- |---------:|---------:|---------:|------:|--------:|------:|------:|------:|----------:|
|               LINQ | 51.77 us | 0.492 us | 0.461 us |  1.00 |    0.00 |     - |     - |     - |     104 B |
|         StructLinq | 68.73 us | 0.904 us | 0.846 us |  1.33 |    0.02 |     - |     - |     - |         - |
| StructLinqFunction | 35.82 us | 0.350 us | 0.327 us |  0.69 |    0.01 |     - |     - |     - |         - |
