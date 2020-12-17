## SelectOnArrayOfClass

### Source
[SelectOnArrayOfClass.cs](../../src/StructLinq.Benchmark/SelectOnArrayOfClass.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                 Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated | Code Size |
|----------------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|----------:|
|              Handmaded |  7.822 μs | 0.1200 μs | 0.1123 μs |  1.00 |    0.00 |     - |     - |     - |         - |      48 B |
|                   LINQ | 96.682 μs | 1.9111 μs | 4.3525 μs | 12.11 |    0.62 |     - |     - |     - |      48 B |      48 B |
|             StructLINQ | 34.535 μs | 0.7344 μs | 2.1423 μs |  4.60 |    0.37 |     - |     - |     - |         - |      48 B |
| StructLINQWithFunction | 18.868 μs | 0.3754 μs | 0.6375 μs |  2.48 |    0.06 |     - |     - |     - |         - |      48 B |
