## ArrayWhereCount

### Source
[ArrayWhereCount.cs](../../src/StructLinq.Benchmark/ArrayWhereCount.cs)

### Results:
``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  DefaultJob : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT


```
|                         Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Allocated |
|------------------------------- |----------:|----------:|----------:|------:|--------:|----------:|
|                  HandmadedCode |  7.010 μs | 0.0202 μs | 0.0189 μs |  1.00 |    0.00 |         - |
|                        SysLinq | 23.885 μs | 0.0938 μs | 0.0733 μs |  3.41 |    0.02 |      48 B |
|         StructLinqWithDelegate | 20.592 μs | 0.0612 μs | 0.0572 μs |  2.94 |    0.01 |      64 B |
| StructLinqWithDelegateZeoAlloc | 23.863 μs | 0.0898 μs | 0.0840 μs |  3.40 |    0.01 |         - |
|         StructLinqWithFunction |  6.967 μs | 0.0448 μs | 0.0419 μs |  0.99 |    0.01 |         - |
