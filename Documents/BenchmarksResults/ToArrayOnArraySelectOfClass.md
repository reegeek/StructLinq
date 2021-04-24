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
|                 Method |      Mean |     Error |    StdDev | Ratio | Code Size |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|----------------------- |----------:|----------:|----------:|------:|----------:|-------:|-------:|------:|----------:|
|                   Linq | 24.196 μs | 0.0898 μs | 0.0796 μs |  1.00 |   0.15 KB | 8.4534 | 1.0376 |     - |  39.13 KB |
|             StructLinq | 24.224 μs | 0.1128 μs | 0.1055 μs |  1.00 |   0.05 KB | 8.4534 | 1.0376 |     - |  39.15 KB |
|    StructLinqZeroAlloc | 24.116 μs | 0.0938 μs | 0.0877 μs |  1.00 |   0.05 KB | 8.4534 | 1.0376 |     - |  39.09 KB |
| StructLinqWithFunction |  8.959 μs | 0.1163 μs | 0.1088 μs |  0.37 |   0.78 KB | 8.4686 | 1.0529 |     - |  39.09 KB |
