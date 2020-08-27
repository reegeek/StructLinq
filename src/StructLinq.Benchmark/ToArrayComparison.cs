using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using StructLinq.Range;
using StructLinq.Utils.Collections;

namespace StructLinq.Benchmark
{
    //``` ini

    //BenchmarkDotNet=v0.12.0, OS=Windows 10.0.19041
    //Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
    //.NET Core SDK=3.1.401
    //[Host]     : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT
    //Job-RDJNKN : .NET Framework 4.8 (4.8.4180.0), X64 RyuJIT
    //Job-DIUBYS : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT


    //```
    //|                  Method |       Runtime |      Mean |     Error |    StdDev |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
    //|------------------------ |-------------- |----------:|----------:|----------:|--------:|-------:|------:|----------:|
    //|       ToListThenToArray |      .NET 4.8 | 37.980 us | 0.2514 us | 0.2351 us | 40.5273 |      - |     - | 167.62 KB |
    //| ToPooledListThenToArray |      .NET 4.8 | 21.629 us | 0.1488 us | 0.1319 us |  9.5215 |      - |     - |  39.11 KB |
    //|      UseCountForToArray |      .NET 4.8 |  7.864 us | 0.0312 us | 0.0292 us |  9.5215 |      - |     - |  39.11 KB |
    //|       StructLinqToArray |      .NET 4.8 |  7.833 us | 0.0420 us | 0.0372 us |  9.5215 |      - |     - |  39.11 KB |
    //|       ToListThenToArray | .NET Core 3.1 | 29.158 us | 0.1454 us | 0.1214 us | 40.5273 | 0.0305 |     - | 167.41 KB |
    //| ToPooledListThenToArray | .NET Core 3.1 | 21.845 us | 0.1254 us | 0.1173 us |  9.5215 | 1.1902 |     - |  39.09 KB |
    //|      UseCountForToArray | .NET Core 3.1 |  7.937 us | 0.1021 us | 0.0955 us |  9.5215 | 0.0153 |     - |  39.09 KB |
    //|       StructLinqToArray | .NET Core 3.1 |  7.924 us | 0.0355 us | 0.0314 us |  9.5215 | 0.0153 |     - |  39.09 KB |
    
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

        [Benchmark]
        public int[] UseCountForToArray()
        {
            var enumerator = enumerable.GetEnumerator();
            return ToArray<int, RangeEnumerator>(ref enumerator, enumerable.Count);
        }

        [Benchmark]
        public int[] StructLinqToArray()
        {
            return enumerable.ToArray(x => x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static T[] ToArray<T, TEnumerator>(ref TEnumerator enumerator, int size)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var result = new T[size];
            var i = 0;
            while (enumerator.MoveNext())
            {
                result[i++] = enumerator.Current;
            }
            enumerator.Dispose();
            return result;
        }
    }
}
