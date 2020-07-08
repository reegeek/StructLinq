using System.Collections.Generic;
using StructLinq.Array;

namespace StructLinq.BCL.List
{
    public readonly struct ListEnumerable<T> : IStructEnumerable<T, ArrayStructEnumerator<T>>
    {
        private readonly List<T> list;
        private readonly ListLayout<T> layout;
        public ListEnumerable(List<T> list)
        {
            this.list = list;
            layout = Unsafe.As<List<T>, ListLayout<T>>(ref list);
        }

        public ArrayStructEnumerator<T> GetEnumerator()
        {
            return new ArrayStructEnumerator<T>(layout.Items, list.Count);
        }
    }
}