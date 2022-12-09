// ReSharper disable once CheckNamespace

using System.Buffers;
using System.Runtime.CompilerServices;
using StructLinq.Utils.Collections;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct RefStructEnum<T, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T[] ToArray(int capacity, ArrayPool<T> pool)
        {
            var list = new PooledList<T>(capacity, pool);
            var copy = enumerator;
            PoolLists.FillRef(ref list, ref copy);
            var array = list.ToArray();
            list.Dispose();
            return array;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T[] ToArray(int capacity = 0) => ToArray(capacity, ArrayPool<T>.Shared);
    }
}
