using System.Runtime.CompilerServices;


namespace StructLinq
{
    public readonly partial struct StructEnumerable<T, TEnumerable, TEnumerator>
        where TEnumerable : IStructEnumerable<T, TEnumerator>
        where TEnumerator : struct, IStructEnumerator<T>
    {
        internal readonly TEnumerable enumerable;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnumerable(TEnumerable enumerable)
        {
            this.enumerable = enumerable;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TEnumerator GetEnumerator()
        {
            return enumerable.GetEnumerator();
        }
    }

    public readonly partial struct RefStructEnumerable<T, TEnumerable, TEnumerator>
        where TEnumerable : IRefStructEnumerable<T, TEnumerator>
        where TEnumerator : struct, IRefStructEnumerator<T>
    {
        internal readonly TEnumerable enumerable;

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

    public readonly partial struct StructCollection<T, TEnumerable, TEnumerator> 
        where TEnumerable : IStructCollection<T, TEnumerator>
        where TEnumerator : struct, ICollectionEnumerator<T>
    {
        internal readonly TEnumerable enumerable;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructCollection(TEnumerable enumerable)
        {
            this.enumerable = enumerable;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnumerable<T, TEnumerable, TEnumerator> ToStructEnumerable()
        {
            return new StructEnumerable<T, TEnumerable, TEnumerator>(enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TEnumerator GetEnumerator()
        {
            return enumerable.GetEnumerator();
        }
    }

    public readonly partial struct RefStructCollection<T, TEnumerable, TEnumerator>
        where TEnumerable : IRefStructCollection<T, TEnumerator>
        where TEnumerator : struct, IRefCollectionEnumerator<T>
    {
        internal readonly TEnumerable enumerable;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefStructCollection(TEnumerable enumerable)
        {
            this.enumerable = enumerable;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefStructEnumerable<T, TEnumerable, TEnumerator> ToRefStructEnumerable()
        {
            return new RefStructEnumerable<T, TEnumerable, TEnumerator>(enumerable);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TEnumerator GetEnumerator()
        {
            return enumerable.GetEnumerator();
        }
    }

}
