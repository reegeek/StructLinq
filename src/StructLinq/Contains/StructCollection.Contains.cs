using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.Contains;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct StructCollec<T, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Contains<TComparer>(T x, TComparer comparer)
            where TComparer : IEqualityComparer<T>
            => ToStructEnumerable().Contains(x, comparer);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool Contains<TComparer>(T x, TComparer comparer, Func<TEnumerator, IStructEnumerator<T>> _)
            where TComparer : IEqualityComparer<T>
            => ToStructEnumerable().Contains(x, comparer);
     }

    public static partial class StructEumerableExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<T, TEnumerator>(this StructCollec<T, TEnumerator> enumerable, T x)
            where TEnumerator : struct, ICollectionEnumerator<T>
        {
            return enumerable.Contains(x, EqualityComparer<T>.Default);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<T, TEnumerator>(this StructCollec<T, TEnumerator> enumerable, T x, Func<TEnumerator, IStructEnumerator<T>> _)
            where TEnumerator : struct, ICollectionEnumerator<T>
        {
            return enumerable.Contains(x, EqualityComparer<T>.Default);
        }
    }
}
