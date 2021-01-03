## WhereOnArrayOfClass

### Source
[WhereOnArrayOfClass.cs](../../src/StructLinq.Benchmark/WhereOnArrayOfClass.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                 Method |     Mean |    Error |   StdDev | Ratio | RatioSD | Code Size | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------- |---------:|---------:|---------:|------:|--------:|----------:|------:|------:|------:|----------:|
|              Handmaded | 11.28 μs | 0.033 μs | 0.029 μs |  1.00 |    0.00 |      48 B |     - |     - |     - |         - |
|                   LINQ | 54.49 μs | 0.386 μs | 0.322 μs |  4.83 |    0.03 |    1140 B |     - |     - |     - |      48 B |
|             StructLINQ | 34.32 μs | 0.170 μs | 0.159 μs |  3.04 |    0.02 |      48 B |     - |     - |     - |         - |
| StructLINQWithFunction | 18.06 μs | 0.111 μs | 0.099 μs |  1.60 |    0.01 |      48 B |     - |     - |     - |         - |
