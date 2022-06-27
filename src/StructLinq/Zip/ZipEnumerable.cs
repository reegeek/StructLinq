using System.Runtime.CompilerServices;

namespace StructLinq.Zip
{
    public readonly struct ZipEnumerable<T1, TEnumerable1, TEnumerator1, T2, TEnumerable2, TEnumerator2> : IStructEnumerable<(T1 First, T2 Second), ZipEnumerator<T1, TEnumerator1, T2, TEnumerator2>>
        where TEnumerator1 : struct, IStructEnumerator<T1>
        where TEnumerator2 : struct, IStructEnumerator<T2>
        where TEnumerable1 : IStructEnumerable<T1, TEnumerator1>
        where TEnumerable2 : IStructEnumerable<T2, TEnumerator2>
    {
        private readonly TEnumerable1 enumerable1;
        private readonly TEnumerable2 enumerable2;

        public ZipEnumerable(TEnumerable1 enumerable1, TEnumerable2 enumerable2)
        {
            this.enumerable1 = enumerable1;
            this.enumerable2 = enumerable2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ZipEnumerator<T1, TEnumerator1, T2, TEnumerator2> GetEnumerator()
        {
            return new (enumerable1.GetEnumerator(), enumerable2.GetEnumerator());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor) where TVisitor : IVisitor<(T1, T2)>
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
