## SkipOnArray

### Source
[SkipOnArray.cs](../../src/StructLinq.Benchmark/SkipOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|           Method |      Mean |     Error |    StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated | Code Size |
|----------------- |----------:|----------:|----------:|------:|------:|------:|------:|----------:|----------:|
|             Linq | 73.206 μs | 0.4566 μs | 0.4271 μs |  1.00 |     - |     - |     - |      48 B |     648 B |
|       StructLinq | 19.138 μs | 0.0671 μs | 0.0628 μs |  0.26 |     - |     - |     - |      64 B |     246 B |
| StructLinqFaster |  9.040 μs | 0.0353 μs | 0.0313 μs |  0.12 |     - |     - |     - |         - |     208 B |
