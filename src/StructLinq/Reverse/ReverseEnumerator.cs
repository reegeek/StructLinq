using System.Runtime.CompilerServices;
using StructLinq.Utils;
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
            for(int i = list.Size -1; i >= 0; i--)
            {
                if (!visitor.Visit(list.Items[i]))
                    return VisitStatus.VisitorFinished;

            }
            return VisitStatus.EnumeratorFinished;
        }

    }

    public struct ReverseEnumerator<T, TEnumerator> : ICollectionEnumerator<T>
        where TEnumerator : struct, ICollectionEnumerator<T>
    {
        private readonly TEnumerator inner;
        private int endIndex;
        private int start;
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

        //TODO: improve it
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReverseEnumerator<T, TEnumerator> GetEnumerator() => this;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<T>
        {
            foreach (var input in this)
            {
                if (!visitor.Visit(input))
                    return VisitStatus.VisitorFinished;
            }

            return VisitStatus.EnumeratorFinished;
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
