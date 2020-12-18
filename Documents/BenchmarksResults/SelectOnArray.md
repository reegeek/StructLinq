## SelectOnArray

### Source
[SelectOnArray.cs](../../src/StructLinq.Benchmark/SelectOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                 Method |     Mean |    Error |   StdDev | Ratio | RatioSD | Code Size | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------- |---------:|---------:|---------:|------:|--------:|----------:|------:|------:|------:|----------:|
|              Handmaded | 11.27 μs | 0.011 μs | 0.009 μs |  1.00 |    0.00 |      53 B |     - |     - |     - |         - |
|                   LINQ | 61.02 μs | 0.356 μs | 0.298 μs |  5.41 |    0.03 |    1147 B |     - |     - |     - |      48 B |
|             StructLINQ | 20.85 μs | 0.098 μs | 0.087 μs |  1.85 |    0.01 |     627 B |     - |     - |     - |         - |
| StructLINQWithFunction | 17.78 μs | 0.076 μs | 0.063 μs |  1.58 |    0.01 |     593 B |     - |     - |     - |         - |
