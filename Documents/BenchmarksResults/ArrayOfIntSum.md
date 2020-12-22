## ArrayOfIntSum

### Source
[ArrayOfIntSum.cs](../../src/StructLinq.Benchmark/ArrayOfIntSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|              Method |       Mean |    Error |   StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |-----------:|---------:|---------:|------:|-------:|------:|------:|----------:|
|           Handmaded |   641.2 ns |  8.73 ns |  8.16 ns |  0.15 |      - |     - |     - |         - |
|                LINQ | 4,257.4 ns | 83.82 ns | 99.78 ns |  1.00 | 0.0076 |     - |     - |      32 B |
| StructLinqZeroAlloc |   622.3 ns |  9.07 ns |  8.48 ns |  0.15 |      - |     - |     - |         - |
|          StructLinq |   782.4 ns | 11.52 ns |  9.62 ns |  0.18 | 0.0076 |     - |     - |      32 B |
