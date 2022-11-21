﻿// ReSharper disable once CheckNamespace

using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using StructLinq.Utils.Collections;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct StructEnum<T, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T[] ToArray(int capacity, ArrayPool<T> pool)
        {
            using var list = new PooledList<T>(capacity, pool);
            foreach(var t in this)
                list.Add(t);
            return list.ToArray();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T[] ToArray(int capacity = 0) => ToArray(capacity, ArrayPool<T>.Shared);
    }

    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static T[] ToRefArray<T, TEnumerator>(ref TEnumerator enumerator,
                                                      int capacity,
                                                      ArrayPool<T> pool)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var list = new PooledList<T>(capacity, pool);
            PoolLists.FillRef(ref list, ref enumerator);
            var array = list.ToArray();
            list.Dispose();
            return array;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T[] ToArray<T, TEnumerable, TEnumerator>(
            this TEnumerable enumerable,
            int capacity, 
            ArrayPool<T> pool,
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var visitor = new PooledListVisitor<T>(capacity, pool);
            enumerable.Visit(ref visitor);
            var array = visitor.PooledList.ToArray();
            visitor.Dispose();
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
            var visitor = new PooledListVisitor<T>(capacity, ArrayPool<T>.Shared);
            enumerable.Visit(ref visitor);
            var array = visitor.PooledList.ToArray();
            visitor.Dispose();
            return array;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T[] ToArray<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, int capacity, ArrayPool<T> pool)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var visitor = new PooledListVisitor<T>(capacity, pool);
            enumerable.Visit(ref visitor);
            var array = visitor.PooledList.ToArray();
            visitor.Dispose();
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
            var enumerator = enumerable.GetEnumerator();
            return ToRefArray(ref enumerator, capacity, pool);
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
            var enumerator = enumerable.GetEnumerator();
            return ToRefArray(ref enumerator, capacity, ArrayPool<T>.Shared);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T[] ToArray<T, TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, int capacity, ArrayPool<T> pool)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return ToRefArray(ref enumerator, capacity, pool);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T[] ToArray<T, TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, int capacity = 0)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            return ToArray(enumerable, capacity, ArrayPool<T>.Shared);
        }

    }
}
