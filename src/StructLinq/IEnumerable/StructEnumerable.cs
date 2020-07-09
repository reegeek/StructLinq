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
    }
}
