using System.Collections.Generic;
using StructLinq.Array;
using StructLinq.Utils;

namespace StructLinq.List
{
    public struct ListEnumerable<T> : IStructEnumerable<T, ArrayStructEnumerator<T>>
    {
        private List<T> list;
        private ListLayout<T> layout;
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