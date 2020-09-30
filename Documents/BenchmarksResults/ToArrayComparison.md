## ToArrayComparison

### Source
[ToArrayComparison.cs](../../src/StructLinq.Benchmark/ToArrayComparison.cs)

### Results:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  Job-ILXHKQ : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  Job-DKIKQP : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT


```
|                  Method |       Runtime |      Mean |     Error |    StdDev |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|------------------------ |-------------- |----------:|----------:|----------:|--------:|-------:|------:|----------:|
|       ToListThenToArray |      .NET 4.8 | 35.971 us | 0.1010 us | 0.0895 us | 40.5273 |      - |     - | 167.62 KB |
| ToPooledListThenToArray |      .NET 4.8 | 20.988 us | 0.0544 us | 0.0509 us |  9.5215 |      - |     - |  39.11 KB |
|      UseCountForToArray |      .NET 4.8 |  7.677 us | 0.0105 us | 0.0093 us |  9.5215 |      - |     - |  39.11 KB |
|       StructLinqToArray |      .NET 4.8 |  7.619 us | 0.0201 us | 0.0188 us |  9.5215 |      - |     - |  39.11 KB |
|       ToListThenToArray | .NET Core 3.1 | 28.288 us | 0.1766 us | 0.1565 us | 40.5273 | 0.0305 |     - | 167.41 KB |
| ToPooledListThenToArray | .NET Core 3.1 | 21.066 us | 0.0335 us | 0.0313 us |  9.5215 | 1.1902 |     - |  39.09 KB |
|      UseCountForToArray | .NET Core 3.1 |  7.757 us | 0.0498 us | 0.0466 us |  9.5215 | 0.0153 |     - |  39.09 KB |
|       StructLinqToArray | .NET Core 3.1 |  7.741 us | 0.0531 us | 0.0497 us |  9.5215 | 0.0153 |     - |  39.09 KB |
