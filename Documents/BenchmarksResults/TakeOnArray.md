## TakeOnArray

### Source
[TakeOnArray.cs](../../src/StructLinq.Benchmark/TakeOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|           Method |      Mean |     Error |    StdDev | Ratio | Code Size | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------- |----------:|----------:|----------:|------:|----------:|------:|------:|------:|----------:|
|             Linq | 41.538 μs | 0.2893 μs | 0.2706 μs |  1.00 |     561 B |     - |     - |     - |      48 B |
|       StructLinq | 11.002 μs | 0.2189 μs | 0.4471 μs |  0.27 |     252 B |     - |     - |     - |      64 B |
| StructLinqFaster |  1.910 μs | 0.0096 μs | 0.0090 μs |  0.05 |     219 B |     - |     - |     - |         - |
