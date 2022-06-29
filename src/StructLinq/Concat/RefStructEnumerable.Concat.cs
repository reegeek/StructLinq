using System;
using System.Runtime.CompilerServices;
using StructLinq.Concat;

namespace StructLinq;

public partial struct RefStructEnumerable<T, TEnumerable, TEnumerator>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Obsolete("Remove last two arguments")]
    public RefStructEnumerable<T, RefConcatEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2>,
        RefConcatEnumerator<T, TEnumerator, TEnumerator2>> Concat<TEnumerable2, TEnumerator2>(
        RefStructEnumerable<T,TEnumerable2, TEnumerator2> enumerable2,
        Func<TEnumerable2, IRefStructEnumerable<T, TEnumerator2>> __,
        Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
        where TEnumerable2 : struct, IRefStructEnumerable<T, TEnumerator2>
        where TEnumerator2 : struct, IRefStructEnumerator<T>
    {
        return new(new (enumerable, enumerable2.enumerable));
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RefStructEnumerable<T, RefConcatEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2>,
        RefConcatEnumerator<T, TEnumerator, TEnumerator2>> Concat<TEnumerable2, TEnumerator2>(
        RefStructEnumerable<T,TEnumerable2, TEnumerator2> enumerable2)
        where TEnumerable2 : struct, IRefStructEnumerable<T, TEnumerator2>
        where TEnumerator2 : struct, IRefStructEnumerator<T>
    {
        return new(new (enumerable, enumerable2.enumerable));
    }
}