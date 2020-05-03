// ReSharper disable once CheckNamespace

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.Array;
using StructLinq.List;
using StructLinq.Utils;

namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ListEnumerable<T> ToStructEnumerable<T>(this List<T> list)
        {
            return new ListEnumerable<T>(list);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ListRefEnumerable<T> ToRefStructEnumerable<T>(this List<T> list)
        {
            return new ListRefEnumerable<T>(list);
        }
    }
}