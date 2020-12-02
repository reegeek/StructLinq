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
|                Linq | 28.698 ns | 0.4468 ns | 0.4180 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|      EnumerableLinq | 28.787 ns | 0.6020 ns | 0.5631 ns |  1.00 |    0.03 |      - |     - |     - |         - |
|          StructLinq | 14.799 ns | 0.2655 ns | 0.2484 ns |  0.52 |    0.01 | 0.0068 |     - |     - |      32 B |
| StructLinqZeroAlloc |  3.737 ns | 0.0544 ns | 0.0482 ns |  0.13 |    0.00 |      - |     - |     - |         - |
