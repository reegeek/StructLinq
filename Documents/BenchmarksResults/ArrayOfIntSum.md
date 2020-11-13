## ArrayOfIntSum

### Source
[ArrayOfIntSum.cs](../../src/StructLinq.Benchmark/ArrayOfIntSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|           Method |       Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------- |-----------:|---------:|---------:|------:|------:|------:|------:|----------:|
|           SysSum |   547.0 ns |  5.39 ns |  5.04 ns |  0.14 |     - |     - |     - |         - |
| SysEnumerableSum | 3,916.6 ns | 20.04 ns | 18.75 ns |  1.00 |     - |     - |     - |      32 B |
|       ConvertSum | 3,816.0 ns | 13.92 ns | 13.02 ns |  0.97 |     - |     - |     - |      32 B |
|        StructSum |   529.9 ns |  2.10 ns |  1.86 ns |  0.14 |     - |     - |     - |         - |
