using System.Buffers;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using StructLinq.Range;
using StructLinq.Utils.Collections;

namespace StructLinq.Benchmark
{
    //``` ini

    //BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
    //Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
    //.NET Core SDK=3.1.302
    //[Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
    //Job-LOZQBR : .NET Framework 4.8 (4.8.4180.0), X64 RyuJIT
    //Job-MKVKID : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT


    //```
    //|                  Method |       Runtime |     Mean |    Error |   StdDev |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
    //|------------------------ |-------------- |---------:|---------:|---------:|--------:|-------:|------:|----------:|
    //|       ToListThenToArray |      .NET 4.8 | 40.63 us | 0.786 us | 0.905 us | 40.5273 |      - |     - | 167.62 KB |
    //| ToPooledListThenToArray |      .NET 4.8 | 23.29 us | 0.491 us | 0.873 us |  9.5215 |      - |     - |  39.11 KB |
    //|       ToListThenToArray | .NET Core 3.1 | 31.60 us | 0.581 us | 0.485 us | 40.5273 | 0.0610 |     - | 167.41 KB |
    //| ToPooledListThenToArray | .NET Core 3.1 | 22.78 us | 0.191 us | 0.170 us |  9.5215 | 1.1902 |     - |  39.09 KB |
    
    [DisassemblyDiagnoser(recursiveDepth: 4), MemoryDiagnoser]
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    public class ToArrayComparison
    {
        private RangeEnumerable enumerable;

        public ToArrayComparison()
        {
            enumerable = StructEnumerable.Range(0, 10_000);
        }

        [Benchmark]
        public int[] ToListThenToArray()
        {
            var list = new List<int>();
            foreach (var i in enumerable)
            {
                list.Add(i);
            }

            return list.ToArray();
        }

        [Benchmark]
        public int[] ToPooledListThenToArray()
        {
            var list = new PooledList<int>(0, ArrayPool<int>.Shared);
            var enumerator = enumerable.GetEnumerator();
            PoolLists.Fill(ref list, ref enumerator);
            var array = list.ToArray();
            list.Dispose();
            return array;
        }

    }
}
