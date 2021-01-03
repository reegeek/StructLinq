## IList

### Source
[IList.cs](../../src/StructLinq.Benchmark/IList.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|     Method |     Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------- |---------:|---------:|---------:|------:|------:|------:|------:|----------:|
|       Linq | 57.35 μs | 0.134 μs | 0.125 μs |  1.00 |     - |     - |     - |      40 B |
| StructLinq | 20.01 μs | 0.066 μs | 0.059 μs |  0.35 |     - |     - |     - |         - |
