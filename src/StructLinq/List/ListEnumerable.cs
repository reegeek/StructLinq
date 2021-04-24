#if !NETSTANDARD1_1
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.Array;
using StructLinq.Utils;

namespace StructLinq.List
{
    public struct ListEnumerable<T> : IStructCollection<T, ArrayStructEnumerator<T>>
    {
        private readonly ListLayout<T> layout;
        private int count;
        private int start;

        internal ListEnumerable(List<T> list, int start, int count)
        {
            layout = UnsafeHelpers.As<List<T>, ListLayout<T>>(ref list);
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
            get => MathHelpers.Max(0, MathHelpers.Min(layout.Size, count) - start);
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
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T Get(int i)
        {
            return layout.Items[start + i];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<T>
        {
            unchecked
            {
                var s = start;
                var end = Count + s;
                var array = layout.Items;
                for (int i = s; i < end; i++)
                {
                    if (!visitor.Visit(array[i]))
                        return VisitStatus.VisitorFinished;
                }

                return VisitStatus.EnumeratorFinished;
            }
        }
    }
}
#endif