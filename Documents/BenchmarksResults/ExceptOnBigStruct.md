## ExceptOnBigStruct

### Source
[ExceptOnBigStruct.cs](../../src/StructLinq.Benchmark/ExceptOnBigStruct.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|                    Method |     Mean |   Error |  StdDev | Ratio |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
|-------------------------- |---------:|--------:|--------:|------:|---------:|---------:|---------:|----------:|
|                      Linq | 554.4 μs | 5.22 μs | 4.89 μs |  1.00 | 249.0234 | 249.0234 | 249.0234 | 863,588 B |
|                StructLinq | 219.4 μs | 1.08 μs | 1.01 μs |  0.40 |        - |        - |        - |         - |
|             RefStructLinq | 183.7 μs | 0.70 μs | 0.55 μs |  0.33 |        - |        - |        - |         - |
| RefStructLinqWithComparer | 171.2 μs | 0.49 μs | 0.43 μs |  0.31 |        - |        - |        - |         - |
