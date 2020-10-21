## LastOnArray

### Source
[LastOnArray.cs](../../src/StructLinq.Benchmark/LastOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100-preview.7.20366.6
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  DefaultJob : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT


```
|              Method |        Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |------------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
|                Linq |    28.54 ns | 0.331 ns | 0.310 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|      EnumerableLinq |    28.71 ns | 0.352 ns | 0.329 ns |  1.01 |    0.02 |      - |     - |     - |         - |
|          StructLinq | 1,303.06 ns | 7.074 ns | 5.907 ns | 45.62 |    0.54 | 0.0057 |     - |     - |      32 B |
| StructLinqZeroAlloc | 1,245.69 ns | 6.048 ns | 5.361 ns | 43.61 |    0.45 |      - |     - |     - |         - |
