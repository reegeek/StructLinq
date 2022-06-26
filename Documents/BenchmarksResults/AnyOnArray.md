## AnyOnArray

### Source
[AnyOnArray.cs](../../src/StructLinq.Benchmark/AnyOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|                       Method |       Mean |    Error |   StdDev | Ratio |  Gen 0 | Allocated |
|----------------------------- |-----------:|---------:|---------:|------:|-------:|----------:|
|                          For |   269.6 ns |  1.23 ns |  1.09 ns |  0.10 |      - |         - |
|                         Linq | 2,737.8 ns | 46.55 ns | 43.54 ns |  1.00 | 0.0038 |      32 B |
|                   StructLinq |   946.2 ns | 18.40 ns | 17.21 ns |  0.35 | 0.0057 |      32 B |
|          StructLinqZeroAlloc |   905.9 ns |  2.73 ns |  2.42 ns |  0.33 |      - |         - |
| StructLinqIFunctionZeroAlloc |   264.8 ns |  1.06 ns |  0.94 ns |  0.10 |      - |         - |
