﻿// ReSharper disable once CheckNamespace

#nullable enable
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.Except;
using StructLinq.Utils.Collections;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExceptEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2, TComparer>
            Except<T, TEnumerable1, TEnumerator1, TEnumerable2, TEnumerator2, TComparer>(
                this TEnumerable1 enumerable,
                TEnumerable2 enumerable2, 
                TComparer comparer,
                int capacity,
                Func<TEnumerable1, IStructEnumerable<T, TEnumerator1>> _, 
                Func<TEnumerable2, IStructEnumerable<T, TEnumerator2>> __) 
            where TComparer : IEqualityComparer<T> 
            where TEnumerator1 : struct, IStructEnumerator<T>
            where TEnumerable1 : struct, IStructEnumerable<T, TEnumerator1>
            where TEnumerator2 : struct, IStructEnumerator<T>
            where TEnumerable2 : struct, IStructEnumerable<T, TEnumerator2>
        {
            return new(ref enumerable, ref enumerable2, comparer, capacity, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExceptEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2, TComparer>
            Except<T, TEnumerable1, TEnumerator1, TEnumerable2, TEnumerator2, TComparer>(
                this TEnumerable1 enumerable,
                TEnumerable2 enumerable2, 
                TComparer comparer,
                Func<TEnumerable1, IStructEnumerable<T, TEnumerator1>> _, 
                Func<TEnumerable2, IStructEnumerable<T, TEnumerator2>> __) 
            where TComparer : IEqualityComparer<T> 
            where TEnumerator1 : struct, IStructEnumerator<T>
            where TEnumerable1 : struct, IStructEnumerable<T, TEnumerator1>
            where TEnumerator2 : struct, IStructEnumerator<T>
            where TEnumerable2 : struct, IStructEnumerable<T, TEnumerator2>
        {
            return new(ref enumerable, ref enumerable2, comparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExceptEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2, IEqualityComparer<T>>
            Except<T, TEnumerable1, TEnumerator1, TEnumerable2, TEnumerator2>(
                this TEnumerable1 enumerable,
                TEnumerable2 enumerable2, 
                IEqualityComparer<T> comparer,
                Func<TEnumerable1, IStructEnumerable<T, TEnumerator1>> _, 
                Func<TEnumerable2, IStructEnumerable<T, TEnumerator2>> __)
            where TEnumerator1 : struct, IStructEnumerator<T>
            where TEnumerable1 : struct, IStructEnumerable<T, TEnumerator1>
            where TEnumerator2 : struct, IStructEnumerator<T>
            where TEnumerable2 : struct, IStructEnumerable<T, TEnumerator2>
        {
            return new(ref enumerable, ref enumerable2, comparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExceptEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2, EqualityComparer<T>>
            Except<T, TEnumerable1, TEnumerator1, TEnumerable2, TEnumerator2>(
                this TEnumerable1 enumerable,
                TEnumerable2 enumerable2, 
                Func<TEnumerable1, IStructEnumerable<T, TEnumerator1>> _, 
                Func<TEnumerable2, IStructEnumerable<T, TEnumerator2>> __)
            where TEnumerator1 : struct, IStructEnumerator<T>
            where TEnumerable1 : struct, IStructEnumerable<T, TEnumerator1>
            where TEnumerator2 : struct, IStructEnumerator<T>
            where TEnumerable2 : struct, IStructEnumerable<T, TEnumerator2>
        {
            var equalityComparer = EqualityComparer<T>.Default;
            return new(ref enumerable, ref enumerable2, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExceptEnumerable<T, IStructEnumerable<T, TEnumerator1>, IStructEnumerable<T, TEnumerator2>, TEnumerator1, TEnumerator2, IEqualityComparer<T>>
            Except<T, TEnumerator1, TEnumerator2>(
                this IStructEnumerable<T, TEnumerator1> enumerable,
                IStructEnumerable<T, TEnumerator2> enumerable2, 
                IEqualityComparer<T> comparer)
            where TEnumerator1 : struct, IStructEnumerator<T>
            where TEnumerator2 : struct, IStructEnumerator<T>
        {
            return new(ref enumerable, ref enumerable2, comparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExceptEnumerable<T, IStructEnumerable<T, TEnumerator1>, IStructEnumerable<T, TEnumerator2>, TEnumerator1, TEnumerator2, EqualityComparer<T>>
            Except<T, TEnumerator1, TEnumerator2>(
                this IStructEnumerable<T, TEnumerator1> enumerable,
                IStructEnumerable<T, TEnumerator2> enumerable2)
            where TEnumerator1 : struct, IStructEnumerator<T>
            where TEnumerator2 : struct, IStructEnumerator<T>
        {
            var equalityComparer = EqualityComparer<T>.Default;
            return new(ref enumerable, ref enumerable2, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<T>>.Shared);
        }
    }

    public partial struct StructEnumerable<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last two arguments")]
        public StructEnumerable<T, ExceptEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, TComparer>, ExceptEnumerator<T, TEnumerator, TEnumerator2, TComparer>>
            Except<TEnumerable2, TEnumerator2, TComparer>(
                StructEnumerable<T, TEnumerable2, TEnumerator2>  enumerable2, 
                TComparer comparer,
                int capacity,
                ArrayPool<int> bucketPool, 
                ArrayPool<Slot<T>> slotPool,
                Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _, 
                Func<TEnumerable2, IStructEnumerable<T, TEnumerator2>> __) 
            where TComparer : IEqualityComparer<T> 
            where TEnumerator2 : struct, IStructEnumerator<T>
            where TEnumerable2 : struct, IStructEnumerable<T, TEnumerator2>
        {
            return new (new(ref enumerable, ref enumerable2.enumerable, comparer, capacity, bucketPool, slotPool)); 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnumerable<T, ExceptEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, TComparer>, ExceptEnumerator<T, TEnumerator, TEnumerator2, TComparer>>
            Except<TEnumerable2, TEnumerator2, TComparer>(
                StructEnumerable<T, TEnumerable2, TEnumerator2>  enumerable2, 
                TComparer comparer,
                int capacity = 0,
                ArrayPool<int>? bucketPool = null, 
                ArrayPool<Slot<T>>? slotPool = null) 
            where TComparer : IEqualityComparer<T>
            where TEnumerator2 : struct, IStructEnumerator<T>
            where TEnumerable2 : struct, IStructEnumerable<T, TEnumerator2>
        {
            bucketPool ??= ArrayPool<int>.Shared;
            slotPool ??= ArrayPool<Slot<T>>.Shared;
            return new (new(ref enumerable, ref enumerable2.enumerable, comparer, capacity, bucketPool, slotPool)); 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last two arguments")]
        public StructEnumerable<T, ExceptEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, TComparer>, ExceptEnumerator<T, TEnumerator, TEnumerator2, TComparer>>
            Except<TEnumerable2, TEnumerator2, TComparer>(
                StructCollection<T, TEnumerable2, TEnumerator2>  enumerable2, 
                TComparer comparer,
                int capacity,
                ArrayPool<int> bucketPool, 
                ArrayPool<Slot<T>> slotPool,
                Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _, 
                Func<TEnumerable2, IStructEnumerable<T, TEnumerator2>> __) 
            where TComparer : IEqualityComparer<T> 
            where TEnumerator2 : struct, ICollectionEnumerator<T>
            where TEnumerable2 : struct, IStructCollection<T, TEnumerator2>
        {
            return new (new(ref enumerable, ref enumerable2.enumerable, comparer, capacity, bucketPool, slotPool)); 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnumerable<T, ExceptEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, TComparer>, ExceptEnumerator<T, TEnumerator, TEnumerator2, TComparer>>
            Except<TEnumerable2, TEnumerator2, TComparer>(
                StructCollection<T, TEnumerable2, TEnumerator2>  enumerable2, 
                TComparer comparer,
                int capacity,
                ArrayPool<int> bucketPool, 
                ArrayPool<Slot<T>> slotPool) 
            where TComparer : IEqualityComparer<T> 
            where TEnumerator2 : struct, ICollectionEnumerator<T>
            where TEnumerable2 : struct, IStructCollection<T, TEnumerator2>
        {
            return new (new(ref enumerable, ref enumerable2.enumerable, comparer, capacity, bucketPool, slotPool)); 
        }

    }
}