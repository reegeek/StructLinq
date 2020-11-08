## ArrayOfIntSum

### Source
[ArrayOfIntSum.cs](../../src/StructLinq.Benchmark/ArrayOfIntSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100-preview.7.20366.6
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  DefaultJob : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT


```
|     Method |       Mean |    Error |   StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------- |-----------:|---------:|---------:|------:|--------:|------:|------:|------:|----------:|
|  Handmaded |   565.0 ns |  8.02 ns |  7.51 ns |  1.00 |    0.00 |     - |     - |     - |         - |
|       LINQ | 3,981.3 ns | 45.85 ns | 42.89 ns |  7.05 |    0.11 |     - |     - |     - |      32 B |
| StructLinq |   547.2 ns |  2.95 ns |  2.61 ns |  0.97 |    0.01 |     - |     - |     - |         - |
