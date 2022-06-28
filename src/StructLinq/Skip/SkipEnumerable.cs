using System.Runtime.CompilerServices;

namespace StructLinq.Skip
{
    public readonly struct SkipEnumerable<T, TEnumerable, TEnumerator> : IStructEnumerable<T, SkipEnumerator<T, TEnumerator>>
        where TEnumerator : struct, IStructEnumerator<T>
        where TEnumerable : IStructEnumerable<T, TEnumerator>
    {
        private readonly TEnumerable inner;
        private readonly int count;

        public SkipEnumerable(ref TEnumerable inner, int count)
        {
            this.inner = inner;
            this.count = count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public SkipEnumerator<T, TEnumerator> GetEnumerator()
        {
            var enumerator = inner.GetEnumerator();
            return new(ref enumerator, count);
        }

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
