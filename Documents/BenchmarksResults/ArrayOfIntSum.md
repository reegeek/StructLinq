## ArrayOfIntSum

### Source
[ArrayOfIntSum.cs](../../src/StructLinq.Benchmark/ArrayOfIntSum.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100-preview.7.20366.6
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  DefaultJob : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT


```
|    Method |     Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |---------:|---------:|---------:|------:|------:|------:|------:|----------:|
|    SysSum | 63.72 ns | 0.454 ns | 0.402 ns |  1.00 |     - |     - |     - |         - |
| StructSum | 61.19 ns | 0.578 ns | 0.541 ns |  0.96 |     - |     - |     - |         - |
| WithVisit | 58.75 ns | 0.440 ns | 0.411 ns |  0.92 |     - |     - |     - |         - |
