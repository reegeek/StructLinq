using System.Runtime.CompilerServices;

namespace StructLinq
{
    public readonly partial struct StructCollec<T, TEnumerator>
    where TEnumerator : struct, ICollectionEnumerator<T>
    {
        private readonly TEnumerator enumerator;

        public StructCollec(TEnumerator enumerator)
        {
            this.enumerator = enumerator;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TEnumerator GetEnumerator() => enumerator;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnum<T, TEnumerator> ToStructEnum() =>new(enumerator);
    }


    public interface IStructCollection<out T, out TEnumerator> : IStructEnumerable<T, TEnumerator>
        where TEnumerator : struct, ICollectionEnumerator<T>
    {
        int Count { get; }
        void Slice(uint start, uint? length);
        object Clone();
        T Get(int i);
    }
}
