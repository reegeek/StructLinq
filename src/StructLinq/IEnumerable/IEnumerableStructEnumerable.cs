using System.Collections.Generic;
using StructLinq.IEnumerable;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        public static StructEnumerableFromIEnumerable<T> ToStructEnumerable<T>(this IEnumerable<T> enumerable)
        {
            return new StructEnumerableFromIEnumerable<T>(enumerable);
        }

        public static StructEnumerable<T, TEnumerator> ToEnumerable<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            return new StructEnumerable<T, TEnumerator>(enumerable);
        }
    }
}
