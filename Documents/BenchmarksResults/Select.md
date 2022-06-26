## Select

### Source
[Select.cs](../../src/StructLinq.Benchmark/Select.cs)

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
|      SysSelect | 60.02 μs | 0.464 μs | 0.434 μs |  1.00 |      88 B |
| DelegateSelect | 18.15 μs | 0.117 μs | 0.110 μs |  0.30 |      56 B |
|   StructSelect | 10.32 μs | 0.049 μs | 0.044 μs |  0.17 |         - |
|  ConvertSelect | 39.00 μs | 0.227 μs | 0.201 μs |  0.65 |      40 B |
