using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct RefStructCollec<T, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Contains<TComparer>(T x, TComparer comparer)
            where TComparer : IInEqualityComparer<T>
            => ToRefStructEnumerable().Contains(x, comparer);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool Contains<TComparer>(T x, TComparer comparer, Func<TEnumerator, IRefStructEnumerator<T>> _)
            where TComparer : IInEqualityComparer<T>
            => ToRefStructEnumerable().Contains(x, comparer);
    }

    public static partial class StructEumerableExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<T, TEnumerator>(this RefStructCollec<T, TEnumerator> enumerable, T x)
            where TEnumerator : struct, IRefCollectionEnumerator<T>
        {
            return enumerable.Contains(x, InEqualityComparer<T>.Default);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<T, TEnumerator>(this RefStructCollec<T, TEnumerator> enumerable, T x, Func<TEnumerator, IRefStructEnumerator<T>> _)
            where TEnumerator : struct, IRefCollectionEnumerator<T>
        {
            return enumerable.Contains(x, InEqualityComparer<T>.Default);
        }
    }

}
