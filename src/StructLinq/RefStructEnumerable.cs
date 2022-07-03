using System.Runtime.CompilerServices;


namespace StructLinq
{
    public partial struct RefStructEnumerable<T, TEnumerable, TEnumerator>
        where TEnumerable : struct, IRefStructEnumerable<T, TEnumerator>
        where TEnumerator : struct, IRefStructEnumerator<T>
    {
        internal TEnumerable enumerable;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefStructEnumerable(TEnumerable enumerable)
        {
            this.enumerable = enumerable;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TEnumerator GetEnumerator()
        {
            return enumerable.GetEnumerator();
        }
    }

}
