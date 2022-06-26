## ForEachOnList

### Source
[ForEachOnList.cs](../../src/StructLinq.Benchmark/ForEachOnList.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|     Method |      Mean |     Error |    StdDev | Ratio | Allocated |
|----------- |----------:|----------:|----------:|------:|----------:|
|    Default | 12.747 μs | 0.0293 μs | 0.0274 μs |  1.00 |         - |
| StructLinq |  4.544 μs | 0.0486 μs | 0.0454 μs |  0.36 |         - |
