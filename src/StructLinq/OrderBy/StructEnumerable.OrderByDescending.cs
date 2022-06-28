// ReSharper disable once CheckNamespace

using System;
using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.OrderBy;

namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static OrderByKeyEnumerable<T, TEnumerable, TEnumerator, TSelector, TKey, TComparer> OrderBy<T, TEnumerable, TEnumerator, TSelector, TKey, TComparer>(
            this TEnumerable enumerable,
            ref TSelector selector,
            ref TComparer comparer,
            int capacity,
            ArrayPool<int> indexPool,
            ArrayPool<T> dataPool,
            ArrayPool<TKey> keyPool,
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _,
            Func<TSelector, IFunction<T, TKey>> __)
            where TEnumerable : IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TSelector : IFunction<T, TKey>
            where TComparer : IComparer<TKey>
        {
            return new(ref enumerable, ref selector, ref comparer, capacity, indexPool, dataPool, keyPool, true);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static OrderByKeyEnumerable<T, TEnumerable, TEnumerator, TSelector, TKey, TComparer> OrderBy<T, TEnumerable, TEnumerator, TSelector, TKey, TComparer>(
            this TEnumerable enumerable,
            ref TSelector selector,
            ref TComparer comparer,
            int capacity,
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TSelector : IFunction<T, TKey>
            where TComparer : IComparer<TKey>
        {
            return new(ref enumerable, ref selector, ref comparer, capacity, ArrayPool<int>.Shared, ArrayPool<T>.Shared, ArrayPool<TKey>.Shared, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static OrderByKeyEnumerable<T, TEnumerable, TEnumerator, TSelector, TKey, TComparer> OrderBy<T, TEnumerable, TEnumerator, TSelector, TKey, TComparer>(
            this TEnumerable enumerable,
            ref TSelector selector,
            ref TComparer comparer,
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _,
            Func<TSelector, IFunction<T, TKey>> __)
            where TEnumerable : IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TSelector : IFunction<T, TKey>
            where TComparer : IComparer<TKey>
        {
            return new(ref enumerable, ref selector, ref comparer, 0, ArrayPool<int>.Shared, ArrayPool<T>.Shared, ArrayPool<TKey>.Shared, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static OrderByKeyEnumerable<T, TEnumerable, TEnumerator, TSelector, TKey, IComparer<TKey>> OrderBy<T, TEnumerable, TEnumerator, TSelector, TKey>(
            this TEnumerable enumerable,
            ref TSelector selector,
            IComparer<TKey> comparer,
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TSelector : IFunction<T, TKey>
        {
            return new(ref enumerable, ref selector, ref comparer, 0, ArrayPool<int>.Shared, ArrayPool<T>.Shared, ArrayPool<TKey>.Shared, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static OrderByKeyEnumerable<T, TEnumerable, TEnumerator, TSelector, TKey, Comparer<TKey>> OrderBy<T, TEnumerable, TEnumerator, TSelector, TKey>(
            this TEnumerable enumerable,
            ref TSelector selector,
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TSelector : IFunction<T, TKey>
        {
            var comparer = Comparer<TKey>.Default;
            return new(ref enumerable, ref selector, ref comparer, 0, ArrayPool<int>.Shared, ArrayPool<T>.Shared, ArrayPool<TKey>.Shared, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static OrderByKeyEnumerable<T, IStructEnumerable<T, TEnumerator>, TEnumerator, StructFunction<T, TKey>, TKey, IComparer<TKey>> OrderBy<T, TEnumerator, TKey>(
            this IStructEnumerable<T, TEnumerator> enumerable,
            Func<T, TKey> selector,
            IComparer<TKey> comparer)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var structSelector = selector.ToStruct();
            return new(ref enumerable, ref structSelector, ref comparer, 0, ArrayPool<int>.Shared, ArrayPool<T>.Shared, ArrayPool<TKey>.Shared, true);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static OrderByKeyEnumerable<T, IStructEnumerable<T, TEnumerator>, TEnumerator, StructFunction<T, TKey>, TKey, Comparer<TKey>> OrderBy<T, TEnumerator, TKey>(
            this IStructEnumerable<T, TEnumerator> enumerable,
            Func<T, TKey> selector)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var comparer = Comparer<TKey>.Default;
            var structSelector = selector.ToStruct();
            return new(ref enumerable, ref structSelector, ref comparer, 0, ArrayPool<int>.Shared, ArrayPool<T>.Shared, ArrayPool<TKey>.Shared, true);
        }

    }
}
