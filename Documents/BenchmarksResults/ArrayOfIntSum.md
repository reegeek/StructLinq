## ArrayOfIntSum

### Source
[ArrayOfIntSum.cs](../../src/StructLinq.Benchmark/ArrayOfIntSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19043.1081 (21H1/May2021Update)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=5.0.301
  [Host]     : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT
  DefaultJob : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT


```
|                         Method |       Mean |    Error |   StdDev |     Median | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------- |-----------:|---------:|---------:|-----------:|------:|-------:|------:|------:|----------:|
|                      Handmaded |   583.7 ns | 11.79 ns | 33.83 ns |   568.4 ns |  0.14 |      - |     - |     - |         - |
|                 EnumerableLINQ | 3,997.3 ns | 13.65 ns | 12.77 ns | 3,992.6 ns |  1.00 |      - |     - |     - |      32 B |
|                      ArrayLINQ | 3,986.1 ns | 15.33 ns | 13.59 ns | 3,986.5 ns |  1.00 |      - |     - |     - |      32 B |
|            StructLinqZeroAlloc |   395.2 ns |  1.44 ns |  1.28 ns |   395.3 ns |  0.10 |      - |     - |     - |         - |
|                     StructLinq |   527.7 ns |  2.00 ns |  1.87 ns |   528.5 ns |  0.13 | 0.0067 |     - |     - |      32 B |
| StructLinqZeroAllocWithVisitor |   393.9 ns |  1.40 ns |  1.24 ns |   393.4 ns |  0.10 |      - |     - |     - |         - |
