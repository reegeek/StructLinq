## TakeOnArray

### Source
[TakeOnArray.cs](../../src/StructLinq.Benchmark/TakeOnArray.cs)

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
|             Linq | 40.278 μs | 0.3093 μs | 0.2742 μs |  1.00 |     - |     - |     - |      48 B |     561 B |
|       StructLinq | 11.382 μs | 0.1356 μs | 0.1268 μs |  0.28 |     - |     - |     - |      64 B |     252 B |
| StructLinqFaster |  1.908 μs | 0.0086 μs | 0.0080 μs |  0.05 |     - |     - |     - |         - |     219 B |
