## Except

### Source
[Except.cs](../../src/StructLinq.Benchmark/Except.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100-preview.7.20366.6
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|                         Method |     Mean |   Error |  StdDev | Ratio |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
|------------------------------- |---------:|--------:|--------:|------:|--------:|--------:|--------:|----------:|
|                           Linq | 353.9 us | 2.76 us | 2.44 us |  1.00 | 90.8203 | 90.8203 | 90.8203 |  524849 B |
|                     StructLinq | 160.7 us | 1.23 us | 1.09 us |  0.45 |       - |       - |       - |      64 B |
|            StructLinqZeroAlloc | 151.9 us | 1.48 us | 1.38 us |  0.43 |       - |       - |       - |         - |
| StructLinqZeroAllocAndComparer | 132.8 us | 1.43 us | 1.34 us |  0.38 |       - |       - |       - |         - |
