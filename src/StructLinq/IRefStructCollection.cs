using System.Runtime.CompilerServices;

namespace StructLinq
{
    public readonly partial struct RefStructCollec<T, TEnumerator>
        where TEnumerator : struct, IRefCollectionEnumerator<T>
    {
        private readonly TEnumerator enumerator;

        public RefStructCollec(TEnumerator enumerator)
        {
            this.enumerator = enumerator;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefStructEnum<T, TEnumerator> ToRefStrutEnumerable() => new(enumerator);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Count() => enumerator.Count;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T Get(int i) => enumerator.Get(i);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefStructCollec<T, TEnumerator> Slice(uint start, uint? length)
        {
            var copy = enumerator;
            copy.Slice(start, length);
            return new(copy);
        }

    }

    public interface IRefStructCollection<T, out TEnumerator> : IRefStructEnumerable<T, TEnumerator>
        where TEnumerator : struct, IRefCollectionEnumerator<T>
    {
        int Count { get; }
        void Slice(uint start, uint? length);
        object Clone();

        ref T Get(int i);
    }
}
