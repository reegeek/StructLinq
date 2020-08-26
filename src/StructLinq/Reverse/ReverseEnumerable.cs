using System.Buffers;
using System.Runtime.CompilerServices;
using StructLinq.Utils.Collections;

namespace StructLinq.Reverse
{
    public readonly struct ReverseEnumerable<T, TEnumerable, TEnumerator> : IStructEnumerable<T, ReverseEnumerator<T>>
        where TEnumerator : struct, IStructEnumerator<T>
        where TEnumerable : IStructEnumerable<T, TEnumerator>
    {
        private readonly TEnumerable enumerable;
        private readonly int capacity;
        private readonly ArrayPool<T> pool;

        public ReverseEnumerable(TEnumerable enumerable, int capacity, ArrayPool<T> pool)
        {
            this.enumerable = enumerable;
            this.capacity = capacity;
            this.pool = pool;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReverseEnumerator<T> GetEnumerator()
        {
            var list = new PooledList<T>(capacity, pool);
            var enumerator = enumerable.GetEnumerator();
            PoolLists.Fill(ref list, ref enumerator);
            return new ReverseEnumerator<T>(list);
        }

        internal TEnumerable Enumerable
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => enumerable;
        }
    }
}
