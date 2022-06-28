#if !NETSTANDARD1_1
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.List;
// ReSharper disable CheckNamespace

namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ListEnumerable<T> ToStructEnumerable<T>(this List<T> list)
        {
            return new(list);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ListRefEnumerable<T> ToRefStructEnumerable<T>(this List<T> list)
        {
            return new(list);
        }
    }
}
#endif