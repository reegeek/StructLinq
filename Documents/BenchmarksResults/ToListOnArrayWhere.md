## ToListOnArrayWhere

### Source
[ToListOnArrayWhere.cs](../../src/StructLinq.Benchmark/ToListOnArrayWhere.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100-preview.7.20366.6
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  DefaultJob : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT


```
|           Method |     Mean |    Error |   StdDev | Ratio | RatioSD |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|----------------- |---------:|---------:|---------:|------:|--------:|--------:|-------:|------:|----------:|
|             Linq | 34.47 us | 0.275 us | 0.244 us |  1.00 |    0.00 | 13.9771 | 2.7466 |     - |  64.34 KB |
|       StructLinq | 40.42 us | 0.419 us | 0.392 us |  1.17 |    0.02 |  4.2114 | 0.2441 |     - |  19.65 KB |
| StructLinqFaster | 24.43 us | 0.132 us | 0.117 us |  0.71 |    0.01 |  4.2419 | 0.2747 |     - |  19.59 KB |
|        WithVisit | 21.54 us | 0.107 us | 0.095 us |  0.62 |    0.01 |  4.2419 | 0.2747 |     - |  19.59 KB |
