using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.IList;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IListEnumerable<T> ToStructEnumerable<T>(this IList<T> enumerable)
        {
            return new IListEnumerable<T>(enumerable, 0, enumerable.Count);
        }
    }
}
