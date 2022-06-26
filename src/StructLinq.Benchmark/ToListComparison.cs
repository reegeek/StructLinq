using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using StructLinq.List;
using StructLinq.Utils.Collections;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    [SimpleJob(RuntimeMoniker.Net48, baseline: true)]
    [SimpleJob(RuntimeMoniker.Net50)]
    [SimpleJob(RuntimeMoniker.Net60)]
    public class ToListComparison
    {
        private int[] enumerable;

        public ToListComparison()
        {
            enumerable = StructEnumerable.Range(0, 10_000).ToArray();
        }

        [Benchmark]
        public List<int> AddInList()
        {
            var list = new List<int>();
            var rangeEnumerator = enumerable.ToStructEnumerable().GetEnumerator();
            FillList(list, ref rangeEnumerator);
            return list;
        }

        [Benchmark]
        public List<int> ToArrayThenNewList()
        {
            var list = new PooledList<int>(0, ArrayPool<int>.Shared);
            var enumerator = enumerable.ToStructEnumerable().GetEnumerator();
            PoolLists.Fill(ref list, ref enumerator);
            var array = list.ToArray();
            list.Dispose();
            return new List<int>(array);
        }

        [Benchmark]
        public List<int> ToArrayThenNewListAndLayout()
        {
            var list = new PooledList<int>(0, ArrayPool<int>.Shared);
            var enumerator = enumerable.ToStructEnumerable().GetEnumerator();
            PoolLists.Fill(ref list, ref enumerator);
            var array = list.ToArray();
            list.Dispose();
            var result = new List<int>(array.Length);
            var listLayout = Unsafe.As<List<int>, ListLayout<int>>(ref result);
            listLayout.Items = array;
            return result;
        }

        [Benchmark]
        public List<int> WithVisitor()
        {
            var visitor = new PooledListVisitor<int>(0, ArrayPool<int>.Shared);
            enumerable.ToStructEnumerable().Visit(ref visitor);
            var array = visitor.PooledList.ToArray();
            visitor.Dispose();
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
