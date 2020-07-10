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
        public static OrderEnumerable<T, TEnumerable, TEnumerator, TComparer> Order<T, TEnumerable, TEnumerator, TComparer>(
            this TEnumerable enumerable,
            ref TComparer comparer,
            int capacity,
            ArrayPool<int> indexPool,
            ArrayPool<T> dataPool,
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TComparer : IComparer<T>
        {
            return new OrderEnumerable<T, TEnumerable, TEnumerator, TComparer>(ref enumerable, ref comparer, capacity, indexPool, dataPool);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static OrderEnumerable<T, TEnumerable, TEnumerator, TComparer> Order<T, TEnumerable, TEnumerator, TComparer>(
            this TEnumerable enumerable,
            ref TComparer comparer,
            int capacity,
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TComparer : IComparer<T>
        {
            return enumerable.Order(ref comparer, capacity, ArrayPool<int>.Shared, ArrayPool<T>.Shared, _);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static OrderEnumerable<T, TEnumerable, TEnumerator, TComparer> Order<T, TEnumerable, TEnumerator, TComparer>(
            this TEnumerable enumerable,
            ref TComparer comparer,
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TComparer : IComparer<T>
        {
            return enumerable.Order(ref comparer, 0, _);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static OrderEnumerable<T, TEnumerable, TEnumerator, Comparer<T>> Order<T, TEnumerable, TEnumerator>(
            this TEnumerable enumerable,
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var structComparer = Comparer<T>.Default;
            return enumerable.Order(ref structComparer, 0, _);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static OrderEnumerable<T, IStructEnumerable<T, TEnumerator>, TEnumerator, IComparer<T>> Order<T, TEnumerator>(
            this IStructEnumerable<T, TEnumerator> enumerable, IComparer<T> comparer)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            return enumerable.Order(ref comparer, 0, x=> x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static OrderEnumerable<T, IStructEnumerable<T, TEnumerator>, TEnumerator, Comparer<T>> Order<T, TEnumerator>(
            this IStructEnumerable<T, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var comparer = Comparer<T>.Default;
            return enumerable.Order(ref comparer, 0, x=> x);
        }
    }
}
