using System.Runtime.CompilerServices;

namespace StructLinq.Skip
{
    public struct RefSkipEnumerator<T, TEnumerator> : IRefStructEnumerator<T>
        where TEnumerator : struct, IRefStructEnumerator<T>
    {
        private TEnumerator enumerator;
        private int count;
        private int skipCount;
        public RefSkipEnumerator(ref TEnumerator enumerator, int count)
        {
            this.enumerator = enumerator;
            skipCount = count;
            this.count = count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            while (count-- > 0 && enumerator.MoveNext())
            {}
            return enumerator.MoveNext();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            enumerator.Reset();
            count = skipCount;
        }

        public ref T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => ref enumerator.Current;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            enumerator.Dispose();
        }
    }
}
