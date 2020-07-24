using System.Runtime.CompilerServices;

namespace StructLinq.Skip
{
    public struct RefSkipEnumerator<T, TEnumerator> : IRefStructEnumerator<T>
        where TEnumerator : struct, IRefStructEnumerator<T>
    {
        private TEnumerator enumerator;
        private bool skipDone;
        private uint skipCount;
        public RefSkipEnumerator(ref TEnumerator enumerator, uint count)
        {
            this.enumerator = enumerator;
            skipCount = count;
            skipDone = false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            if (!skipDone)
            {
                for (uint i = 0; i < skipCount; i++)
                {
                    if (!enumerator.MoveNext())
                        return false;
                }
                skipDone = true;
            }
            return enumerator.MoveNext();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            enumerator.Reset();
            skipDone = false;
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
