## Zip

### Source
[Zip.cs](../../src/StructLinq.Benchmark/Zip.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.203
  [Host]     : .NET Core 5.0.6 (CoreCLR 5.0.621.22011, CoreFX 5.0.621.22011), X64 RyuJIT
  DefaultJob : .NET Core 5.0.6 (CoreCLR 5.0.621.22011, CoreFX 5.0.621.22011), X64 RyuJIT


```
|             Method |     Mean |    Error |   StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------- |---------:|---------:|---------:|------:|-------:|------:|------:|----------:|
|               Linq | 70.70 μs | 0.718 μs | 0.672 μs |  1.00 |      - |     - |     - |     144 B |
|         StructLinq | 12.76 μs | 0.022 μs | 0.020 μs |  0.18 | 0.0153 |     - |     - |      64 B |
| StructLinqFunction | 10.38 μs | 0.014 μs | 0.012 μs |  0.15 |      - |     - |     - |         - |
