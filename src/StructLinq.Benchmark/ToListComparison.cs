using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using StructLinq.BCL.List;
using StructLinq.Range;
using StructLinq.Utils.Collections;

namespace StructLinq.Benchmark
{
    //``` ini

    //BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
    //Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
    //.NET Core SDK=3.1.302
    //[Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
    //Job-TYFRDC : .NET Framework 4.8 (4.8.4180.0), X64 RyuJIT
    //Job-CLVTMV : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT


    //```
    //|                      Method |       Runtime |     Mean |    Error |   StdDev |   Median |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
    //|---------------------------- |-------------- |---------:|---------:|---------:|---------:|--------:|-------:|------:|----------:|
    //|                   AddInList |      .NET 4.8 | 36.91 us | 0.701 us | 0.689 us | 36.77 us | 31.1890 | 0.0610 |     - | 128.48 KB |
    //|          ToArrayThenNewList |      .NET 4.8 | 27.83 us | 0.617 us | 0.885 us | 27.42 us | 19.0430 | 0.0610 |     - |  78.37 KB |
    //| ToArrayThenNewListAndLayout |      .NET 4.8 | 26.46 us | 0.906 us | 2.671 us | 26.77 us |  9.5215 |      - |     - |  39.19 KB |
    //|                   AddInList | .NET Core 3.1 | 28.09 us | 0.568 us | 0.583 us | 28.02 us | 31.1890 | 0.1831 |     - | 128.32 KB |
    //|          ToArrayThenNewList | .NET Core 3.1 | 30.57 us | 0.987 us | 2.911 us | 29.19 us | 19.0430 | 3.7842 |     - |   78.2 KB |
    //| ToArrayThenNewListAndLayout | .NET Core 3.1 | 23.00 us | 0.215 us | 0.190 us | 23.00 us |  9.5215 | 1.1902 |     - |  39.12 KB |


    [DisassemblyDiagnoser(recursiveDepth: 4), MemoryDiagnoser]
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    public class ToListComparison
    {
        private RangeEnumerable enumerable;

        public ToListComparison()
        {
            enumerable = StructEnumerable.Range(0, 10_000);
        }

        [Benchmark]
        public List<int> AddInList()
        {
            var list = new List<int>();
            var rangeEnumerator = enumerable.GetEnumerator();
            FillList(list, ref rangeEnumerator);
            return list;
        }

        [Benchmark]
        public List<int> ToArrayThenNewList()
        {
            var list = new PooledList<int>(0, ArrayPool<int>.Shared);
            var enumerator = enumerable.GetEnumerator();
            PoolLists.Fill(ref list, ref enumerator);
            var array = list.ToArray();
            list.Dispose();
            return new List<int>(array);
        }

        [Benchmark]
        public List<int> ToArrayThenNewListAndLayout()
        {
            var list = new PooledList<int>(0, ArrayPool<int>.Shared);
            var enumerator = enumerable.GetEnumerator();
            PoolLists.Fill(ref list, ref enumerator);
            var array = list.ToArray();
            list.Dispose();
            var result = new List<int>();
            var listLayout = Unsafe.As<List<int>, ListLayout<int>>(ref result);
            listLayout.Items = array;
            listLayout.Size = array.Length;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void FillList<T, TEnumerator>(List<T> list, ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                list.Add(current);
            }
            enumerator.Dispose();
        }
    }
}
