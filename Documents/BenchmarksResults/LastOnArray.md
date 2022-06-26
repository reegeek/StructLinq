## LastOnArray

### Source
[LastOnArray.cs](../../src/StructLinq.Benchmark/LastOnArray.cs)

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
|                Linq | 19.279 ns | 0.0894 ns | 0.0793 ns |  1.00 |      - |         - |
|      EnumerableLinq | 18.882 ns | 0.3072 ns | 0.2873 ns |  0.98 |      - |         - |
|          StructLinq | 14.112 ns | 0.1742 ns | 0.1454 ns |  0.73 | 0.0068 |      32 B |
| StructLinqZeroAlloc |  3.474 ns | 0.0314 ns | 0.0279 ns |  0.18 |      - |         - |
