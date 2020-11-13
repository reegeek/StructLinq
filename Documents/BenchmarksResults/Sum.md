## Sum

### Source
[Sum.cs](../../src/StructLinq.Benchmark/Sum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|           Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated | Code Size |
|----------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|----------:|
|           ForSum |  2.523 μs | 0.0074 μs | 0.0070 μs |  1.00 |    0.00 |     - |     - |     - |         - |      17 B |
|           SysSum | 37.644 μs | 0.2018 μs | 0.1888 μs | 14.92 |    0.09 |     - |     - |     - |      40 B |     445 B |
|        StructSum |  2.519 μs | 0.0092 μs | 0.0076 μs |  1.00 |    0.00 |     - |     - |     - |         - |     134 B |
| StructForEachSum |  2.520 μs | 0.0108 μs | 0.0101 μs |  1.00 |    0.00 |     - |     - |     - |         - |      22 B |
|       ConvertSum | 40.200 μs | 0.1358 μs | 0.1270 μs | 15.94 |    0.06 |     - |     - |     - |      40 B |     470 B |
