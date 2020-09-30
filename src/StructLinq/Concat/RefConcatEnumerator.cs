using System.Runtime.CompilerServices;

namespace StructLinq.Concat
{
    public struct RefConcatEnumerator<T, TEnumerator1, TEnumerator2> : IRefStructEnumerator<T>
        where TEnumerator1 : struct, IRefStructEnumerator<T>
        where TEnumerator2 : struct, IRefStructEnumerator<T>
    {
        private TEnumerator1 enumerator1;
        private TEnumerator2 enumerator2;
        private bool first;

        public RefConcatEnumerator(ref TEnumerator1 enumerator1, ref TEnumerator2 enumerator2)
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

        public ref T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (first)
                    return ref enumerator1.Current;
                return ref enumerator2.Current;
            }
        }
    }
}
