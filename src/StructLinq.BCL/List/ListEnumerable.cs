using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.Array;
using StructLinq.Utils;

namespace StructLinq.BCL.List
{
    public struct ListEnumerable<T> : IStructCollection<T, ArrayStructEnumerator<T>>
    {
        private readonly List<T> list;
        private readonly ListLayout<T> layout;
        private int count;
        private int start;

        internal ListEnumerable(List<T> list, int start, int count)
        {
            this.list = list;
            layout = Unsafe.As<List<T>, ListLayout<T>>(ref list);
            this.count = count;
            this.start = start;
        }
        public ListEnumerable(List<T> list) : this(list, 0, int.MaxValue)
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ArrayStructEnumerator<T> GetEnumerator()
        {
            return new ArrayStructEnumerator<T>(layout.Items, start, Count);
        }

        public readonly int Count
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => MathHelpers.Max(0, MathHelpers.Min(list.Count, count) - start);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Slice(uint start, uint? length)
        {
            checked
            {
                this.start = (int)start + this.start;
                if (length.HasValue)
                    this.count = (int)length.Value + this.start;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly object Clone()
        {
            return new ListEnumerable<T>(list, start, count);
        }

    }
}