## Where

### Source
[Where.cs](../../src/StructLinq.Benchmark/Where.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|         Method |      Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------- |----------:|---------:|---------:|------:|------:|------:|------:|----------:|
|      SysSelect | 108.12 us | 0.329 us | 0.308 us |  1.00 |     - |     - |     - |      96 B |
| DelegateSelect |  40.10 us | 0.146 us | 0.136 us |  0.37 |     - |     - |     - |      56 B |
|   StructSelect |  22.48 us | 0.262 us | 0.245 us |  0.21 |     - |     - |     - |         - |
|  ConvertSelect |  61.83 us | 0.085 us | 0.080 us |  0.57 |     - |     - |     - |      40 B |
