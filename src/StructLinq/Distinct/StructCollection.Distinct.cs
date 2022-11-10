using System;
using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.Distinct;
using StructLinq.Utils.Collections;

// ReSharper disable once CheckNamespace
namespace StructLinq;

public partial struct StructCollection<T, TEnumerable, TEnumerator>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Obsolete("Remove last argument")]
    public StructEnumerable<T, DistinctEnumerable<T, TEnumerable, TEnumerator, TComparer>, DistinctEnumerator<T, TEnumerator, TComparer>> Distinct<TComparer>(
        TComparer comparer,
        int capacity,
        ArrayPool<int> bucketPool,
        ArrayPool<Slot<T>> slotPool,
        Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
        where TComparer : IEqualityComparer<T>
    {
        return new(new(ref enumerable, comparer, capacity, bucketPool, slotPool));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public StructEnumerable<T, DistinctEnumerable<T, TEnumerable, TEnumerator, TComparer>, DistinctEnumerator<T, TEnumerator, TComparer>> Distinct<TComparer>(TComparer comparer, int capacity, ArrayPool<int> bucketPool, ArrayPool<Slot<T>> slotPool)
        where TComparer : IEqualityComparer<T>
    {
        return new(new(ref enumerable, comparer, capacity, bucketPool, slotPool));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Obsolete("Remove last argument")]
    public StructEnumerable<T, DistinctEnumerable<T, TEnumerable, TEnumerator, TComparer>, DistinctEnumerator<T, TEnumerator, TComparer>> Distinct<TComparer>(TComparer comparer, int capacity,
        Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
        where TComparer : IEqualityComparer<T>
    {
        return Distinct(comparer, capacity, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared, _);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public StructEnumerable<T, DistinctEnumerable<T, TEnumerable, TEnumerator, TComparer>, DistinctEnumerator<T, TEnumerator, TComparer>> Distinct<TComparer>(TComparer comparer, int capacity)
        where TComparer : IEqualityComparer<T>
    {
        return Distinct(comparer, capacity, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Obsolete("Remove last argument")]
    public StructEnumerable<T, DistinctEnumerable<T, TEnumerable, TEnumerator, TComparer>, DistinctEnumerator<T, TEnumerator, TComparer>> Distinct<TComparer>(TComparer comparer,
        Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
        where TComparer : IEqualityComparer<T>
    {
        return Distinct(comparer, 0, _);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public StructEnumerable<T, DistinctEnumerable<T, TEnumerable, TEnumerator, TComparer>, DistinctEnumerator<T, TEnumerator, TComparer>> Distinct<TComparer>(TComparer comparer)
        where TComparer : IEqualityComparer<T>
    {
        return Distinct(comparer, 0);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Obsolete("Remove last argument")]
    public StructEnumerable<T, DistinctEnumerable<T, TEnumerable, TEnumerator, IEqualityComparer<T>>, DistinctEnumerator<T, TEnumerator, IEqualityComparer<T>>> Distinct(IEqualityComparer<T> comparer,
        Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
    {
        return Distinct(comparer, 0, _);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public StructEnumerable<T, DistinctEnumerable<T, TEnumerable, TEnumerator, IEqualityComparer<T>>, DistinctEnumerator<T, TEnumerator, IEqualityComparer<T>>> Distinct(IEqualityComparer<T> comparer)
    {
        return Distinct(comparer, 0);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Obsolete("Remove last argument")]
    public StructEnumerable<T, DistinctEnumerable<T, TEnumerable, TEnumerator, EqualityComparer<T>>, DistinctEnumerator<T, TEnumerator, EqualityComparer<T>>> Distinct(Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
    {
        var equalityComparer = EqualityComparer<T>.Default;
        return new(new(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public StructEnumerable<T, DistinctEnumerable<T, TEnumerable, TEnumerator, EqualityComparer<T>>, DistinctEnumerator<T, TEnumerator, EqualityComparer<T>>> Distinct()
    {
        var equalityComparer = EqualityComparer<T>.Default;
        return Distinct(equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared);
    }
}