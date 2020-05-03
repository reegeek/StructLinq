// ReSharper disable once CheckNamespace

using System.Collections.Generic;
using StructLinq.Array;
using StructLinq.Utils;

namespace StructLinq
{
    public static partial class StructEnumerable
    {
        public static ArrayEnumerable<T> ToStructEnumerable<T>(this List<T> list)
        {
            var layout = Unsafe.As<List<T>, ListLayout<T>>(ref list);
            return new ArrayEnumerable<T>(layout.Items, list.Count);
        }
        public static ArrayRefEnumerable<T> ToRefStructEnumerable<T>(this List<T> list)
        {
            var layout = Unsafe.As<List<T>, ListLayout<T>>(ref list);
            return new ArrayRefEnumerable<T>(layout.Items, list.Count);
        }

        private class ListLayout<T>
        {
            internal T[] Items = default!;
        }
    }
}