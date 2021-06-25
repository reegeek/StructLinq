using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StructLinq.IList
{
    public struct IListEnumerator<T, TList> : ICollectionEnumerator<T>
        where TList : IList<T>
    {
        #region private fields
        private readonly TList list;
        private readonly int endIndex;
        private readonly int start;
        private int index;

        #endregion
        public IListEnumerator(TList list, int start, int length)
        {
            this.list = list;
            endIndex = length - 1 + start;
            index = start - 1;
            this.start = start;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            return ++index <= endIndex;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            index = start-1;
        }
        public T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => list[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            if (list is IDisposable dispose)
            {
                dispose.Dispose();
            }
        }
        public int Count
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => endIndex + 1 - start;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T Get(int i)
        {
            return list[start + i];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<T>
        {
            var count = Count;
            var s = start;
            for (int i = 0; i < count; i++)
            {
                if (!visitor.Visit(list[s+i]))
                    return VisitStatus.VisitorFinished;
            }

            return VisitStatus.EnumeratorFinished;
        }
    }
}