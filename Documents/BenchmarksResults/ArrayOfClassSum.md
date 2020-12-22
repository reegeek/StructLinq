## ArrayOfClassSum

### Source
[ArrayOfClassSum.cs](../../src/StructLinq.Benchmark/ArrayOfClassSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


```
|             Method |       Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------- |-----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|          Handmaded |   554.7 ns |  11.12 ns |  16.98 ns |  0.07 |    0.00 |      - |     - |     - |         - |
|   SysEnumerableSum | 7,922.7 ns | 158.48 ns | 330.81 ns |  1.00 |    0.00 |      - |     - |     - |      48 B |
|          StructSum | 3,192.7 ns |  62.72 ns |  67.11 ns |  0.40 |    0.02 | 0.0153 |     - |     - |      64 B |
| StructSumZeroAlloc |   721.0 ns |  11.62 ns |  10.87 ns |  0.09 |    0.00 |      - |     - |     - |         - |
