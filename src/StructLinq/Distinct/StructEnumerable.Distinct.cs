// ReSharper disable once CheckNamespace

using System;
using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.Distinct;
using StructLinq.Utils.Collections;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
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
            where TEnumerable : IStructEnumerable<T, TEnumerator>
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
            where TEnumerable : IStructEnumerable<T, TEnumerator>
        {
            return enumerable.Distinct(comparer, capacity,
                ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared, _);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DistinctEnumerable<T, TEnumerable, TEnumerator, TComparer> Distinct<T, TEnumerable, TEnumerator, TComparer>(this TEnumerable enumerable,
                                                                                                                                  TComparer comparer,
                                                                                                                                  Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TComparer : IEqualityComparer<T>
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
        {
            return enumerable.Distinct(comparer, 0, _);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DistinctEnumerable<T, TEnumerable, TEnumerator, IEqualityComparer<T>> Distinct<T, TEnumerable, TEnumerator>(this TEnumerable enumerable,
                                                                                                                                  IEqualityComparer<T> comparer,
                                                                                                                                  Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : IStructEnumerable<T, TEnumerator>
        {
            return enumerable.Distinct(comparer, 0, _);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DistinctEnumerable<T, TEnumerable, TEnumerator, EqualityComparer<T>> Distinct<T, TEnumerable, TEnumerator>(this TEnumerable enumerable,
                                                                                                                                 Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : IStructEnumerable<T, TEnumerator>
        {
            var equalityComparer = EqualityComparer<T>.Default;
            return new DistinctEnumerable<T, TEnumerable, TEnumerator, EqualityComparer<T>>(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DistinctEnumerable<T, IStructEnumerable<T, TEnumerator>, TEnumerator, IEqualityComparer<T>> Distinct<T,TEnumerator>(
            this IStructEnumerable<T, TEnumerator> enumerable,
            IEqualityComparer<T> comparer)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            return Distinct(enumerable, comparer, x => x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DistinctEnumerable<T, IStructEnumerable<T, TEnumerator>, TEnumerator, EqualityComparer<T>> Distinct<T, TEnumerator>(
            this IStructEnumerable<T, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var equalityComparer = EqualityComparer<T>.Default;
            return new DistinctEnumerable<T, IStructEnumerable<T, TEnumerator>, TEnumerator, EqualityComparer<T>>(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefDistinctEnumerable<T, TEnumerable, TEnumerator, TComparer> Distinct<T, TEnumerable, TEnumerator, TComparer>(this TEnumerable enumerable,
            TComparer comparer, 
            int capacity,
            ArrayPool<int> bucketPool, 
            ArrayPool<Slot<T>> slotPool,
            Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _) 
            where TComparer : IInEqualityComparer<T> 
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TEnumerable : struct, IRefStructEnumerable<T, TEnumerator>
        {
            return new RefDistinctEnumerable<T, TEnumerable, TEnumerator, TComparer>(ref enumerable, comparer, capacity, bucketPool, slotPool);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefDistinctEnumerable<T, TEnumerable, TEnumerator, TComparer> Distinct<T, TEnumerable, TEnumerator, TComparer>(this TEnumerable enumerable, 
                                                                                                                                     TComparer comparer,
                                                                                                                                     int capacity,
                                                                                                                                     Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TComparer : IInEqualityComparer<T>
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TEnumerable : struct, IRefStructEnumerable<T, TEnumerator>
        {
            return enumerable.Distinct(comparer, capacity,
                ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared, _);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefDistinctEnumerable<T, TEnumerable, TEnumerator, TComparer> Distinct<T, TEnumerable, TEnumerator, TComparer>(this TEnumerable enumerable,
                                                                                                                                     TComparer comparer,
                                                                                                                                     Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TComparer : IInEqualityComparer<T>
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TEnumerable : struct, IRefStructEnumerable<T, TEnumerator>
        {
            return enumerable.Distinct(comparer, 0, _);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefDistinctEnumerable<T, TEnumerable, TEnumerator, IInEqualityComparer<T>> Distinct<T, TEnumerable, TEnumerator>(this TEnumerable enumerable,
                                                                                                                                     IInEqualityComparer<T> comparer,
                                                                                                                                     Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TEnumerable : struct, IRefStructEnumerable<T, TEnumerator>
        {
            return enumerable.Distinct(comparer, 0, _);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefDistinctEnumerable<T, TEnumerable, TEnumerator, StructInEqualityComparer<T>> Distinct<T, TEnumerable, TEnumerator>(this TEnumerable enumerable,
                                                                                                                                            Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TEnumerable : struct, IRefStructEnumerable<T, TEnumerator>
        {
            return enumerable.Distinct(InEqualityComparer<T>.Default, _);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefDistinctEnumerable<T, IRefStructEnumerable<T, TEnumerator>, TEnumerator, IInEqualityComparer<T>> Distinct<T,TEnumerator>(
            this IRefStructEnumerable<T, TEnumerator> enumerable,
            IInEqualityComparer<T> comparer)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            return new RefDistinctEnumerable<T, IRefStructEnumerable<T, TEnumerator>, TEnumerator, IInEqualityComparer<T>>(ref enumerable, comparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared);

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefDistinctEnumerable<T, IRefStructEnumerable<T, TEnumerator>, TEnumerator, IInEqualityComparer<T>> Distinct<T, TEnumerator>(
            this IRefStructEnumerable<T, TEnumerator> enumerable)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var equalityComparer = InEqualityComparer<T>.Default;
            return new RefDistinctEnumerable<T, IRefStructEnumerable<T, TEnumerator>, TEnumerator, IInEqualityComparer<T>>(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared);
        }
    }
}