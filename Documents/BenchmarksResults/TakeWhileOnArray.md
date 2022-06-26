## TakeWhileOnArray

### Source
[TakeWhileOnArray.cs](../../src/StructLinq.Benchmark/TakeWhileOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|                      Method |     Mean |    Error |   StdDev | Ratio |  Gen 0 | Allocated |
|---------------------------- |---------:|---------:|---------:|------:|-------:|----------:|
|                        Linq | 38.36 ns | 0.340 ns | 0.301 ns |  1.00 | 0.0221 |     104 B |
|                  StructLinq | 22.79 ns | 0.123 ns | 0.115 ns |  0.59 | 0.0068 |      32 B |
|         StructLinqZeroAlloc | 22.49 ns | 0.165 ns | 0.155 ns |  0.59 |      - |         - |
| StructLinqFunctionZeroAlloc | 22.43 ns | 0.125 ns | 0.110 ns |  0.58 |      - |         - |
