## Sum

### Source
[Sum.cs](../../src/StructLinq.Benchmark/Sum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|             Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Allocated |
|------------------- |----------:|----------:|----------:|------:|--------:|----------:|
|             ForSum |  2.595 μs | 0.0157 μs | 0.0147 μs |  1.00 |    0.00 |         - |
|             SysSum | 38.918 μs | 0.4186 μs | 0.3916 μs | 15.00 |    0.18 |      40 B |
|          StructSum |  5.165 μs | 0.0366 μs | 0.0324 μs |  1.99 |    0.01 |      24 B |
| StructSumZeroAlloc |  2.595 μs | 0.0132 μs | 0.0123 μs |  1.00 |    0.01 |         - |
|   StructForEachSum |  2.583 μs | 0.0102 μs | 0.0090 μs |  1.00 |    0.01 |         - |
|         ConvertSum | 36.165 μs | 0.2137 μs | 0.1999 μs | 13.94 |    0.12 |      40 B |
