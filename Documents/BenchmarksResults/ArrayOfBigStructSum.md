## ArrayOfBigStructSum

### Source
[ArrayOfBigStructSum.cs](../../src/StructLinq.Benchmark/ArrayOfBigStructSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|                Method |       Mean |    Error |   StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |-----------:|---------:|---------:|------:|-------:|------:|------:|----------:|
|                ForSum |   613.3 ns |  1.19 ns |  1.06 ns |  0.10 |      - |     - |     - |         - |
|      SysEnumerableSum | 5,982.1 ns | 10.64 ns |  8.89 ns |  1.00 | 0.0076 |     - |     - |      32 B |
|             StructSum | 3,675.6 ns | 56.62 ns | 52.96 ns |  0.61 | 0.0076 |     - |     - |      32 B |
|          RefStructSum | 2,003.0 ns |  4.87 ns |  4.56 ns |  0.33 | 0.0076 |     - |     - |      32 B |
|    ZeroAllocStructSum | 2,275.9 ns | 42.85 ns | 35.79 ns |  0.38 |      - |     - |     - |         - |
| ZeroAllocRefStructSum |   766.0 ns |  1.32 ns |  1.24 ns |  0.13 |      - |     - |     - |         - |
