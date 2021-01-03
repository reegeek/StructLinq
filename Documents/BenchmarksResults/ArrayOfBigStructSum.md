## ArrayOfBigStructSum

### Source
[ArrayOfBigStructSum.cs](../../src/StructLinq.Benchmark/ArrayOfBigStructSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                Method |       Mean |    Error |   StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |-----------:|---------:|---------:|------:|-------:|------:|------:|----------:|
|             Handmaded |   543.0 ns |  2.64 ns |  2.47 ns |  0.09 |      - |     - |     - |         - |
|      SysEnumerableSum | 6,046.0 ns | 27.55 ns | 25.77 ns |  1.00 |      - |     - |     - |      32 B |
|             StructSum | 3,207.4 ns | 16.92 ns | 15.83 ns |  0.53 | 0.0038 |     - |     - |      32 B |
|          RefStructSum | 1,853.3 ns |  6.07 ns |  5.68 ns |  0.31 | 0.0057 |     - |     - |      32 B |
|    ZeroAllocStructSum | 2,195.7 ns | 25.33 ns | 23.69 ns |  0.36 |      - |     - |     - |         - |
| ZeroAllocRefStructSum |   682.9 ns |  2.28 ns |  2.13 ns |  0.11 |      - |     - |     - |         - |
