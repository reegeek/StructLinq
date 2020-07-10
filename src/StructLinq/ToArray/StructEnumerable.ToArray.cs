// ReSharper disable once CheckNamespace

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StructLinq
{
    public static partial class StructEnumerable
    {

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T[] ToArray<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            return enumerable.ToList().ToArray();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T[] ToArray<T, TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            return enumerable.ToList().ToArray();
        }

    }
}
