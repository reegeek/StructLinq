## ToArrayOnArraySelect

### Source
[ToArrayOnArraySelect.cs](../../src/StructLinq.Benchmark/ToArrayOnArraySelect.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100-preview.7.20366.6
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  DefaultJob : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT


```
|           Method |     Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|----------------- |---------:|---------:|---------:|------:|--------:|-------:|-------:|------:|----------:|
|             Linq | 21.01 us | 0.284 us | 0.265 us |  1.00 |    0.00 | 8.4534 | 1.0376 |     - |  39.13 KB |
|       StructLinq | 28.96 us | 0.225 us | 0.211 us |  1.38 |    0.02 | 8.4534 | 1.0376 |     - |  39.12 KB |
| StructLinqFaster | 19.35 us | 0.126 us | 0.118 us |  0.92 |    0.01 | 8.4534 | 0.3662 |     - |  39.09 KB |
|      WithVisitor | 16.74 us | 0.324 us | 0.410 us |  0.79 |    0.02 | 8.4534 | 1.0376 |     - |  39.09 KB |
