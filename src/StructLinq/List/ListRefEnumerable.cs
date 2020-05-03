using System.Collections.Generic;
using StructLinq.Array;
using StructLinq.Utils;

namespace StructLinq.List
{
    public struct ListRefEnumerable<T> : IRefStructEnumerable<T, ArrayRefStructEnumerator<T>>
    {
        private List<T> list;
        public ListRefEnumerable(List<T> list)
        {
            this.list = list;
        }

        public ArrayRefStructEnumerator<T> GetEnumerator()
        {
            var layout = Unsafe.As<List<T>, ListLayout<T>>(ref list);
            return new ArrayRefStructEnumerator<T>(layout.Items, list.Count);
        }
    }
}