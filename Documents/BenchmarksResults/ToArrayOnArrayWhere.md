## ToArrayOnArrayWhere

### Source
[ToArrayOnArrayWhere.cs](../../src/StructLinq.Benchmark/ToArrayOnArrayWhere.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                 Method |     Mean |    Error |   StdDev | Ratio |   Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------- |---------:|---------:|---------:|------:|--------:|------:|------:|----------:|
|                   Linq | 36.18 μs | 0.472 μs | 0.418 μs |  1.00 | 12.6953 |     - |     - |  52.19 KB |
|             StructLinq | 29.66 μs | 0.151 μs | 0.141 μs |  0.82 |  4.7607 |     - |     - |  19.62 KB |
|    StructLinqZeroAlloc | 30.95 μs | 0.115 μs | 0.108 μs |  0.86 |  4.7607 |     - |     - |  19.55 KB |
| StructLinqWithFunction | 15.18 μs | 0.224 μs | 0.187 μs |  0.42 |  4.7607 |     - |     - |  19.55 KB |
