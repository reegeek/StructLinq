## ArrayOfClassSum

### Source
[ArrayOfClassSum.cs](../../src/StructLinq.Benchmark/ArrayOfClassSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|           Method |       Mean |    Error |   StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------- |-----------:|---------:|---------:|------:|-------:|------:|------:|----------:|
|           SysSum |   515.2 ns |  1.41 ns |  1.32 ns |  0.09 |      - |     - |     - |         - |
| SysEnumerableSum | 5,782.8 ns | 18.35 ns | 17.16 ns |  1.00 | 0.0076 |     - |     - |      48 B |
|        StructSum | 1,745.9 ns |  2.49 ns |  2.33 ns |  0.30 |      - |     - |     - |         - |
