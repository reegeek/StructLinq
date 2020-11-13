## ArraySelectCount

### Source
[ArraySelectCount.cs](../../src/StructLinq.Benchmark/ArraySelectCount.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|              Method |     Mean |    Error |   StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |---------:|---------:|---------:|------:|------:|------:|----------:|
|                Linq | 15.26 μs | 0.080 μs | 0.071 μs |     - |     - |     - |      48 B |
|          StructLinq | 13.89 μs | 0.164 μs | 0.153 μs |     - |     - |     - |      32 B |
| StructLinqZeroAlloc | 13.31 μs | 0.043 μs | 0.040 μs |     - |     - |     - |         - |
