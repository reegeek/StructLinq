// ReSharper disable once CheckNamespace

using System;
using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.Union;
using StructLinq.Utils.Collections;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UnionEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2, TComparer>
            Union<T, TEnumerable1, TEnumerator1, TEnumerable2, TEnumerator2, TComparer>(
                this TEnumerable1 enumerable,
                TEnumerable2 enumerable2, 
                TComparer comparer,
                int capacity,
                ArrayPool<int> bucketPool, 
                ArrayPool<Slot<T>> slotPool,
                Func<TEnumerable1, IStructEnumerable<T, TEnumerator1>> _, 
                Func<TEnumerable2, IStructEnumerable<T, TEnumerator2>> __) 
            where TComparer : IEqualityComparer<T> 
            where TEnumerator1 : struct, IStructEnumerator<T>
            where TEnumerable1 : IStructEnumerable<T, TEnumerator1>
            where TEnumerator2 : struct, IStructEnumerator<T>
            where TEnumerable2 : IStructEnumerable<T, TEnumerator2>
        {
            return new UnionEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2, TComparer>(ref enumerable, ref enumerable2, comparer, capacity, bucketPool, slotPool); 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UnionEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2, TComparer>
            Union<T, TEnumerable1, TEnumerator1, TEnumerable2, TEnumerator2, TComparer>(
                this TEnumerable1 enumerable,
                TEnumerable2 enumerable2, 
                TComparer comparer,
                int capacity,
                Func<TEnumerable1, IStructEnumerable<T, TEnumerator1>> _, 
                Func<TEnumerable2, IStructEnumerable<T, TEnumerator2>> __) 
            where TComparer : IEqualityComparer<T> 
            where TEnumerator1 : struct, IStructEnumerator<T>
            where TEnumerable1 : IStructEnumerable<T, TEnumerator1>
            where TEnumerator2 : struct, IStructEnumerator<T>
            where TEnumerable2 : IStructEnumerable<T, TEnumerator2>
        {
            return new UnionEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2, TComparer>(ref enumerable, ref enumerable2, comparer, capacity, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UnionEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2, TComparer>
            Union<T, TEnumerable1, TEnumerator1, TEnumerable2, TEnumerator2, TComparer>(
                this TEnumerable1 enumerable,
                TEnumerable2 enumerable2, 
                TComparer comparer,
                Func<TEnumerable1, IStructEnumerable<T, TEnumerator1>> _, 
                Func<TEnumerable2, IStructEnumerable<T, TEnumerator2>> __) 
            where TComparer : IEqualityComparer<T> 
            where TEnumerator1 : struct, IStructEnumerator<T>
            where TEnumerable1 : IStructEnumerable<T, TEnumerator1>
            where TEnumerator2 : struct, IStructEnumerator<T>
            where TEnumerable2 : IStructEnumerable<T, TEnumerator2>
        {
            return new UnionEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2, TComparer>(ref enumerable, ref enumerable2, comparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UnionEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2, IEqualityComparer<T>>
            Union<T, TEnumerable1, TEnumerator1, TEnumerable2, TEnumerator2>(
                this TEnumerable1 enumerable,
                TEnumerable2 enumerable2, 
                IEqualityComparer<T> comparer,
                Func<TEnumerable1, IStructEnumerable<T, TEnumerator1>> _, 
                Func<TEnumerable2, IStructEnumerable<T, TEnumerator2>> __)
            where TEnumerator1 : struct, IStructEnumerator<T>
            where TEnumerable1 : IStructEnumerable<T, TEnumerator1>
            where TEnumerator2 : struct, IStructEnumerator<T>
            where TEnumerable2 : IStructEnumerable<T, TEnumerator2>
        {
            return new UnionEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2, IEqualityComparer<T>>(ref enumerable, ref enumerable2, comparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UnionEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2, EqualityComparer<T>>
            Union<T, TEnumerable1, TEnumerator1, TEnumerable2, TEnumerator2>(
                this TEnumerable1 enumerable,
                TEnumerable2 enumerable2, 
                Func<TEnumerable1, IStructEnumerable<T, TEnumerator1>> _, 
                Func<TEnumerable2, IStructEnumerable<T, TEnumerator2>> __)
            where TEnumerator1 : struct, IStructEnumerator<T>
            where TEnumerable1 : IStructEnumerable<T, TEnumerator1>
            where TEnumerator2 : struct, IStructEnumerator<T>
            where TEnumerable2 : IStructEnumerable<T, TEnumerator2>
        {
            var equalityComparer = EqualityComparer<T>.Default;
            return new UnionEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2, EqualityComparer<T>>(ref enumerable, ref enumerable2, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UnionEnumerable<T, IStructEnumerable<T, TEnumerator1>, IStructEnumerable<T, TEnumerator2>, TEnumerator1, TEnumerator2, IEqualityComparer<T>>
            Union<T, TEnumerator1, TEnumerator2>(
                this IStructEnumerable<T, TEnumerator1> enumerable,
                IStructEnumerable<T, TEnumerator2> enumerable2, 
                IEqualityComparer<T> comparer)
            where TEnumerator1 : struct, IStructEnumerator<T>
            where TEnumerator2 : struct, IStructEnumerator<T>
        {
            return new UnionEnumerable<T, IStructEnumerable<T, TEnumerator1>, IStructEnumerable<T, TEnumerator2>, TEnumerator1, TEnumerator2, IEqualityComparer<T>>(ref enumerable, ref enumerable2, comparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UnionEnumerable<T, IStructEnumerable<T, TEnumerator1>, IStructEnumerable<T, TEnumerator2>, TEnumerator1, TEnumerator2, EqualityComparer<T>>
            Union<T, TEnumerator1, TEnumerator2>(
                this IStructEnumerable<T, TEnumerator1> enumerable,
                IStructEnumerable<T, TEnumerator2> enumerable2)
            where TEnumerator1 : struct, IStructEnumerator<T>
            where TEnumerator2 : struct, IStructEnumerator<T>
        {
            var equalityComparer = EqualityComparer<T>.Default;
            return new UnionEnumerable<T, IStructEnumerable<T, TEnumerator1>, IStructEnumerable<T, TEnumerator2>, TEnumerator1, TEnumerator2, EqualityComparer<T>>(ref enumerable, ref enumerable2, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared);
        }
    }
}