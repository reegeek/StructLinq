using System.Runtime.CompilerServices;

namespace StructLinq.Skip
{
    public readonly struct SkipEnumerable<T, TEnumerable, TEnumerator> : IStructEnumerable<T, SkipEnumerator<T, TEnumerator>>
        where TEnumerator : struct, IStructEnumerator<T>
        where TEnumerable : IStructEnumerable<T, TEnumerator>
    {
        private readonly TEnumerable inner;
        private readonly uint count;

        public SkipEnumerable(ref TEnumerable inner, uint count)
        {
            this.inner = inner;
            this.count = count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public SkipEnumerator<T, TEnumerator> GetEnumerator()
        {
            var enumerator = inner.GetEnumerator();
            return new SkipEnumerator<T, TEnumerator>(ref enumerator, count);
        }
    }
}
