// ReSharper disable once CheckNamespace

using System;
using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.Distinct;
using StructLinq.Utils.Collections;

namespace StructLinq
{
    public static partial class DistinctStructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DistinctEnumerable<T, TEnumerable, TEnumerator, TComparer> Distinct<T, TEnumerable, TEnumerator, TComparer>(this TEnumerable enumerable,
            TComparer comparer, 
            int capacity,
            ArrayPool<int> bucketPool, 
            ArrayPool<Slot<T>> slotPool,
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _) 
            where TComparer : IEqualityComparer<T> 
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
        {
            return new DistinctEnumerable<T, TEnumerable, TEnumerator, TComparer>(ref enumerable, comparer, capacity, bucketPool, slotPool);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DistinctEnumerable<T, TEnumerable, TEnumerator, TComparer> Distinct<T, TEnumerable, TEnumerator, TComparer>(this TEnumerable enumerable, 
            TComparer comparer,
            int capacity,
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TComparer : IEqualityComparer<T>
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
        {
            return enumerable.Distinct(comparer, capacity,
                ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared, _);
        }

        public static DistinctEnumerable<T, TEnumerable, TEnumerator, TComparer> Distinct<T, TEnumerable, TEnumerator, TComparer>(this TEnumerable enumerable,
            TComparer comparer,
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TComparer : IEqualityComparer<T>
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
        {
            return enumerable.Distinct(comparer, 0, _);
        }

        public static DistinctEnumerable<T, TEnumerable, TEnumerator, IEqualityComparer<T>> Distinct<T, TEnumerable, TEnumerator>(this TEnumerable enumerable,
            IEqualityComparer<T> comparer,
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
        {
            return enumerable.Distinct(comparer, 0, _);
        }

        public static DistinctEnumerable<T, TEnumerable, TEnumerator, IEqualityComparer<T>> Distinct<T, TEnumerable, TEnumerator>(this TEnumerable enumerable,
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
        {
            return enumerable.Distinct<T, TEnumerable, TEnumerator>(EqualityComparer<T>.Default, _);
        }

    }
}