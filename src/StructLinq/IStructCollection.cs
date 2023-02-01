using System.Runtime.CompilerServices;

namespace StructLinq
{
    public readonly partial struct StructCollec<T, TEnumerator>
    where TEnumerator : struct, ICollectionEnumerator<T>
    {
        internal readonly TEnumerator enumerator;

        public StructCollec(TEnumerator enumerator)
        {
            this.enumerator = enumerator;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TEnumerator GetEnumerator() => enumerator;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnum<T, TEnumerator> ToStructEnumerable() =>new(enumerator);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T Get(int i) => enumerator.Get(i);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructCollec<T, TEnumerator> Slice(uint start, uint? length)
        {
            var copy = enumerator;
            copy.Slice(start, length);
            return new(copy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Count() => enumerator.Count;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<T>
        {
            return enumerator.Visit(ref visitor);
        }
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
