## Intersect

### Source
[Intersect.cs](../../src/StructLinq.Benchmark/Intersect.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100-preview.7.20366.6
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|                         Method |      Mean |    Error |   StdDev | Ratio |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
|------------------------------- |----------:|---------:|---------:|------:|--------:|--------:|--------:|----------:|
|                           Linq | 200.88 us | 0.777 us | 0.688 us |  1.00 | 62.2559 | 31.0059 | 31.0059 |  262666 B |
|                     StructLinq | 104.67 us | 0.236 us | 0.197 us |  0.52 |       - |       - |       - |      64 B |
|            StructLinqZeroAlloc | 105.21 us | 0.272 us | 0.241 us |  0.52 |       - |       - |       - |         - |
| StructLinqZeroAllocAndComparer |  83.29 us | 0.113 us | 0.094 us |  0.41 |       - |       - |       - |         - |
