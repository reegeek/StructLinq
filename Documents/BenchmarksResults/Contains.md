## Contains

### Source
[Contains.cs](../../src/StructLinq.Benchmark/Contains.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100-preview.7.20366.6
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  DefaultJob : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT


```
|              Method |     Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |---------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
|               Array | 1.142 us | 0.0102 us | 0.0095 us |  1.00 |    0.00 |     - |     - |     - |         - |
| StructLinqZeroAlloc | 1.997 us | 0.0381 us | 0.0318 us |  1.75 |    0.03 |     - |     - |     - |         - |
|           WithVisit | 3.956 us | 0.0383 us | 0.0320 us |  3.47 |    0.03 |     - |     - |     - |         - |
