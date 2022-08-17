using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq;

public partial struct RefStructCollection<T, TEnumerable, TEnumerator>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Obsolete("Remove last argument")]
    public RefStructCollection<T, TEnumerable, TEnumerator> Skip(int count, Func<TEnumerable, IRefStructCollection<T, TEnumerator>> _)
    {
        var newCollection = enumerable;
        newCollection.Slice((uint)count, null);
        return new (newCollection);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public RefStructCollection<T, TEnumerable, TEnumerator> Skip(int count)
    {
        var newCollection = enumerable;
        newCollection.Slice((uint)count, null);
        return new(newCollection);
    }

}