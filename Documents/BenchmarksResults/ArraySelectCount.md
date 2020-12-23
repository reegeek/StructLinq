## ArraySelectCount

### Source
[ArraySelectCount.cs](../../src/StructLinq.Benchmark/ArraySelectCount.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|              Method |         Mean |     Error |    StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |-------------:|----------:|----------:|------:|-------:|------:|------:|----------:|
|                Linq | 19,973.59 ns | 34.920 ns | 32.664 ns | 1.000 |      - |     - |     - |      48 B |
|          StructLinq |     26.10 ns |  0.376 ns |  0.352 ns | 0.001 | 0.0153 |     - |     - |      64 B |
| StructLinqZeroAlloc |     11.54 ns |  0.016 ns |  0.013 ns | 0.001 |      - |     - |     - |         - |
