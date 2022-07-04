#if !NETSTANDARD1_1
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.Array;
using StructLinq.List;
// ReSharper disable CheckNamespace

namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StructCollection<T, ListEnumerable<T>, ArrayStructEnumerator<T>> ToStructEnumerable<T>(this List<T> list)
        {
            return new(new(list));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefStructCollection<T, ListRefEnumerable<T>, ArrayRefStructEnumerator<T>> ToRefStructEnumerable<T>(this List<T> list)
        {
            return new(new(list));
        }
    }
}
#endif