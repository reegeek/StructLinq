using System.Runtime.CompilerServices;

namespace StructLinq.Repeat
{
    public struct RepeatEnumerator<T> : ICollectionEnumerator<T>
    {
        private readonly T element;
        private readonly uint count;
        private uint index;
        public RepeatEnumerator(T element, uint count)
        {
            this.element = element;
            this.count = count;
            index = 0;
        }

        public void Dispose()
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            return index++ < count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            index = 0;
        }

        public T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => element;
        }

        public int Count
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (int) count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T Get(int i)
        {
            return element;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<T>
        {
            for (int i = 0; i < count; i++)
            {
                if (!visitor.Visit(element))
                    return VisitStatus.VisitorFinished;
            }

            return VisitStatus.EnumeratorFinished;
        }

    }
}
