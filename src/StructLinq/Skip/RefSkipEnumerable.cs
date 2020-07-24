using System.Runtime.CompilerServices;

namespace StructLinq.Skip
{
    public readonly struct RefSkipEnumerable<T, TEnumerable, TEnumerator> : IRefStructEnumerable<T, RefSkipEnumerator<T, TEnumerator>>
        where TEnumerator : struct, IRefStructEnumerator<T>
        where TEnumerable : IRefStructEnumerable<T, TEnumerator>
    {
        private readonly TEnumerable inner;
        private readonly uint count;

        public RefSkipEnumerable(ref TEnumerable inner, uint count)
        {
            this.inner = inner;
            this.count = count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefSkipEnumerator<T, TEnumerator> GetEnumerator()
        {
            var enumerator = inner.GetEnumerator();
            return new RefSkipEnumerator<T, TEnumerator>(ref enumerator, count);
        }
    }
}
