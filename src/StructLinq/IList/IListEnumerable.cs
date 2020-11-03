using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.Utils;

namespace StructLinq.IList
{
    public struct IListEnumerable<T> : IStructCollection<T, IListEnumerator<T>>
    {
        #region private fields
        private readonly IList<T> list;
        private int length;
        private int start;
        #endregion
        public IListEnumerable(IList<T> list, int start, int length)
        {
            this.list = list;
            this.length = length;
            this.start = start;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly IListEnumerator<T> GetEnumerator()
        {
            return new IListEnumerator<T>(list, start, Count);
        }
        public readonly int Count
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => MathHelpers.Max(0, length - start);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Slice(uint start, uint? length)
        {
            checked
            {
                this.start = (int)start + this.start;
                if (length.HasValue)
                    this.length = MathHelpers.Min((int)length.Value + this.start, this.length);
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public object Clone()
        {
            return new IListEnumerable<T>(list, start, length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T Get(int i)
        {
            return list[start + i];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Visit<TVisitor>(TVisitor visitor)
            where TVisitor : IVisitor<T>
        {
            foreach (var input in this)
            {
                if (!visitor.Visit(input))
                    return;
            }
        }
    }
}