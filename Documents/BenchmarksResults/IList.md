## IList

### Source
[IList.cs](../../src/StructLinq.Benchmark/IList.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|     Method |     Mean |    Error |   StdDev | Ratio | Allocated |
|----------- |---------:|---------:|---------:|------:|----------:|
|       Linq | 60.48 μs | 0.911 μs | 0.894 μs |  1.00 |      40 B |
| StructLinq | 20.97 μs | 0.334 μs | 0.296 μs |  0.35 |         - |
