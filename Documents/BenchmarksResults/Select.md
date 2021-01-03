## Select

### Source
[Select.cs](../../src/StructLinq.Benchmark/Select.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|         Method |     Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated | Code Size |
|--------------- |---------:|---------:|---------:|------:|------:|------:|------:|----------:|----------:|
|      SysSelect | 56.91 μs | 0.351 μs | 0.328 μs |  1.00 |     - |     - |     - |      88 B |    1346 B |
| DelegateSelect | 17.53 μs | 0.088 μs | 0.082 μs |  0.31 |     - |     - |     - |      56 B |     319 B |
|   StructSelect | 10.01 μs | 0.041 μs | 0.038 μs |  0.18 |     - |     - |     - |         - |     593 B |
|  ConvertSelect | 37.66 μs | 0.188 μs | 0.176 μs |  0.66 |     - |     - |     - |      40 B |     995 B |
