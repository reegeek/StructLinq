// ReSharper disable once CheckNamespace

using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using StructLinq.Intersect;
using StructLinq.Utils.Collections;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefIntersectEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2, TComparer>
            Intersect<T, TEnumerable1, TEnumerator1, TEnumerable2, TEnumerator2, TComparer>(
                this TEnumerable1 enumerable,
                TEnumerable2 enumerable2, 
                TComparer comparer,
                int capacity,
                ArrayPool<int> bucketPool, 
                ArrayPool<Slot<T>> slotPool,
                Func<TEnumerable1, IRefStructEnumerable<T, TEnumerator1>> _, 
                Func<TEnumerable2, IRefStructEnumerable<T, TEnumerator2>> __) 
            where TComparer : IInEqualityComparer<T> 
            where TEnumerator1 : struct, IRefStructEnumerator<T>
            where TEnumerable1 : IRefStructEnumerable<T, TEnumerator1>
            where TEnumerator2 : struct, IRefStructEnumerator<T>
            where TEnumerable2 : IRefStructEnumerable<T, TEnumerator2>
        {
            return new(ref enumerable, ref enumerable2, comparer, capacity, bucketPool, slotPool); 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefIntersectEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2, TComparer>
            Intersect<T, TEnumerable1, TEnumerator1, TEnumerable2, TEnumerator2, TComparer>(
                this TEnumerable1 enumerable,
                TEnumerable2 enumerable2, 
                TComparer comparer,
                int capacity,
                Func<TEnumerable1, IRefStructEnumerable<T, TEnumerator1>> _, 
                Func<TEnumerable2, IRefStructEnumerable<T, TEnumerator2>> __) 
            where TComparer : IInEqualityComparer<T> 
            where TEnumerator1 : struct, IRefStructEnumerator<T>
            where TEnumerable1 : IRefStructEnumerable<T, TEnumerator1>
            where TEnumerator2 : struct, IRefStructEnumerator<T>
            where TEnumerable2 : IRefStructEnumerable<T, TEnumerator2>
        {
            return new(ref enumerable, ref enumerable2, comparer, capacity, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefIntersectEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2, TComparer>
            Intersect<T, TEnumerable1, TEnumerator1, TEnumerable2, TEnumerator2, TComparer>(
                this TEnumerable1 enumerable,
                TEnumerable2 enumerable2, 
                TComparer comparer,
                Func<TEnumerable1, IRefStructEnumerable<T, TEnumerator1>> _, 
                Func<TEnumerable2, IRefStructEnumerable<T, TEnumerator2>> __) 
            where TComparer : IInEqualityComparer<T> 
            where TEnumerator1 : struct, IRefStructEnumerator<T>
            where TEnumerable1 : IRefStructEnumerable<T, TEnumerator1>
            where TEnumerator2 : struct, IRefStructEnumerator<T>
            where TEnumerable2 : IRefStructEnumerable<T, TEnumerator2>
        {
            return new(ref enumerable, ref enumerable2, comparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefIntersectEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2, IInEqualityComparer<T>>
            Intersect<T, TEnumerable1, TEnumerator1, TEnumerable2, TEnumerator2>(
                this TEnumerable1 enumerable,
                TEnumerable2 enumerable2, 
                IInEqualityComparer<T> comparer,
                Func<TEnumerable1, IRefStructEnumerable<T, TEnumerator1>> _, 
                Func<TEnumerable2, IRefStructEnumerable<T, TEnumerator2>> __)
            where TEnumerator1 : struct, IRefStructEnumerator<T>
            where TEnumerable1 : IRefStructEnumerable<T, TEnumerator1>
            where TEnumerator2 : struct, IRefStructEnumerator<T>
            where TEnumerable2 : IRefStructEnumerable<T, TEnumerator2>
        {
            return new(ref enumerable, ref enumerable2, comparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefIntersectEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2, StructInEqualityComparer<T>>
            Intersect<T, TEnumerable1, TEnumerator1, TEnumerable2, TEnumerator2>(
                this TEnumerable1 enumerable,
                TEnumerable2 enumerable2, 
                Func<TEnumerable1, IRefStructEnumerable<T, TEnumerator1>> _, 
                Func<TEnumerable2, IRefStructEnumerable<T, TEnumerator2>> __)
            where TEnumerator1 : struct, IRefStructEnumerator<T>
            where TEnumerable1 : IRefStructEnumerable<T, TEnumerator1>
            where TEnumerator2 : struct, IRefStructEnumerator<T>
            where TEnumerable2 : IRefStructEnumerable<T, TEnumerator2>
        {
            var equalityComparer = InEqualityComparer<T>.Default;
            return new(ref enumerable, ref enumerable2, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefIntersectEnumerable<T, IRefStructEnumerable<T, TEnumerator1>, IRefStructEnumerable<T, TEnumerator2>, TEnumerator1, TEnumerator2, IInEqualityComparer<T>>
            Intersect<T, TEnumerator1, TEnumerator2>(
                this IRefStructEnumerable<T, TEnumerator1> enumerable,
                IRefStructEnumerable<T, TEnumerator2> enumerable2, 
                IInEqualityComparer<T> comparer)
            where TEnumerator1 : struct, IRefStructEnumerator<T>
            where TEnumerator2 : struct, IRefStructEnumerator<T>
        {
            return new(ref enumerable, ref enumerable2, comparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefIntersectEnumerable<T, IRefStructEnumerable<T, TEnumerator1>, IRefStructEnumerable<T, TEnumerator2>, TEnumerator1, TEnumerator2, StructInEqualityComparer<T>>
            Intersect<T, TEnumerator1, TEnumerator2>(
                this IRefStructEnumerable<T, TEnumerator1> enumerable,
                IRefStructEnumerable<T, TEnumerator2> enumerable2)
            where TEnumerator1 : struct, IRefStructEnumerator<T>
            where TEnumerator2 : struct, IRefStructEnumerator<T>
        {
            var equalityComparer = InEqualityComparer<T>.Default;
            return new(ref enumerable, ref enumerable2, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared);
        }
    }
}