using System.Runtime.CompilerServices;

namespace StructLinq.Concat
{
    public readonly struct ConcatEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2> : IStructEnumerable<T, ConcatEnumerator<T, TEnumerator1, TEnumerator2>>
        where TEnumerable1 : IStructEnumerable<T, TEnumerator1>
        where TEnumerable2 : IStructEnumerable<T, TEnumerator2>
        where TEnumerator2 : struct, IStructEnumerator<T>
        where TEnumerator1 : struct, IStructEnumerator<T>
    {
        private readonly TEnumerable1 enumerable1;
        private readonly TEnumerable2 enumerable2;

        public ConcatEnumerable(TEnumerable1 enumerable1, TEnumerable2 enumerable2)
        {
            this.enumerable1 = enumerable1;
            this.enumerable2 = enumerable2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ConcatEnumerator<T, TEnumerator1, TEnumerator2> GetEnumerator()
        {
            var enum1 = enumerable1.GetEnumerator();
            var enum2 = enumerable2.GetEnumerator();
            return new ConcatEnumerator<T, TEnumerator1, TEnumerator2>(ref  enum1, ref  enum2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<T>
        {
            var visitStatus = enumerable1.Visit(ref visitor);
            if (visitStatus == VisitStatus.VisitorFinished)
                return visitStatus;
            return enumerable2.Visit(ref visitor);
        }
    }
}
