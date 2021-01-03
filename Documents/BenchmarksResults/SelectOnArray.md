## SelectOnArray

### Source
[SelectOnArray.cs](../../src/StructLinq.Benchmark/SelectOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                 Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated | Code Size |
|----------------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|----------:|
|              Handmaded |  9.994 μs | 0.0247 μs | 0.0219 μs |  1.00 |    0.00 |     - |     - |     - |         - |      53 B |
|                   LINQ | 57.621 μs | 0.1736 μs | 0.1624 μs |  5.76 |    0.02 |     - |     - |     - |      48 B |    1147 B |
|             StructLINQ | 18.131 μs | 0.1017 μs | 0.0951 μs |  1.81 |    0.01 |     - |     - |     - |         - |     627 B |
| StructLINQWithFunction | 15.542 μs | 0.0791 μs | 0.0739 μs |  1.55 |    0.01 |     - |     - |     - |         - |     593 B |
