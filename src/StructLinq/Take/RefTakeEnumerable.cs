using System.Runtime.CompilerServices;

namespace StructLinq.Take
{
    public readonly struct RefTakeEnumerable<T, TEnumerable, TEnumerator> : IRefStructEnumerable<T, RefTakeEnumerator<T, TEnumerator>>
        where TEnumerator : struct, IRefStructEnumerator<T>
        where TEnumerable : IRefStructEnumerable<T, TEnumerator>
    {
        private readonly TEnumerable inner;
        private readonly uint count;

        public RefTakeEnumerable(ref TEnumerable inner, uint count)
        {
            this.inner = inner;
            this.count = count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefTakeEnumerator<T, TEnumerator> GetEnumerator()
        {
            var enumerator = inner.GetEnumerator();
            return new RefTakeEnumerator<T, TEnumerator>(ref enumerator, count);
        }
    }
}
