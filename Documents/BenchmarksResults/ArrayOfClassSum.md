## ArrayOfClassSum

### Source
[ArrayOfClassSum.cs](../../src/StructLinq.Benchmark/ArrayOfClassSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|           Method |       Mean |    Error |   StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------- |-----------:|---------:|---------:|------:|-------:|------:|------:|----------:|
|           SysSum |   763.2 ns |  3.34 ns |  2.96 ns |  0.13 |      - |     - |     - |         - |
| SysEnumerableSum | 5,938.3 ns | 27.29 ns | 21.30 ns |  1.00 | 0.0076 |     - |     - |      48 B |
|        StructSum | 1,555.9 ns |  7.10 ns |  6.29 ns |  0.26 |      - |     - |     - |         - |
