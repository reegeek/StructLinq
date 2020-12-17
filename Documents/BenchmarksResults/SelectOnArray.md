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
|              Handmaded | 11.64 μs | 0.059 μs | 0.056 μs |  1.00 |    0.00 |      53 B |     - |     - |     - |         - |
|                   LINQ | 91.67 μs | 1.828 μs | 3.478 μs |  7.91 |    0.39 |    1147 B |     - |     - |     - |      48 B |
|             StructLINQ | 28.54 μs | 0.592 μs | 1.737 μs |  2.32 |    0.26 |     627 B |     - |     - |     - |         - |
| StructLINQWithFunction | 20.65 μs | 0.406 μs | 0.667 μs |  1.75 |    0.05 |     593 B |     - |     - |     - |         - |
