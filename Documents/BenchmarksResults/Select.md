## Select

### Source
[Select.cs](../../src/StructLinq.Benchmark/Select.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|         Method |     Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated | Code Size |
|--------------- |---------:|---------:|---------:|------:|------:|------:|------:|----------:|----------:|
|      SysSelect | 55.89 μs | 0.329 μs | 0.291 μs |  1.00 |     - |     - |     - |      88 B |    1346 B |
| DelegateSelect | 17.85 μs | 0.108 μs | 0.101 μs |  0.32 |     - |     - |     - |      56 B |     313 B |
|   StructSelect | 17.13 μs | 0.054 μs | 0.051 μs |  0.31 |     - |     - |     - |         - |     578 B |
|  ConvertSelect | 37.69 μs | 0.172 μs | 0.153 μs |  0.67 |     - |     - |     - |      40 B |     839 B |
