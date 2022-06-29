using System;
using System.Runtime.CompilerServices;
using StructLinq.Utils;

namespace StructLinq;

public partial struct RefStructCollection<T, TEnumerable, TEnumerator>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static T[] ToArray(ref TEnumerator enumerator)
    {
        var count = enumerator.Count;
        var result = ArrayHelpers.Create<T>(count);
        for (int i = 0; i < count; i++)
        {
            ref var item = ref result[i];
            ref var elt = ref enumerator.Get(i);
            item = elt;
        }
        enumerator.Dispose();
        return result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Obsolete("Remove last argument")]
    public T[] ToArray(
        Func<TEnumerable, IRefStructCollection<T, TEnumerator>> _)
    {
        var enumerator = enumerable.GetEnumerator();
        return ToArray(ref enumerator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public T[] ToArray()
    {
        var enumerator = enumerable.GetEnumerator();
        return ToArray(ref enumerator);
    }
}