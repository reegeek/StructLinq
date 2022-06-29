// ReSharper disable once CheckNamespace

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
                int capacity = 0,
                ArrayPool<int>? bucketPool = null, 
                ArrayPool<Slot<T>>? slotPool = null) 
            where TComparer : IEqualityComparer<T> 
            where TEnumerator2 : struct, ICollectionEnumerator<T>
            where TEnumerable2 : struct, IStructCollection<T, TEnumerator2>
        {
            bucketPool ??= ArrayPool<int>.Shared;
            slotPool ??= ArrayPool<Slot<T>>.Shared;
            return new (new(ref enumerable, ref enumerable2.enumerable, comparer, capacity, bucketPool, slotPool)); 
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnumerable<T, ExceptEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, EqualityComparer<T>>, ExceptEnumerator<T, TEnumerator, TEnumerator2, EqualityComparer<T>>>
            Except<TEnumerable2, TEnumerator2>(
                StructEnumerable<T, TEnumerable2, TEnumerator2>  enumerable2, 
                int capacity = 0,
                ArrayPool<int>? bucketPool = null, 
                ArrayPool<Slot<T>>? slotPool = null) 
            where TEnumerator2 : struct, IStructEnumerator<T>
            where TEnumerable2 : struct, IStructEnumerable<T, TEnumerator2>
        {
            var comparer = EqualityComparer<T>.Default;
            bucketPool ??= ArrayPool<int>.Shared;
            slotPool ??= ArrayPool<Slot<T>>.Shared;
            return new (new(ref enumerable, ref enumerable2.enumerable, comparer, capacity, bucketPool, slotPool)); 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnumerable<T, ExceptEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2, EqualityComparer<T>>, ExceptEnumerator<T, TEnumerator, TEnumerator2, EqualityComparer<T>>>
            Except<TEnumerable2, TEnumerator2>(
                StructCollection<T, TEnumerable2, TEnumerator2>  enumerable2, 
                int capacity = 0,
                ArrayPool<int>? bucketPool = null, 
                ArrayPool<Slot<T>>? slotPool = null) 
            where TEnumerator2 : struct, ICollectionEnumerator<T>
            where TEnumerable2 : struct, IStructCollection<T, TEnumerator2>
        {
            var comparer = EqualityComparer<T>.Default;
            bucketPool ??= ArrayPool<int>.Shared;
            slotPool ??= ArrayPool<Slot<T>>.Shared;
            return new (new(ref enumerable, ref enumerable2.enumerable, comparer, capacity, bucketPool, slotPool)); 
        }

    }
}