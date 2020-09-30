## Select

### Source
[Select.cs](../../src/StructLinq.Benchmark/Select.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|         Method |     Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------- |---------:|---------:|---------:|------:|------:|------:|------:|----------:|
|      SysSelect | 59.13 us | 0.118 us | 0.111 us |  1.00 |     - |     - |     - |      88 B |
| DelegateSelect | 22.55 us | 0.031 us | 0.027 us |  0.38 |     - |     - |     - |      56 B |
|   StructSelect | 19.09 us | 0.015 us | 0.014 us |  0.32 |     - |     - |     - |         - |
|  ConvertSelect | 44.99 us | 0.056 us | 0.053 us |  0.76 |     - |     - |     - |      40 B |
