## Sum

### Source
[Sum.cs](../../src/StructLinq.Benchmark/Sum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100-preview.7.20366.6
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  DefaultJob : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT


```
|           Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
|           ForSum |  2.657 us | 0.0316 us | 0.0296 us |  1.00 |    0.00 |     - |     - |     - |         - |
|           SysSum | 40.003 us | 0.3040 us | 0.2539 us | 15.04 |    0.18 |     - |     - |     - |      40 B |
|        StructSum |  2.685 us | 0.0234 us | 0.0219 us |  1.01 |    0.01 |     - |     - |     - |         - |
| StructForEachSum |  2.676 us | 0.0170 us | 0.0159 us |  1.01 |    0.01 |     - |     - |     - |         - |
|       ConvertSum | 37.297 us | 0.3539 us | 0.3137 us | 14.03 |    0.23 |     - |     - |     - |      40 B |
|      WithVisitor |  5.207 us | 0.0118 us | 0.0099 us |  1.96 |    0.02 |     - |     - |     - |         - |
