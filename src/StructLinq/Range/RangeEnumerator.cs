using System.Runtime.CompilerServices;

namespace StructLinq.Range
{
    public struct RangeEnumerator : ICollectionEnumerator<int>
    {
        #region private fields
        private int index;
        private readonly int end;
        private readonly int start;
        #endregion
        public RangeEnumerator(int start, int count)
        {
            end = start + count - 1;
            this.start = start;
            index = start - 1;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            return ++index <= end;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            index = start - 1;
        }
        public readonly int Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => index;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            
        }

        public int Count
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => end + 1 - start;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Get(int i)
        {
            return start + i;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<int>
        {
            var n = Count;
            var s = start;
            for (int i = 0; i < n; i++)
            {
                if (!visitor.Visit(s + i))
                    return VisitStatus.VisitorFinished;
            }

            return VisitStatus.EnumeratorFinished;
        }

    }
}