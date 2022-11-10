using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using StructLinq.Distinct;
using StructLinq.Utils.Collections;

// ReSharper disable once CheckNamespace
namespace StructLinq;

public partial struct RefStructEnumerable<T, TEnumerable, TEnumerator>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Obsolete("Remove last argument")]
    public RefStructEnumerable<T, RefDistinctEnumerable<T, TEnumerable, TEnumerator, TComparer>, RefDistinctEnumerator<T, TEnumerator, TComparer>> Distinct<TComparer>(
        TComparer comparer,
        int capacity,
        ArrayPool<int> bucketPool,
        ArrayPool<Slot<T>> slotPool,
        Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
        where TComparer : IInEqualityComparer<T>
    {
        return new(new(ref enumerable, comparer, capacity, bucketPool, slotPool));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RefStructEnumerable<T, RefDistinctEnumerable<T, TEnumerable, TEnumerator, TComparer>, RefDistinctEnumerator<T, TEnumerator, TComparer>> Distinct<TComparer>(
        TComparer comparer,
        int capacity,
        ArrayPool<int> bucketPool,
        ArrayPool<Slot<T>> slotPool)
        where TComparer : IInEqualityComparer<T>
    {
        return new(new(ref enumerable, comparer, capacity, bucketPool, slotPool));
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Obsolete("Remove last argument")]
    public RefStructEnumerable<T, RefDistinctEnumerable<T, TEnumerable, TEnumerator, TComparer>, RefDistinctEnumerator<T, TEnumerator, TComparer>> Distinct<TComparer>(
        TComparer comparer,
        int capacity,
        Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
        where TComparer : IInEqualityComparer<T>
    {
        return Distinct(comparer, capacity, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RefStructEnumerable<T, RefDistinctEnumerable<T, TEnumerable, TEnumerator, TComparer>, RefDistinctEnumerator<T, TEnumerator, TComparer>> Distinct<TComparer>(
        TComparer comparer,
        int capacity)
        where TComparer : IInEqualityComparer<T>
    {
        return Distinct(comparer, capacity, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Obsolete("Remove last argument")]
    public RefStructEnumerable<T, RefDistinctEnumerable<T, TEnumerable, TEnumerator, TComparer>, RefDistinctEnumerator<T, TEnumerator, TComparer>> Distinct<TComparer>(
        TComparer comparer,
        Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
        where TComparer : IInEqualityComparer<T>
    {
        return Distinct(comparer, 0);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RefStructEnumerable<T, RefDistinctEnumerable<T, TEnumerable, TEnumerator, TComparer>, RefDistinctEnumerator<T, TEnumerator, TComparer>> Distinct<TComparer>(
        TComparer comparer)
        where TComparer : IInEqualityComparer<T>
    {
        return Distinct(comparer, 0);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Obsolete("Remove last argument")]
    public RefStructEnumerable<T, RefDistinctEnumerable<T, TEnumerable, TEnumerator, IInEqualityComparer<T>>, RefDistinctEnumerator<T, TEnumerator, IInEqualityComparer<T>>> Distinct(
        IInEqualityComparer<T> comparer,
        Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
    {
        return Distinct(comparer, 0);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RefStructEnumerable<T, RefDistinctEnumerable<T, TEnumerable, TEnumerator, IInEqualityComparer<T>>, RefDistinctEnumerator<T, TEnumerator, IInEqualityComparer<T>>> Distinct(
        IInEqualityComparer<T> comparer)
    {
        return Distinct(comparer, 0);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Obsolete("Remove last argument")]
    public RefStructEnumerable<T, RefDistinctEnumerable<T, TEnumerable, TEnumerator, StructInEqualityComparer<T>>, RefDistinctEnumerator<T, TEnumerator, StructInEqualityComparer<T>>> Distinct(Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
    {
        return Distinct(InEqualityComparer<T>.Default, _);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RefStructEnumerable<T, RefDistinctEnumerable<T, TEnumerable, TEnumerator, StructInEqualityComparer<T>>, RefDistinctEnumerator<T, TEnumerator, StructInEqualityComparer<T>>> Distinct()
    {
        return Distinct(InEqualityComparer<T>.Default);
    }
}