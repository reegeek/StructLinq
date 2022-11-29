## ArrayOfBigStructSum

### Source
[ArrayOfBigStructSum.cs](../../src/StructLinq.Benchmark/ArrayOfBigStructSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                Method |       Mean |    Error |   StdDev | Ratio |   Gen0 | Allocated | Alloc Ratio |
|---------------------- |-----------:|---------:|---------:|------:|-------:|----------:|------------:|
|             Handmaded |   515.3 ns |  1.54 ns |  1.44 ns |  0.10 |      - |         - |        0.00 |
|      SysEnumerableSum | 5,366.5 ns | 32.26 ns | 28.59 ns |  1.00 |      - |      32 B |        1.00 |
|             StructSum | 2,304.5 ns | 10.64 ns |  9.43 ns |  0.43 | 0.0038 |      32 B |        1.00 |
|          RefStructSum | 2,042.3 ns |  7.23 ns |  5.64 ns |  0.38 | 0.0038 |      32 B |        1.00 |
|    ZeroAllocStructSum |   954.6 ns | 19.08 ns | 28.55 ns |  0.18 |      - |         - |        0.00 |
| ZeroAllocRefStructSum |   556.3 ns |  1.15 ns |  0.96 ns |  0.10 |      - |         - |        0.00 |
