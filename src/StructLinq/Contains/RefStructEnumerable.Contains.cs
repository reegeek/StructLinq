using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool RefInnerContains<T, TEnumerator, TComparer>(TEnumerator enumerator, T x, TComparer comparer)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TComparer : IInEqualityComparer<T>
        {
            while (enumerator.MoveNext())
            {
                 ref var enumeratorCurrent = ref enumerator.Current;
                if (comparer.Equals(in x, in enumeratorCurrent))
                    return true;
            }
            enumerator.Dispose();
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<T, TEnumerable, TEnumerator, TComparer>(this TEnumerable enumerable, T x, TComparer comparer, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TEnumerable : IRefStructEnumerable<T, TEnumerator>
            where TComparer : IInEqualityComparer<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefInnerContains(enumerator, x, comparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, T x, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TEnumerable : IRefStructEnumerable<T, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            var equalityComparer = InEqualityComparer<T>.Default;
            return RefInnerContains(enumerator, x, equalityComparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<T, TEnumerator, TComparer>(this IRefStructEnumerable<T, TEnumerator> enumerable, T x, TComparer comparer)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TComparer : IInEqualityComparer<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefInnerContains(enumerator, x, comparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<T, TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, T x)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            var equalityComparer = InEqualityComparer<T>.Default;
            return RefInnerContains(enumerator, x, equalityComparer);
        }
    }
}
