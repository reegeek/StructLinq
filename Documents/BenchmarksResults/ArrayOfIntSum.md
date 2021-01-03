## ArrayOfIntSum

### Source
[ArrayOfIntSum.cs](../../src/StructLinq.Benchmark/ArrayOfIntSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|                         Method |       Mean |    Error |   StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------- |-----------:|---------:|---------:|------:|-------:|------:|------:|----------:|
|                      Handmaded |   533.5 ns |  2.43 ns |  2.15 ns |  0.14 |      - |     - |     - |         - |
|                 EnumerableLINQ | 4,031.8 ns | 18.17 ns | 16.10 ns |  1.07 |      - |     - |     - |      32 B |
|                      ArrayLINQ | 3,778.4 ns | 14.34 ns | 13.41 ns |  1.00 | 0.0038 |     - |     - |      32 B |
|            StructLinqZeroAlloc |   535.8 ns |  2.24 ns |  2.10 ns |  0.14 |      - |     - |     - |         - |
|                     StructLinq |   653.5 ns |  2.52 ns |  2.36 ns |  0.17 | 0.0067 |     - |     - |      32 B |
| StructLinqZeroAllocWithVisitor |   763.1 ns |  4.15 ns |  3.68 ns |  0.20 |      - |     - |     - |         - |
