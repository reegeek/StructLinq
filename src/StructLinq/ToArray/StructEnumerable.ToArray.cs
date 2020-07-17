﻿// ReSharper disable once CheckNamespace

using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using StructLinq.Utils.Collections;

namespace StructLinq
{
    public static partial class StructEnumerable
    {

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T[] ToArray<T, TEnumerable, TEnumerator>(
            this TEnumerable enumerable,
            int capacity, 
            ArrayPool<T> pool,
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var list = new PooledList<T>(capacity, pool);
            var enumerator = enumerable.GetEnumerator();
            PoolLists.Fill(ref list, ref enumerator);
            var array = list.ToArray();
            list.Dispose();
            return array;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T[] ToArray<T, TEnumerable, TEnumerator>(
            this TEnumerable enumerable,
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _,
            int capacity = 0
            )
            where TEnumerable : IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            return enumerable.ToArray(capacity, ArrayPool<T>.Shared, _);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T[] ToArray<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, int capacity, ArrayPool<T> pool)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var list = new PooledList<T>(capacity, pool);
            var enumerator = enumerable.GetEnumerator();
            PoolLists.Fill(ref list, ref enumerator);
            var array = list.ToArray();
            list.Dispose();
            return array;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T[] ToArray<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, int capacity = 0)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            return ToArray(enumerable, capacity, ArrayPool<T>.Shared);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T[] ToArray<T, TEnumerable, TEnumerator>(
            this TEnumerable enumerable, 
            int capacity, 
            ArrayPool<T> pool, 
            Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerable: IRefStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var list = new PooledList<T>(capacity, pool);
            var enumerator = enumerable.GetEnumerator();
            PoolLists.FillRef(ref list, ref enumerator);
            var array = list.ToArray();
            list.Dispose();
            return array;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T[] ToArray<T, TEnumerable, TEnumerator>(
            this TEnumerable enumerable,
            Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _,
            int capacity = 0
        )
            where TEnumerable : IRefStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            return enumerable.ToArray(capacity, ArrayPool<T>.Shared, _);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T[] ToArray<T, TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, int capacity, ArrayPool<T> pool)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var list = new PooledList<T>(capacity, pool);
            var enumerator = enumerable.GetEnumerator();
            PoolLists.FillRef(ref list, ref enumerator);
            var array = list.ToArray();
            list.Dispose();
            return array;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T[] ToArray<T, TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, int capacity = 0)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            return ToArray(enumerable, capacity, ArrayPool<T>.Shared);
        }

    }
}
