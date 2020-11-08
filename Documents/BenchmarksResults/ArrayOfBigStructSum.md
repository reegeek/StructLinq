## ArrayOfBigStructSum

### Source
[ArrayOfBigStructSum.cs](../../src/StructLinq.Benchmark/ArrayOfBigStructSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100-preview.7.20366.6
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  DefaultJob : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT


```
|                Method |       Mean |    Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |-----------:|---------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|             Handmaded |   799.6 ns |  4.87 ns |   4.55 ns |  0.14 |    0.00 |      - |     - |     - |         - |
|      SysEnumerableSum | 5,861.1 ns | 34.26 ns |  28.61 ns |  1.00 |    0.00 |      - |     - |     - |      32 B |
|             StructSum | 3,253.7 ns | 30.06 ns |  28.12 ns |  0.55 |    0.01 | 0.0038 |     - |     - |      32 B |
|          RefStructSum | 1,886.6 ns | 22.74 ns |  18.99 ns |  0.32 |    0.00 | 0.0057 |     - |     - |      32 B |
|    ZeroAllocStructSum | 2,337.6 ns | 46.23 ns | 110.75 ns |  0.38 |    0.02 |      - |     - |     - |         - |
| ZeroAllocRefStructSum |   716.5 ns |  6.18 ns |   5.78 ns |  0.12 |    0.00 |      - |     - |     - |         - |
