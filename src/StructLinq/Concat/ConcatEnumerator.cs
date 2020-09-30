using System.Runtime.CompilerServices;

namespace StructLinq.Concat
{
    public struct ConcatEnumerator<T, TEnumerator1, TEnumerator2> : IStructEnumerator<T>
     where TEnumerator1 : struct, IStructEnumerator<T>
     where TEnumerator2 : struct, IStructEnumerator<T>
    {
        private TEnumerator1 enumerator1;
        private TEnumerator2 enumerator2;
        private bool first;

        public ConcatEnumerator(ref TEnumerator1 enumerator1, ref TEnumerator2 enumerator2)
        {
            this.enumerator1 = enumerator1;
            this.enumerator2 = enumerator2;
            first = true;
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
            if (first && enumerator1.MoveNext())
                return true;
            first = false;
            return enumerator2.MoveNext();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            enumerator1.Reset();
            enumerator2.Reset();
        }

        public T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => first ? enumerator1.Current : enumerator2.Current;
        }
    }
}
