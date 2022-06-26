## ArrayOfIntSum

### Source
[ArrayOfIntSum.cs](../../src/StructLinq.Benchmark/ArrayOfIntSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|                         Method |       Mean |    Error |   StdDev | Ratio |  Gen 0 | Allocated |
|------------------------------- |-----------:|---------:|---------:|------:|-------:|----------:|
|                      Handmaded |   541.4 ns |  1.98 ns |  1.85 ns |  0.12 |      - |         - |
|                 EnumerableLINQ | 4,361.4 ns | 15.94 ns | 13.31 ns |  1.00 |      - |      32 B |
|                      ArrayLINQ | 4,374.8 ns | 44.17 ns | 34.48 ns |  1.00 |      - |      32 B |
|            StructLinqZeroAlloc |   542.8 ns |  2.35 ns |  1.96 ns |  0.12 |      - |         - |
|                     StructLinq |   605.4 ns |  5.81 ns |  4.53 ns |  0.14 | 0.0067 |      32 B |
| StructLinqZeroAllocWithVisitor |   386.1 ns |  1.31 ns |  1.16 ns |  0.09 |      - |         - |
