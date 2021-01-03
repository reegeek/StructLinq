## Where

### Source
[Where.cs](../../src/StructLinq.Benchmark/Where.cs)

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
|      SysSelect | 89.55 μs | 0.424 μs | 0.376 μs |  1.00 |    1067 B |     - |     - |     - |      96 B |
| DelegateSelect | 20.09 μs | 0.084 μs | 0.078 μs |  0.22 |     277 B |     - |     - |     - |      56 B |
|   StructSelect | 13.48 μs | 0.043 μs | 0.040 μs |  0.15 |     477 B |     - |     - |     - |         - |
|  ConvertSelect | 37.55 μs | 0.086 μs | 0.071 μs |  0.42 |     842 B |     - |     - |     - |      40 B |
