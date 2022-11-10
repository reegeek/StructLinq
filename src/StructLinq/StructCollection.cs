using System.Runtime.CompilerServices;


namespace StructLinq
{
    public partial struct StructCollection<T, TEnumerable, TEnumerator> 
        where TEnumerable : struct, IStructCollection<T, TEnumerator>
        where TEnumerator : struct, ICollectionEnumerator<T>
    {
        internal TEnumerable enumerable;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructCollection(TEnumerable enumerable)
        {
            this.enumerable = enumerable;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnumerable<T, TEnumerable, TEnumerator> ToStructEnumerable()
        {
            return new(enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TEnumerator GetEnumerator()
        {
            return enumerable.GetEnumerator();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<T>
        {
            return enumerable.Visit(ref visitor);
        }
    }

}
