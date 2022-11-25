using StructLinq.Utils;
using System.Runtime.CompilerServices;

namespace StructLinq.Array
{
    public struct ArrayStructEnumerator<T> : ICollectionEnumerator<T>
    {
        #region private fields
        private readonly T[] array;
        private int endIndex;
        private int start;
        private int index;
        #endregion
        public ArrayStructEnumerator(T[] array, int start, int length)
        {
            this.array = array;
            this.start = start;
            endIndex = length - 1 + start;
            index =  start - 1;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            return ++index <= endIndex;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            index = start - 1;
        }
        public readonly T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => array[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            
        }

        public readonly int Count
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => endIndex + 1 - start;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T Get(int i)
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Slice(uint start, uint? length)
        {
            checked
            {
                this.start = MathHelpers.Min((int)start + this.start, this.endIndex + 1);
                if (length.HasValue)
                    this.endIndex = MathHelpers.Min((int)length.Value + this.start - 1, this.endIndex);
                Reset();
            }
        }
    }
}
