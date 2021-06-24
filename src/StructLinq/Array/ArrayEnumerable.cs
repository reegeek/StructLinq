using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using StructLinq.Utils;

namespace StructLinq.Array
{
    public struct ArrayEnumerable<T> : IStructCollection<T, ArrayStructEnumerator<T>>
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
            return new(array, start, Count);
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
                this.start = MathHelpers.Min((int)start + this.start, this.length);
                if (length.HasValue)
                    this.length = MathHelpers.Min((int)length.Value + this.start, this.length);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly object Clone()
        {
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly T Get(int i)
        {
            return array[start + i];
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<T>
        {
            unchecked
            {
                var s = start;
                var end = Count + s;
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