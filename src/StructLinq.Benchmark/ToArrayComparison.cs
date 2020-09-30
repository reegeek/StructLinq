using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using StructLinq.Range;
using StructLinq.Utils.Collections;

namespace StructLinq.Benchmark
{
   
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
