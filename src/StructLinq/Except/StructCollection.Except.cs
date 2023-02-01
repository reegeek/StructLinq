using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.Except;
using StructLinq.Utils.Collections;

namespace StructLinq;

public partial struct StructCollec<T, TEnumerator>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public StructEnum<T, ExceptEnumerator<T, TEnumerator, TEnumerator2, TComparer>> Except<TEnumerator2, TComparer>(
        StructEnum<T, TEnumerator2> enumerable,
        TComparer comparer,
        int capacity,
        ArrayPool<int> bucketPool,
        ArrayPool<Slot<T>> slotPool) 
        where TEnumerator2 : struct, IStructEnumerator<T> 
        where TComparer : IEqualityComparer<T>
    {
        return ToStructEnumerable().Except(enumerable, comparer, capacity, bucketPool, slotPool);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public StructEnum<T, ExceptEnumerator<T, TEnumerator, TEnumerator2, TComparer>> Except<TEnumerator2, TComparer>(
        StructCollec<T, TEnumerator2> enumerable,
        TComparer comparer,
        int capacity,
        ArrayPool<int> bucketPool,
        ArrayPool<Slot<T>> slotPool)
        where TEnumerator2 : struct, ICollectionEnumerator<T>
        where TComparer : IEqualityComparer<T>
    {
        return ToStructEnumerable().Except(enumerable, comparer, capacity, bucketPool, slotPool);
    }

}