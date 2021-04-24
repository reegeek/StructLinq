## ToArrayOnArraySelectOfClass

### Source
[ToArrayOnArraySelectOfClass.cs](../../src/StructLinq.Benchmark/ToArrayOnArraySelectOfClass.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
  DefaultJob : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT


```
|                 Method |     Mean |    Error |   StdDev | Ratio |  Gen 0 |  Gen 1 | Gen 2 | Allocated | Code Size |
|----------------------- |---------:|---------:|---------:|------:|-------:|-------:|------:|----------:|----------:|
|                   Linq | 17.17 μs | 0.129 μs | 0.115 μs |  1.00 | 8.4534 | 1.0376 |     - |  39.13 KB |   1.36 KB |
|             StructLinq | 18.69 μs | 0.070 μs | 0.062 μs |  1.09 | 8.4534 | 1.0376 |     - |  39.15 KB |   0.52 KB |
|    StructLinqZeroAlloc | 18.33 μs | 0.113 μs | 0.106 μs |  1.07 | 8.4534 | 1.0376 |     - |  39.09 KB |    0.9 KB |
| StructLinqWithFunction | 13.08 μs | 0.019 μs | 0.017 μs |  0.76 | 8.4686 | 1.0529 |     - |  39.09 KB |   0.87 KB |
