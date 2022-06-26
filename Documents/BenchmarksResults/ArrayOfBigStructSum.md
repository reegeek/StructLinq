## ArrayOfBigStructSum

### Source
[ArrayOfBigStructSum.cs](../../src/StructLinq.Benchmark/ArrayOfBigStructSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|                Method |       Mean |    Error |   StdDev | Ratio |  Gen 0 | Allocated |
|---------------------- |-----------:|---------:|---------:|------:|-------:|----------:|
|             Handmaded |   554.1 ns |  4.79 ns |  4.25 ns |  0.09 |      - |         - |
|      SysEnumerableSum | 5,915.5 ns | 35.31 ns | 33.03 ns |  1.00 |      - |      32 B |
|             StructSum | 2,845.7 ns |  9.42 ns |  8.35 ns |  0.48 | 0.0038 |      32 B |
|          RefStructSum | 1,907.8 ns | 19.48 ns | 17.26 ns |  0.32 | 0.0057 |      32 B |
|    ZeroAllocStructSum | 1,980.5 ns |  9.26 ns |  7.73 ns |  0.33 |      - |         - |
| ZeroAllocRefStructSum |   698.2 ns |  0.77 ns |  0.65 ns |  0.12 |      - |         - |
