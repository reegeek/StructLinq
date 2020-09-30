## Sum

### Source
[Sum.cs](../../src/StructLinq.Benchmark/Sum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|           Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
|           ForSum |  2.822 us | 0.0067 us | 0.0059 us |  1.00 |    0.00 |     - |     - |     - |         - |
|           SysSum | 42.149 us | 0.0726 us | 0.0643 us | 14.94 |    0.04 |     - |     - |     - |      40 B |
|        StructSum |  2.852 us | 0.0045 us | 0.0042 us |  1.01 |    0.00 |     - |     - |     - |         - |
| StructForEachSum |  2.858 us | 0.0068 us | 0.0063 us |  1.01 |    0.00 |     - |     - |     - |         - |
|       ConvertSum | 42.165 us | 0.0595 us | 0.0527 us | 14.94 |    0.03 |     - |     - |     - |      40 B |
