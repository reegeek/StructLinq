using System;
using System.Runtime.CompilerServices;
using StructLinq.Utils;

namespace StructLinq.Array
{
    public struct ArrayEnumerable<T> : IDirectStructCollection<T, ArrayStructEnumerator<T>>
    {
        #region private fields
        private readonly T[] array;
        private int length;
        private int start;
        #endregion
        public ArrayEnumerable(T[] array, int start, int length)
        {
            this.array = array;
            this.length = length;
            this.start = start;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ArrayStructEnumerator<T> GetEnumerator()
        {
            return new ArrayStructEnumerator<T>(array, start, Count);
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
        public readonly object Clone()
        {
            return new ArrayEnumerable<T>(array, start, length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T Get(int i)
        {
            return array[start + i];
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<T>
        {
            var count = Count;
            var s = start;
            for (int i = 0; i < count; i++)
            {
                if (!visitor.Visit(array[s+i]))
                    return VisitStatus.VisitorFinished;
            }

            return VisitStatus.EnumeratorFinished;
        }
    }
}