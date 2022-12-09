using System;
using System.Runtime.CompilerServices;
using StructLinq.Concat;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct StructCollec<T, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnum<T, ConcatEnumerator<T, TEnumerator, TEnumerator2>> Concat<TEnumerator2>(StructEnum<T, TEnumerator2> enumerable2)
            where TEnumerator2: struct, IStructEnumerator<T>
            => ToStructEnumerable().Concat(enumerable2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnum<T, ConcatEnumerator<T, TEnumerator, TEnumerator2>> Concat<TEnumerator2>(StructCollec<T, TEnumerator2> enumerable2)
            where TEnumerator2: struct, ICollectionEnumerator<T>
            => ToStructEnumerable().Concat(enumerable2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last 2 arguments")]
        public StructEnum<T, ConcatEnumerator<T, TEnumerator, TEnumerator2>> Concat<TEnumerator2>(StructEnum<T, TEnumerator2> enumerable2,
            Func<TEnumerator, IStructEnumerator<T>> _, Func<TEnumerator2, IStructEnumerator<T>> __)
            where TEnumerator2: struct, IStructEnumerator<T>
            => Concat(enumerable2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last 2 arguments")]
        public StructEnum<T, ConcatEnumerator<T, TEnumerator, TEnumerator2>> Concat<TEnumerator2>(StructCollec<T, TEnumerator2> enumerable2,
            Func<TEnumerator, IStructEnumerator<T>> _, Func<TEnumerator2, IStructEnumerator<T>> __)
            where TEnumerator2: struct, ICollectionEnumerator<T>
                    => Concat(enumerable2.ToStructEnumerable());

    }

}
