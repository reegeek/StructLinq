using System.Runtime.CompilerServices;

namespace StructLinq.Take
{
    public struct TakeEnumerator<T, TEnumerator> : IStructEnumerator<T>
        where TEnumerator : struct, IStructEnumerator<T>
    {
        private TEnumerator enumerator;
        private readonly int endIndex;
        private int index;
        public TakeEnumerator(ref TEnumerator enumerator, int length)
        {
            this.enumerator = enumerator;
            endIndex = length - 1;
            index = -1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            return ++index <= endIndex && enumerator.MoveNext();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            enumerator.Reset();
            index = -1;
        }

        public T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => enumerator.Current;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            enumerator.Dispose();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TakeEnumerator<T, TEnumerator> GetEnumerator() => this;

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

    }
}
