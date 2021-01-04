using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool InnerCollectionContains<T, TEnumerator, TComparer>(TEnumerator enumerator, T x, TComparer comparer)
            where TEnumerator : struct, ICollectionEnumerator<T>
            where TComparer : IEqualityComparer<T>
        {
            var count = enumerator.Count;
            for (int i = 0; i < count; i++)
            {
                var current = enumerator.Get(i);
                if (comparer.Equals(x, current))
                {
                    enumerator.Dispose();
                    return true;
                }
            }
            enumerator.Dispose();
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<T, TEnumerable, TEnumerator, TComparer>(this TEnumerable enumerable, T x, TComparer comparer, Func<TEnumerable, IStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, ICollectionEnumerator<T>
            where TEnumerable : IStructCollection<T, TEnumerator>
            where TComparer : IEqualityComparer<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return InnerCollectionContains(enumerator, x, comparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, T x, Func<TEnumerable, IStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, ICollectionEnumerator<T>
            where TEnumerable : IStructCollection<T, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            var equalityComparer = EqualityComparer<T>.Default;
            return InnerCollectionContains(enumerator, x, equalityComparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<T, TEnumerator, TComparer>(this IStructCollection<T, TEnumerator> enumerable, T x, TComparer comparer)
            where TEnumerator : struct, ICollectionEnumerator<T>
            where TComparer : IEqualityComparer<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return InnerCollectionContains(enumerator, x, comparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<T, TEnumerator>(this IStructCollection<T, TEnumerator> enumerable, T x)
            where TEnumerator : struct, ICollectionEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            var equalityComparer = EqualityComparer<T>.Default;
            return InnerCollectionContains(enumerator, x, equalityComparer);
        }
    }
}
