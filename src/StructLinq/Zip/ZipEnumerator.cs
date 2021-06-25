using System.Runtime.CompilerServices;

namespace StructLinq.Zip
{
    public struct ZipEnumerator<T1, TEnumerator1, T2, TEnumerator2> : IStructEnumerator<(T1, T2)>
        where TEnumerator1 : struct, IStructEnumerator<T1>
        where TEnumerator2 : struct, IStructEnumerator<T2>
    {
        private TEnumerator1 enumerator1;
        private TEnumerator2 enumerator2;

        public ZipEnumerator(TEnumerator1 enumerator1, TEnumerator2 enumerator2)
        {
            this.enumerator1 = enumerator1;
            this.enumerator2 = enumerator2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            enumerator1.Dispose();
            enumerator2.Dispose();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            return enumerator1.MoveNext() && enumerator2.MoveNext();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            enumerator1.Reset();
            enumerator2.Reset();
        }

        public (T1, T2) Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (enumerator1.Current, enumerator2.Current);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<(T1, T2)>
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
}