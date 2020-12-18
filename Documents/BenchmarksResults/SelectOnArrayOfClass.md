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
|              Handmaded |  6.726 μs | 0.1298 μs | 0.1494 μs |  1.00 |    0.00 |     - |     - |     - |         - |      48 B |
|                   LINQ | 76.179 μs | 1.4866 μs | 1.6523 μs | 11.32 |    0.33 |     - |     - |     - |      48 B |      48 B |
|             StructLINQ | 27.129 μs | 0.4152 μs | 0.3467 μs |  4.04 |    0.10 |     - |     - |     - |         - |      48 B |
| StructLINQWithFunction | 17.780 μs | 0.2278 μs | 0.2020 μs |  2.64 |    0.07 |     - |     - |     - |         - |      48 B |
