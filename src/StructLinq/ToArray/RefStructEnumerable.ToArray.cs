#nullable enable
using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using StructLinq.Utils.Collections;

namespace StructLinq;

public partial struct RefStructEnumerable<T, TEnumerable, TEnumerator>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static T[] ToArray(ref TEnumerator enumerator,
        int capacity,
        ArrayPool<T> pool)
    {
        var list = new PooledList<T>(capacity, pool);
        PoolLists.FillRef(ref list, ref enumerator);
        var array = list.ToArray();
        list.Dispose();
        return array;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Obsolete("Remove last argument")]
    public T[] ToArray(
        int capacity, 
        ArrayPool<T> pool,
        Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
    {
        var enumerator = enumerable.GetEnumerator();
        return ToArray(ref enumerator, capacity, pool);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public T[] ToArray(
        int capacity = 0, 
        ArrayPool<T>? pool = null)
    {
        pool ??= ArrayPool<T>.Shared;
        var enumerator = enumerable.GetEnumerator();
        return ToArray(ref enumerator, capacity, pool);
    }
}