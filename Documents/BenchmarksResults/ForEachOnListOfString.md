## ForEachOnListOfString

### Source
[ForEachOnListOfString.cs](../../src/StructLinq.Benchmark/ForEachOnListOfString.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|     Method |      Mean |     Error |    StdDev |    Median | Ratio | Allocated |
|----------- |----------:|----------:|----------:|----------:|------:|----------:|
|    Default | 15.320 μs | 0.0556 μs | 0.0464 μs | 15.322 μs |  1.00 |         - |
| StructLinq |  7.240 μs | 0.1419 μs | 0.2124 μs |  7.387 μs |  0.48 |         - |
