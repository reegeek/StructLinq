## Where

### Source
[Where.cs](../../src/StructLinq.Benchmark/Where.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|         Method |     Mean |    Error |   StdDev | Ratio | Allocated |
|--------------- |---------:|---------:|---------:|------:|----------:|
|      SysSelect | 92.21 μs | 0.633 μs | 0.561 μs |  1.00 |      96 B |
| DelegateSelect | 18.23 μs | 0.151 μs | 0.134 μs |  0.20 |      56 B |
|   StructSelect | 13.97 μs | 0.157 μs | 0.147 μs |  0.15 |         - |
|  ConvertSelect | 38.91 μs | 0.132 μs | 0.103 μs |  0.42 |      40 B |
