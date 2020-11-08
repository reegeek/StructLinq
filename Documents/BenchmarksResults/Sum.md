## Sum

### Source
[Sum.cs](../../src/StructLinq.Benchmark/Sum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100-preview.7.20366.6
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  DefaultJob : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT


```
|           Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
|           ForSum |  2.612 us | 0.0230 us | 0.0215 us |  1.00 |    0.00 |     - |     - |     - |         - |
|           SysSum | 39.377 us | 0.4302 us | 0.4024 us | 15.07 |    0.22 |     - |     - |     - |      40 B |
|        StructSum |  2.650 us | 0.0202 us | 0.0189 us |  1.01 |    0.01 |     - |     - |     - |         - |
| StructForEachSum |  2.650 us | 0.0164 us | 0.0154 us |  1.01 |    0.01 |     - |     - |     - |         - |
|       ConvertSum | 36.773 us | 0.2229 us | 0.1976 us | 14.07 |    0.13 |     - |     - |     - |      40 B |
