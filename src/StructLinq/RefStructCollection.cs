using System.Runtime.CompilerServices;


namespace StructLinq
{
    public partial struct RefStructCollection<T, TEnumerable, TEnumerator>
        where TEnumerable : struct, IRefStructCollection<T, TEnumerator>
        where TEnumerator : struct, IRefCollectionEnumerator<T>
    {
        internal TEnumerable enumerable;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefStructCollection(TEnumerable enumerable)
        {
            this.enumerable = enumerable;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefStructEnumerable<T, TEnumerable, TEnumerator> ToRefStructEnumerable()
        {
            return new(enumerable);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TEnumerator GetEnumerator()
        {
            return enumerable.GetEnumerator();
        }
    }

}
