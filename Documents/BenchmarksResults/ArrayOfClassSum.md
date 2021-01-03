## ArrayOfClassSum

### Source
[ArrayOfClassSum.cs](../../src/StructLinq.Benchmark/ArrayOfClassSum.cs)

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
|                      Handmaded |   760.3 ns |  4.60 ns |  4.08 ns |  0.13 |      - |     - |     - |         - |
|                        LINQSum | 5,967.7 ns | 95.46 ns | 89.29 ns |  1.00 | 0.0076 |     - |     - |      48 B |
|                     StructLinq | 1,790.2 ns |  6.16 ns |  5.46 ns |  0.30 | 0.0134 |     - |     - |      64 B |
|          StructLinqWithVisitor | 4,087.4 ns | 47.84 ns | 44.75 ns |  0.69 | 0.0076 |     - |     - |      40 B |
|            StructLinqZeroAlloc |   602.3 ns |  2.41 ns |  2.26 ns |  0.10 |      - |     - |     - |         - |
| StructLinqZeroAllocWithVisitor | 3,048.0 ns | 33.24 ns | 27.76 ns |  0.51 |      - |     - |     - |         - |
