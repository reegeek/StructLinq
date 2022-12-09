using System;
using System.Runtime.CompilerServices;
using StructLinq.Concat;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct RefStructCollec<T, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefStructEnum<T, RefConcatEnumerator<T, TEnumerator, TEnumerator2>> Concat<TEnumerator2>(RefStructEnum<T, TEnumerator2> enumerable2)
            where TEnumerator2: struct, IRefStructEnumerator<T>
            => ToRefStructEnumerable().Concat(enumerable2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefStructEnum<T, RefConcatEnumerator<T, TEnumerator, TEnumerator2>> Concat<TEnumerator2>(RefStructCollec<T, TEnumerator2> enumerable2)
            where TEnumerator2: struct, IRefCollectionEnumerator<T>
            => ToRefStructEnumerable().Concat(enumerable2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last 2 arguments")]
        public RefStructEnum<T, RefConcatEnumerator<T, TEnumerator, TEnumerator2>> Concat<TEnumerator2>(RefStructEnum<T, TEnumerator2> enumerable2,
            Func<TEnumerator, IRefStructEnumerator<T>> _, Func<TEnumerator2, IRefStructEnumerator<T>> __)
            where TEnumerator2: struct, IRefStructEnumerator<T>
            => Concat(enumerable2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last 2 arguments")]
        public RefStructEnum<T, RefConcatEnumerator<T, TEnumerator, TEnumerator2>> Concat<TEnumerator2>(RefStructCollec<T, TEnumerator2> enumerable2,
            Func<TEnumerator, IRefStructEnumerator<T>> _, Func<TEnumerator2, IRefStructEnumerator<T>> __)
            where TEnumerator2: struct, IRefCollectionEnumerator<T>
                    => Concat(enumerable2.ToRefStructEnumerable());

    }

}
