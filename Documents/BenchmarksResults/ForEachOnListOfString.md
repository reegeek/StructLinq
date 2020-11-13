## ForEachOnListOfString

### Source
[ForEachOnListOfString.cs](../../src/StructLinq.Benchmark/ForEachOnListOfString.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|     Method |      Mean |     Error |    StdDev |    Median | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------- |----------:|----------:|----------:|----------:|------:|------:|------:|------:|----------:|
|    Default | 30.938 μs | 0.0870 μs | 0.0772 μs | 30.941 μs |  1.00 |     - |     - |     - |         - |
| StructLinq |  7.251 μs | 0.1427 μs | 0.1954 μs |  7.378 μs |  0.23 |     - |     - |     - |         - |
