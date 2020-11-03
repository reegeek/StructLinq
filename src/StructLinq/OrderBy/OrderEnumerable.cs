using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.Utils.Collections;

namespace StructLinq.OrderBy
{
    public struct OrderEnumerable<T, TEnumerable, TEnumerator, TComparer> : IStructEnumerable<T, OrderByEnumerator<T>>
        where TEnumerator : struct, IStructEnumerator<T>
        where TEnumerable : IStructEnumerable<T, TEnumerator>
        where TComparer : IComparer<T>
    {
        private readonly TEnumerable enumerable;
        private readonly TComparer comparer;
        private readonly int capacity;
        private readonly ArrayPool<int> indexPool;
        private readonly ArrayPool<T> dataPool;
        private readonly bool ascending;

        public OrderEnumerable(ref TEnumerable enumerable, ref TComparer comparer, int capacity, ArrayPool<int> indexPool, ArrayPool<T> dataPool, bool ascending)
        {
            this.enumerable = enumerable;
            this.comparer = comparer;
            this.capacity = capacity;
            this.indexPool = indexPool;
            this.dataPool = dataPool;
            this.ascending = ascending;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public OrderByEnumerator<T> GetEnumerator()
        {
            var datas = new PooledList<T>(capacity, dataPool);
            var enumerator = enumerable.GetEnumerator();
            PoolLists.Fill(ref datas, ref enumerator);
            var size = datas.Size;

            if (size == 0)
            {
                var empty = indexPool.Rent(0);
                return new OrderByEnumerator<T>(empty, datas, size, indexPool);
            }

            var indexes = indexPool.Rent(size);
            for (int i = 0; i < size; i++)
            {
                indexes[i] = i;
            }
            var comp = comparer;
            QuickSort.Sort(indexes, 0, size -1, datas.Items, ref comp, ascending); 
            return new OrderByEnumerator<T>(indexes, datas, size, indexPool);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<T>
        {
            foreach (var input in this)
            {
                if (!visitor.Visit(input))
                    return;
            }
        }
    }
}
