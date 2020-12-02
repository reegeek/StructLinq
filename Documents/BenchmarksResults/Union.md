## Union

### Source
[Union.cs](../../src/StructLinq.Benchmark/Union.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|                         Method |     Mean |   Error |  StdDev | Ratio |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
|------------------------------- |---------:|--------:|--------:|------:|--------:|--------:|--------:|----------:|
|                           Linq | 392.6 us | 1.89 us | 1.67 us |  1.00 | 90.8203 | 90.8203 | 90.8203 |  524826 B |
|                     StructLinq | 164.6 us | 0.61 us | 0.57 us |  0.42 |       - |       - |       - |      64 B |
|            StructLinqZeroAlloc | 164.1 us | 0.80 us | 0.63 us |  0.42 |       - |       - |       - |         - |
| StructLinqZeroAllocAndComparer | 137.6 us | 0.51 us | 0.48 us |  0.35 |       - |       - |       - |       	- |
