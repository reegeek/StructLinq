## SelectOnArrayOfClass

### Source
[SelectOnArrayOfClass.cs](../../src/StructLinq.Benchmark/SelectOnArrayOfClass.cs)

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
|              Handmaded |  5.882 μs | 0.0336 μs | 0.0315 μs |  1.00 |    0.00 |     - |     - |     - |         - |      48 B |
|                   LINQ | 63.507 μs | 0.3458 μs | 0.3235 μs | 10.80 |    0.07 |     - |     - |     - |      48 B |    1485 B |
|             StructLINQ | 22.641 μs | 0.0984 μs | 0.0920 μs |  3.85 |    0.03 |     - |     - |     - |         - |      48 B |
| StructLINQWithFunction | 15.673 μs | 0.0819 μs | 0.0766 μs |  2.66 |    0.02 |     - |     - |     - |         - |      48 B |
