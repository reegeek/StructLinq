## FirstOnArray

### Source
[FirstOnArray.cs](../../src/StructLinq.Benchmark/FirstOnArray.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.403
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  DefaultJob : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT


```
|              Method |      Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|                Linq | 29.568 ns | 0.4328 ns | 0.3836 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|      EnumerableLinq | 30.064 ns | 0.3751 ns | 0.3133 ns |  1.02 |    0.02 |      - |     - |     - |         - |
|          StructLinq | 12.935 ns | 0.1560 ns | 0.1218 ns |  0.44 |    0.01 | 0.0076 |     - |     - |      32 B |
| StructLinqZeroAlloc |  2.835 ns | 0.0360 ns | 0.0336 ns |  0.10 |    0.00 |      - |     - |     - |         - |
