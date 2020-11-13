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

    [DisassemblyDiagnoser( 4), MemoryDiagnoser]
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
