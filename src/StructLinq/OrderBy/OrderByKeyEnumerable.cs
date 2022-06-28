using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.Utils.Collections;

namespace StructLinq.OrderBy
{
    public readonly struct OrderByKeyEnumerable<T, TEnumerable, TEnumerator, TSelector, TKey, TComparer> : IStructEnumerable<T, OrderByEnumerator<T>>
        where TEnumerator : struct, IStructEnumerator<T>
        where TEnumerable : IStructEnumerable<T, TEnumerator>
        where TSelector : IFunction<T, TKey>
        where TComparer : IComparer<TKey>
    {
        private readonly TEnumerable enumerable;
        private readonly TSelector selector;
        private readonly TComparer comparer;
        private readonly int capacity;
        private readonly ArrayPool<int> indexPool;
        private readonly ArrayPool<T> dataPool;
        private readonly ArrayPool<TKey> keyPool;
        private readonly bool ascending;

        public OrderByKeyEnumerable(ref TEnumerable enumerable, ref TSelector selector, ref TComparer comparer, int capacity, ArrayPool<int> indexPool, ArrayPool<T> dataPool, ArrayPool<TKey> keyPool, bool ascending)
        {
            this.enumerable = enumerable;
            this.selector = selector;
            this.comparer = comparer;
            this.capacity = capacity;
            this.indexPool = indexPool;
            this.dataPool = dataPool;
            this.keyPool = keyPool;
            this.ascending = ascending;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void Fill(ref PooledList<T> datas, ref PooledList<TKey> keys, ref TEnumerator enumerator)
        {
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                var key = selector.Eval(current);
                keys.Add(key);
                datas.Add(current);
            }
            enumerator.Dispose();
        }

   
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public OrderByEnumerator<T> GetEnumerator()
        {
            var datas = new PooledList<T>(capacity, dataPool);
            var keys = new PooledList<TKey>(capacity, keyPool);
            var enumerator = enumerable.GetEnumerator();
            Fill(ref datas, ref keys, ref enumerator);
            var size = datas.Size;

            if (size == 0)
            {
                var empty = indexPool.Rent(0);
                return new(empty, datas, size, indexPool);
            }

            var indexes = indexPool.Rent(size);
            for (int i = 0; i < size; i++)
            {
                indexes[i] = i;
            }
            var comp = comparer;
            QuickSort.Sort(indexes, 0, size - 1, keys.Items, ref comp, ascending);
            keys.Dispose();
            return new(indexes, datas, size, indexPool);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<T>
        {
            foreach (var input in this)
            {
                if (!visitor.Visit(input))
                    return VisitStatus.VisitorFinished;
            }

            return VisitStatus.EnumeratorFinished;
        }
    }
}
