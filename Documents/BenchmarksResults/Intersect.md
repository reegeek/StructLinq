## Intersect

### Source
[Intersect.cs](../../src/StructLinq.Benchmark/Intersect.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|                         Method |      Mean |    Error |   StdDev | Ratio |   Gen 0 |  Gen 1 | Allocated |
|------------------------------- |----------:|---------:|---------:|------:|--------:|-------:|----------:|
|                           Linq |  91.56 μs | 0.769 μs | 0.642 μs |  1.00 | 19.5313 | 4.7607 |  93,704 B |
|                     StructLinq | 103.47 μs | 0.758 μs | 0.709 μs |  1.13 |       - |      - |      64 B |
|            StructLinqZeroAlloc | 103.28 μs | 0.931 μs | 0.778 μs |  1.13 |       - |      - |         - |
| StructLinqZeroAllocAndComparer |  89.71 μs | 0.864 μs | 0.721 μs |  0.98 |       - |      - |         - |
