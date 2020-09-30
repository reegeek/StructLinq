## ArrayOfIntSum

### Source
[ArrayOfIntSum.cs](../../src/StructLinq.Benchmark/ArrayOfIntSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|           Method |       Mean |   Error |  StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------- |-----------:|--------:|--------:|------:|-------:|------:|------:|----------:|
|           SysSum |   585.0 ns | 1.34 ns | 1.26 ns |  0.14 |      - |     - |     - |         - |
| SysEnumerableSum | 4,240.8 ns | 9.10 ns | 8.06 ns |  1.00 | 0.0076 |     - |     - |      32 B |
|       ConvertSum | 4,798.5 ns | 5.86 ns | 5.48 ns |  1.13 | 0.0076 |     - |     - |      32 B |
|        StructSum |   589.7 ns | 1.09 ns | 1.02 ns |  0.14 |      - |     - |     - |         - |
