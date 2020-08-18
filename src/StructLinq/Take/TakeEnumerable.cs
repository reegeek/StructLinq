using System.Runtime.CompilerServices;

namespace StructLinq.Take
{
    public readonly struct TakeEnumerable<T, TEnumerable, TEnumerator> : IStructEnumerable<T, TakeEnumerator<T, TEnumerator>>
        where TEnumerator : struct, IStructEnumerator<T>
        where TEnumerable : IStructEnumerable<T, TEnumerator>
    {
        private readonly TEnumerable inner;
        private readonly uint count;

        public TakeEnumerable(ref TEnumerable inner, uint count)
        {
            this.inner = inner;
            this.count = count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TakeEnumerator<T, TEnumerator> GetEnumerator()
        {
            var enumerator = inner.GetEnumerator();
            return new TakeEnumerator<T, TEnumerator>(ref enumerator, count);
        }
    }
}
