## Distinct

### Source
[Distinct.cs](../../src/StructLinq.Benchmark/Distinct.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|                 Method |     Mean |   Error |  StdDev | Ratio |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
|----------------------- |---------:|--------:|--------:|------:|--------:|--------:|--------:|----------:|
|                   Linq | 513.2 us | 5.64 us | 4.71 us |  1.00 | 90.8203 | 90.8203 | 90.8203 |  524789 B |
|             StructLinq | 210.5 us | 0.48 us | 0.42 us |  0.41 |       - |       - |       - |      32 B |
|    StructLinqZeroAlloc | 204.4 us | 0.42 us | 0.40 us |  0.40 |       - |       - |       - |         - |
| StructLinqZeroAllocSum | 192.9 us | 0.55 us | 0.49 us |  0.38 |       - |       - |       - |         - |
