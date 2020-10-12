using System;
using System.Runtime.CompilerServices;

namespace StructLinq.Skip
{
    public struct SkipEnumerator<T, TEnumerator> : IStructEnumerator<T>
        where TEnumerator : struct, IStructEnumerator<T>
    {
        private TEnumerator enumerator;
        private int count;
        private int skipCount;
        public SkipEnumerator(ref TEnumerator enumerator, int count)
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
