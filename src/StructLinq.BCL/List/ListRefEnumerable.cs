using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.Array;

namespace StructLinq.BCL.List
{
    public struct ListRefEnumerable<T> : IRefStructCollection<T, ArrayRefStructEnumerator<T>>
    {
        private List<T> list;
        private ListLayout<T> layout;
        public ListRefEnumerable(List<T> list)
        {
            this.list = list;
            layout = Unsafe.As<List<T>, ListLayout<T>>(ref list);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ArrayRefStructEnumerator<T> GetEnumerator()
        {
            return new ArrayRefStructEnumerator<T>(layout.Items, list.Count);
        }

        public int Count
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => list.Count;
        }
    }
}