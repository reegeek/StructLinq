## ArrayOfBigStructSum

### Source
[ArrayOfBigStructSum.cs](../../src/StructLinq.Benchmark/ArrayOfBigStructSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|                Method |       Mean |    Error |   StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |-----------:|---------:|---------:|------:|-------:|------:|------:|----------:|
|                ForSum |   556.2 ns |  1.72 ns |  1.53 ns |  0.09 |      - |     - |     - |         - |
|      SysEnumerableSum | 6,167.5 ns | 40.66 ns | 31.75 ns |  1.00 |      - |     - |     - |      32 B |
|             StructSum | 3,345.1 ns | 51.62 ns | 48.28 ns |  0.54 | 0.0038 |     - |     - |      32 B |
|          RefStructSum | 2,577.4 ns |  8.49 ns |  7.09 ns |  0.42 | 0.0038 |     - |     - |      32 B |
|    ZeroAllocStructSum | 2,231.6 ns | 10.44 ns |  9.77 ns |  0.36 |      - |     - |     - |         - |
| ZeroAllocRefStructSum |   691.1 ns |  2.19 ns |  2.05 ns |  0.11 |      - |     - |     - |         - |
