using System;
using System.Buffers;
using System.Runtime.CompilerServices;

namespace StructLinq.Utils.Collections
{
    internal struct PooledListVisitor<T> : IVisitor<T>, IDisposable
    {
        public PooledList<T> PooledList;

        public PooledListVisitor(int capacity, ArrayPool<T> pool)
        {
            PooledList = new PooledList<T>(capacity, pool);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Visit(T input)
        {
            PooledList.Add(input);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            PooledList.Dispose();
        }
    }
}
