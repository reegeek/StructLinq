// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ElementAtOrDefault<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, int index, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : IStructEnumerable<T, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            T elementAt = default;
            if (TryInnerElementAt(ref enumerator, ref elementAt, index))
                return elementAt;
            return default;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ElementAtOrDefault<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, int index)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            T elementAt = default;
            if (TryInnerElementAt(ref enumerator, ref elementAt, index))
                return elementAt;
            return default;
        }
    }
}