using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.IEnumerable;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StructEnumerableFromIEnumerable<T> ToStructEnumerable<T>(this IEnumerable<T> enumerable)
        {
            return new(enumerable);
        }
    }
}
