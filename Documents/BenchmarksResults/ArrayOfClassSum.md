## ArrayOfClassSum

### Source
[ArrayOfClassSum.cs](../../src/StructLinq.Benchmark/ArrayOfClassSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100-preview.7.20366.6
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  DefaultJob : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT


```
|           Method |       Mean |    Error |   StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------- |-----------:|---------:|---------:|------:|-------:|------:|------:|----------:|
|        Handmaded |   790.2 ns |  5.93 ns |  5.25 ns |  0.13 |      - |     - |     - |         - |
| SysEnumerableSum | 6,192.9 ns | 61.36 ns | 57.39 ns |  1.00 | 0.0076 |     - |     - |      48 B |
|        StructSum | 3,671.3 ns | 30.31 ns | 26.87 ns |  0.59 |      - |     - |     - |         - |
