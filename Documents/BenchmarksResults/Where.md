## Where

### Source
[Where.cs](../../src/StructLinq.Benchmark/Where.cs)

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
|      SysSelect | 91.00 μs | 0.393 μs | 0.368 μs |  1.00 |     - |     - |     - |      96 B |    1067 B |
| DelegateSelect | 30.58 μs | 0.382 μs | 0.357 μs |  0.34 |     - |     - |     - |      56 B |     294 B |
|   StructSelect | 22.75 μs | 0.070 μs | 0.065 μs |  0.25 |     - |     - |     - |         - |     472 B |
|  ConvertSelect | 52.65 μs | 0.234 μs | 0.219 μs |  0.58 |     - |     - |     - |      40 B |     725 B |
