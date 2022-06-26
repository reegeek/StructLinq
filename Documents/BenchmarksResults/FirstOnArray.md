## FirstOnArray

### Source
[FirstOnArray.cs](../../src/StructLinq.Benchmark/FirstOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|              Method |      Mean |     Error |    StdDev | Ratio |  Gen 0 | Allocated |
|-------------------- |----------:|----------:|----------:|------:|-------:|----------:|
|                Linq | 18.887 ns | 0.0587 ns | 0.0520 ns |  1.00 |      - |         - |
|      EnumerableLinq | 18.923 ns | 0.0514 ns | 0.0481 ns |  1.00 |      - |         - |
|          StructLinq | 10.925 ns | 0.0378 ns | 0.0335 ns |  0.58 | 0.0068 |      32 B |
| StructLinqZeroAlloc |  2.511 ns | 0.0073 ns | 0.0065 ns |  0.13 |      - |         - |
