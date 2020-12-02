## ContainsWhere

### Source
[ContainsWhere.cs](../../src/StructLinq.Benchmark/ContainsWhere.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|              Method |     Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |---------:|---------:|---------:|------:|------:|------:|------:|----------:|
|                Linq | 31.00 us | 0.044 us | 0.037 us |  1.00 |     - |     - |     - |      48 B |
|               Array | 31.04 us | 0.067 us | 0.060 us |  1.00 |     - |     - |     - |      48 B |
|          StructLinq | 18.29 us | 0.016 us | 0.013 us |  0.59 |     - |     - |     - |      64 B |
| StructLinqZeroAlloc | 18.28 us | 0.018 us | 0.016 us |  0.59 |     - |     - |     - |         - |
