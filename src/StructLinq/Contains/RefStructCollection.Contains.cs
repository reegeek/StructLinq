using System;
using System.Runtime.CompilerServices;

namespace StructLinq;

public partial struct RefStructCollection<T, TEnumerable, TEnumerator>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static bool RefInnerContains<TComparer>(TEnumerator enumerator, T x, TComparer comparer)
        where TComparer : IInEqualityComparer<T>
    {
        while (enumerator.MoveNext())
        {
            ref var enumeratorCurrent = ref enumerator.Current;
            if (comparer.Equals(in x, in enumeratorCurrent))
                return true;
        }
        enumerator.Dispose();
        return false;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Obsolete("Remove last argument")]
    public bool Contains<TComparer>(T x, TComparer comparer, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
        where TComparer : IInEqualityComparer<T>
    {
        var enumerator = enumerable.GetEnumerator();
        return RefInnerContains(enumerator, x, comparer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Obsolete("Remove last argument")]
    public bool Contains(T x, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
    {
        var enumerator = enumerable.GetEnumerator();
        var equalityComparer = InEqualityComparer<T>.Default;
        return RefInnerContains(enumerator, x, equalityComparer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Contains<TComparer>(T x, TComparer comparer)
        where TComparer : IInEqualityComparer<T>
    {
        var enumerator = enumerable.GetEnumerator();
        return RefInnerContains(enumerator, x, comparer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Contains(T x)
    {
        var enumerator = enumerable.GetEnumerator();
        var equalityComparer = InEqualityComparer<T>.Default;
        return RefInnerContains(enumerator, x, equalityComparer);
    }
}