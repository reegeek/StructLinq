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
|         Method |     Mean |    Error |   StdDev | Ratio | Code Size | Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------- |---------:|---------:|---------:|------:|----------:|------:|------:|------:|----------:|
|      SysSelect | 55.66 μs | 0.266 μs | 0.236 μs |  1.00 |    1346 B |     - |     - |     - |      88 B |
| DelegateSelect | 21.06 μs | 0.043 μs | 0.038 μs |  0.38 |     313 B |     - |     - |     - |      56 B |
|   StructSelect | 17.15 μs | 0.044 μs | 0.041 μs |  0.31 |     578 B |     - |     - |     - |         - |
|  ConvertSelect | 40.45 μs | 0.168 μs | 0.158 μs |  0.73 |     839 B |     - |     - |     - |      40 B |
