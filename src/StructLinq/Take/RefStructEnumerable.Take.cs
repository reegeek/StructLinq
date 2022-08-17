using System;
using System.Runtime.CompilerServices;
using StructLinq.Take;

// ReSharper disable once CheckNamespace
namespace StructLinq;

public partial struct RefStructEnumerable<T, TEnumerable, TEnumerator>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Obsolete("Remove last argument")]
    public RefStructEnumerable<T, RefTakeEnumerable<T, TEnumerable, TEnumerator>, RefTakeEnumerator<T, TEnumerator>> Take(int count, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
    {
        return new(new(ref enumerable, count));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RefStructEnumerable<T, RefTakeEnumerable<T, TEnumerable, TEnumerator>, RefTakeEnumerator<T, TEnumerator>> Take(int count)
    {
        return new(new(ref enumerable, count));
    }

}