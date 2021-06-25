using System.Runtime.CompilerServices;
using StructLinq.Utils.Collections;

namespace StructLinq.Reverse
{
    public struct ReverseEnumerator<T> : IStructEnumerator<T>
    {
        private PooledList<T> list;
        private int index;

        internal ReverseEnumerator(PooledList<T> list)
        {
            this.list = list;
            index = list.Size;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            return --index >= 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            index = list.Size;
        }

        public T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => list.Items[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            list.Dispose();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<T>
        {
            while (MoveNext())
            {
                if (!visitor.Visit(Current))
                    return VisitStatus.VisitorFinished;
            }
            Reset();

            return VisitStatus.EnumeratorFinished;
        }
    }

    public struct ReverseEnumerator<T, TEnumerator> : ICollectionEnumerator<T>
        where TEnumerator : struct, ICollectionEnumerator<T>
    {
        private TEnumerator inner;
        private readonly int endIndex;
        private readonly int start;
        private readonly int offset;
        private int index;

        public ReverseEnumerator(TEnumerator inner, int start, int length)
        {
            this.inner = inner;
            endIndex = length - 1 + start;
            this.start = start;
            index = start - 1;
            offset = inner.Count - 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            inner.Dispose();
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
        public T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => inner.Get(offset - index);
        }

        public int Count
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => endIndex + 1 - start;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T Get(int i)
        {
            return inner.Get(offset - start - i);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<T>
        {
            for (int i = start; i <= endIndex; i++)
            {
                var input = inner.Get(offset - i);
                if (!visitor.Visit(input))
                    return VisitStatus.VisitorFinished;
            }

            return VisitStatus.EnumeratorFinished;
        }
    }
}
