## LastOnArray

### Source
[LastOnArray.cs](../../src/StructLinq.Benchmark/LastOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100-preview.7.20366.6
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  DefaultJob : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT


```
|              Method |      Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|                Linq | 29.253 ns | 0.3388 ns | 0.3169 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|      EnumerableLinq | 29.171 ns | 0.5949 ns | 0.6613 ns |  1.00 |    0.03 |      - |     - |     - |         - |
|          StructLinq | 17.395 ns | 0.3803 ns | 0.4809 ns |  0.60 |    0.02 | 0.0068 |     - |     - |      32 B |
| StructLinqZeroAlloc |  5.778 ns | 0.1087 ns | 0.1163 ns |  0.20 |    0.00 |      - |     - |     - |         - |
