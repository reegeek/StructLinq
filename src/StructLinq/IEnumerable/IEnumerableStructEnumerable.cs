using System.Collections.Generic;
using StructLinq.IEnumerable;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        public static TypedEnumerableFromIEnumerable<T> ToTypedEnumerable<T>(this IEnumerable<T> enumerable)
        {
            return new TypedEnumerableFromIEnumerable<T>(enumerable);
        }
    }
}
