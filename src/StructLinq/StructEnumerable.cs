using System.Runtime.CompilerServices;


namespace StructLinq
{
    public partial struct StructEnumerable<T, TEnumerable, TEnumerator>
        where TEnumerable : struct,IStructEnumerable<T, TEnumerator>
        where TEnumerator : struct, IStructEnumerator<T>
    {
        internal TEnumerable enumerable;

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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<T>
        {
            return enumerable.Visit(ref visitor);
        }

    }

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
            return new StructEnumerable<T, TEnumerable, TEnumerator>(enumerable);
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
            return new RefStructEnumerable<T, TEnumerable, TEnumerator>(enumerable);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TEnumerator GetEnumerator()
        {
            return enumerable.GetEnumerator();
        }
    }

}
