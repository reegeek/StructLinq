## ArraySelectCount

### Source
[ArraySelectCount.cs](../../src/StructLinq.Benchmark/ArraySelectCount.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|              Method |         Mean |     Error |    StdDev | Ratio |  Gen 0 | Allocated |
|-------------------- |-------------:|----------:|----------:|------:|-------:|----------:|
|                Linq | 17,991.73 ns | 93.310 ns | 87.282 ns | 1.000 |      - |      48 B |
|          StructLinq |     15.21 ns |  0.032 ns |  0.029 ns | 0.001 | 0.0136 |      64 B |
| StructLinqZeroAlloc |     10.34 ns |  0.033 ns |  0.029 ns | 0.001 |      - |         - |
