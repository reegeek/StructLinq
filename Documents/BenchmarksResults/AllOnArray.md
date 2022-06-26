## AllOnArray

### Source
[AllOnArray.cs](../../src/StructLinq.Benchmark/AllOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|                                         Method |       Mean |    Error |   StdDev | Ratio |  Gen 0 | Allocated |
|----------------------------------------------- |-----------:|---------:|---------:|------:|-------:|----------:|
|                                            For |   179.4 ns |  1.03 ns |  0.96 ns |  0.06 |      - |         - |
|                                           Linq | 3,078.9 ns | 23.24 ns | 18.14 ns |  1.00 | 0.0038 |      32 B |
|                                     StructLinq |   797.6 ns |  2.18 ns |  1.82 ns |  0.26 | 0.0067 |      32 B |
|                            StructLinqZeroAlloc |   908.0 ns |  3.07 ns |  2.40 ns |  0.29 |      - |         - |
|                   StructLinqIFunctionZeroAlloc |   174.0 ns |  0.30 ns |  0.23 ns |  0.06 |      - |         - |
| StructLinqIFunctionZeroAllocOnStructEnumerable |   174.2 ns |  0.58 ns |  0.54 ns |  0.06 |      - |         - |
