﻿using System.Runtime.CompilerServices;


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

}
