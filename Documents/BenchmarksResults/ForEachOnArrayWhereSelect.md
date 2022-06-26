## ForEachOnArrayWhereSelect

### Source
[ForEachOnArrayWhereSelect.cs](../../src/StructLinq.Benchmark/ForEachOnArrayWhereSelect.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|                             Method |     Mean |    Error |   StdDev | Allocated |
|----------------------------------- |---------:|---------:|---------:|----------:|
|                            SysLinq | 49.06 μs | 0.108 μs | 0.084 μs |     104 B |
|             StructLinqWithDelegate | 28.79 μs | 0.104 μs | 0.098 μs |         - |
| StructLinqWithDelegateAsEnumerable | 56.13 μs | 0.109 μs | 0.097 μs |     104 B |
|                         StructLinq | 14.01 μs | 0.043 μs | 0.038 μs |         - |
|             StructLinqAsEnumerable | 35.96 μs | 0.221 μs | 0.206 μs |     104 B |
