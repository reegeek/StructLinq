## SkipOnArray

### Source
[SkipOnArray.cs](../../src/StructLinq.Benchmark/SkipOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|           Method |      Mean |     Error |    StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated | Code Size |
|----------------- |----------:|----------:|----------:|------:|------:|------:|------:|----------:|----------:|
|             Linq | 71.239 μs | 0.4385 μs | 0.4101 μs |  1.00 |     - |     - |     - |      48 B |     648 B |
|       StructLinq | 19.020 μs | 0.0710 μs | 0.0664 μs |  0.27 |     - |     - |     - |      64 B |     246 B |
| StructLinqFaster |  9.013 μs | 0.0288 μs | 0.0270 μs |  0.13 |     - |     - |     - |         - |     208 B |
