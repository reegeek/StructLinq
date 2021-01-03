## Repeat

### Source
[Repeat.cs](../../src/StructLinq.Benchmark/Repeat.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                 Method |      Mean |     Error |    StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------- |----------:|----------:|----------:|------:|------:|------:|------:|----------:|
|       EnumerableRepeat | 35.147 μs | 0.2385 μs | 0.2230 μs |  1.00 |     - |     - |     - |      32 B |
| StructEnumerableRepeat |  2.526 μs | 0.0069 μs | 0.0064 μs |  0.07 |     - |     - |     - |         - |
