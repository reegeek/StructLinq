## ArraySelectCount

### Source
[ArraySelectCount.cs](../../src/StructLinq.Benchmark/ArraySelectCount.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|              Method |         Mean |     Error |    StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |-------------:|----------:|----------:|------:|-------:|------:|------:|----------:|
|                Linq | 17,618.17 ns | 78.947 ns | 73.847 ns | 1.000 |      - |     - |     - |      48 B |
|          StructLinq |     16.30 ns |  0.106 ns |  0.094 ns | 0.001 | 0.0136 |     - |     - |      64 B |
| StructLinqZeroAlloc |     10.13 ns |  0.050 ns |  0.047 ns | 0.001 |      - |     - |     - |         - |
