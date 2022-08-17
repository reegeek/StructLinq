using System;
using System.Runtime.CompilerServices;
using StructLinq.Skip;

namespace StructLinq;

public partial struct RefStructEnumerable<T, TEnumerable, TEnumerator>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Obsolete("Remove last argument")]
    public RefStructEnumerable<T, RefSkipEnumerable<T, TEnumerable, TEnumerator>, RefSkipEnumerator<T, TEnumerator>> Skip(int count, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
    {
        return new(new(ref enumerable, count));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RefStructEnumerable<T, RefSkipEnumerable<T, TEnumerable, TEnumerator>, RefSkipEnumerator<T, TEnumerator>> Skip(int count)
    {
        return new(new(ref enumerable, count));
    }


}