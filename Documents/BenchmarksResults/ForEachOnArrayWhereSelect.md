## ForEachOnArrayWhereSelect

### Source
[ForEachOnArrayWhereSelect.cs](../../src/StructLinq.Benchmark/ForEachOnArrayWhereSelect.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|                             Method |     Mean |    Error |   StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------------------- |---------:|---------:|---------:|------:|------:|------:|----------:|
|                            SysLinq | 47.56 μs | 0.146 μs | 0.130 μs |     - |     - |     - |     104 B |
|             StructLinqWithDelegate | 31.91 μs | 0.232 μs | 0.217 μs |     - |     - |     - |         - |
| StructLinqWithDelegateAsEnumerable | 57.79 μs | 0.287 μs | 0.255 μs |     - |     - |     - |     104 B |
|                         StructLinq | 13.63 μs | 0.052 μs | 0.048 μs |     - |     - |     - |         - |
|             StructLinqAsEnumerable | 40.55 μs | 0.251 μs | 0.235 μs |     - |     - |     - |     104 B |
