using System;
using System.Runtime.CompilerServices;

namespace StructLinq.Skip
{
    public struct SkipEnumerator<T, TEnumerator> : IStructEnumerator<T>
        where TEnumerator : struct, IStructEnumerator<T>
    {
        private TEnumerator enumerator;
        private bool skipDone;
        private uint skipCount;
        public SkipEnumerator(ref TEnumerator enumerator, uint count)
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

        public T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => enumerator.Current;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            enumerator.Dispose();
        }
    }
}
