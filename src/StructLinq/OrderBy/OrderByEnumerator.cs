using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using StructLinq.Utils.Collections;

namespace StructLinq.OrderBy
{
    public struct OrderByEnumerator<T> : IStructEnumerator<T>
    {
        private int[] indexes;
        private PooledList<T> datas;
        private readonly ArrayPool<int> indexPool;
        private readonly int endIndex;
        private int index;

        internal OrderByEnumerator(int[] indexes, PooledList<T> datas, int length, ArrayPool<int> indexPool)
        {
            this.indexes = indexes;
            this.datas = datas;
            this.indexPool = indexPool;
            endIndex = length - 1;
            index = -1;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            return ++index <= endIndex;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            index = -1;
        }

        public T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => datas.Items[indexes[index]];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            if (indexes?.Length > 0)
            {
                try
                {
                    indexPool.Return(indexes);
                }
                catch (ArgumentException)
                {
                    // oh well, the array pool didn't like our array
                }
            }
            datas.Dispose();
            indexes = null;
        }
    }
}
