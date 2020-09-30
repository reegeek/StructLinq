## ForEachOnArrayWhereSelect

### Source
[ForEachOnArrayWhereSelect.cs](../../src/StructLinq.Benchmark/ForEachOnArrayWhereSelect.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  DefaultJob : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|                             Method |     Mean |    Error |   StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------------------- |---------:|---------:|---------:|------:|------:|------:|----------:|
|                            SysLinq | 48.01 us | 0.066 us | 0.062 us |     - |     - |     - |     104 B |
|             StructLinqWithDelegate | 46.88 us | 0.191 us | 0.179 us |     - |     - |     - |         - |
| StructLinqWithDelegateAsEnumerable | 77.29 us | 0.218 us | 0.204 us |     - |     - |     - |      96 B |
|                         StructLinq | 15.37 us | 0.026 us | 0.023 us |     - |     - |     - |         - |
|             StructLinqAsEnumerable | 43.89 us | 0.141 us | 0.132 us |     - |     - |     - |      96 B |
