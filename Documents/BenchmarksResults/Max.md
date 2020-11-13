## Max

### Source
[Max.cs](../../src/StructLinq.Benchmark/Max.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|             Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Code Size | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------- |----------:|----------:|----------:|------:|--------:|----------:|------:|------:|------:|----------:|
|             RawMax |  8.964 μs | 0.1678 μs | 0.1648 μs |  1.00 |    0.00 |      24 B |     - |     - |     - |         - |
|             SysMax | 40.230 μs | 0.1055 μs | 0.0935 μs |  4.49 |    0.09 |     519 B |     - |     - |     - |      40 B |
|          StructMax | 13.074 μs | 0.0582 μs | 0.0545 μs |  1.46 |    0.03 |     177 B |     - |     - |     - |      24 B |
| ZeroAllocStructMax | 13.134 μs | 0.0589 μs | 0.0551 μs |  1.47 |    0.03 |     257 B |     - |     - |     - |         - |
|         ConvertMax | 40.225 μs | 0.1683 μs | 0.1574 μs |  4.49 |    0.10 |     526 B |     - |     - |     - |      64 B |
