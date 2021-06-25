using System;
using System.Runtime.CompilerServices;
using StructLinq.Utils;

namespace StructLinq.Array
{
    public struct ArrayStructEnumerator<T> : ICollectionEnumerator<T>
    {
        #region private fields
        private readonly T[] array;
        private readonly int endIndex;
        private readonly int start;
        private int index;
        #endregion
        public ArrayStructEnumerator(T[] array, int start, int length)
        {
            this.array = array;
            endIndex = length - 1 + start;
            this.start = start;
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
                for (int i = s; i <= endIndex; i++)
                {
                    if (!visitor.Visit(array[i]))
                        return VisitStatus.VisitorFinished;
                }

                return VisitStatus.EnumeratorFinished;
            }
        }

    }
}
