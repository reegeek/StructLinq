## IList

### Source
[IList.cs](../../src/StructLinq.Benchmark/IList.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|     Method |     Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------- |---------:|---------:|---------:|------:|------:|------:|------:|----------:|
|       Linq | 57.71 μs | 0.277 μs | 0.246 μs |  1.00 |     - |     - |     - |      40 B |
| StructLinq | 20.11 μs | 0.104 μs | 0.097 μs |  0.35 |     - |     - |     - |         - |
