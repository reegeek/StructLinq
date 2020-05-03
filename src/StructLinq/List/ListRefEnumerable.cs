using System.Collections.Generic;
using StructLinq.Array;
using StructLinq.Utils;

namespace StructLinq.List
{
    public struct ListRefEnumerable<T> : IRefStructEnumerable<T, ArrayRefStructEnumerator<T>>
    {
        private List<T> list;
        private ListLayout<T> layout;
        public ListRefEnumerable(List<T> list)
        {
            this.list = list;
            layout = Unsafe.As<List<T>, ListLayout<T>>(ref list);
        }

        public ArrayRefStructEnumerator<T> GetEnumerator()
        {
            return new ArrayRefStructEnumerator<T>(layout.Items, list.Count);
        }
    }
}