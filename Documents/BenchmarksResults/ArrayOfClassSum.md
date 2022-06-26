## ArrayOfClassSum

### Source
[ArrayOfClassSum.cs](../../src/StructLinq.Benchmark/ArrayOfClassSum.cs)

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
|                      Handmaded |   517.6 ns |  1.56 ns |  1.31 ns |  0.09 |      - |         - |
|                        LINQSum | 5,701.1 ns | 13.27 ns | 12.41 ns |  1.00 | 0.0076 |      48 B |
|                     StructLinq | 1,833.2 ns |  5.14 ns |  4.80 ns |  0.32 | 0.0134 |      64 B |
|          StructLinqWithVisitor | 5,177.2 ns | 22.00 ns | 20.58 ns |  0.91 | 0.0076 |      40 B |
|            StructLinqZeroAlloc |   794.1 ns |  2.92 ns |  2.59 ns |  0.14 |      - |         - |
| StructLinqZeroAllocWithVisitor | 2,833.1 ns |  9.34 ns |  8.73 ns |  0.50 |      - |         - |
