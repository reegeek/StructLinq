﻿#if !NETSTANDARD1_1
// ReSharper disable once CheckNamespace

using System;
using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.List;
using StructLinq.Utils;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    // ReSharper disable once InconsistentNaming
    // ReSharper disable once UnusedType.Global
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static List<T> ToList<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, int capacity, ArrayPool<T> pool)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var array = enumerable.ToArray(capacity, pool, x => x);
            var result = new List<T>();
            var listLayout = UnsafeHelpers.As<List<T>, ListLayout<T>>(ref result);
            listLayout.Items = array;
            listLayout.Size = array.Length;
            result.Capacity = array.Length;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static List<T> ToList<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, int capacity = 0)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            return enumerable.ToList(capacity, ArrayPool<T>.Shared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static List<T> ToList<T, TEnumerator>(this IStructCollection<T, TEnumerator> collection)
            where TEnumerator : struct, ICollectionEnumerator<T>
        {
            var array = collection.ToArray(x => x);
            var result = new List<T>();
            var listLayout = UnsafeHelpers.As<List<T>, ListLayout<T>>(ref result);
            listLayout.Items = array;
            listLayout.Size = array.Length;
            result.Capacity = array.Length;
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static List<T> ToList<T, TEnumerable, TEnumerator>(
            this TEnumerable enumerable, 
            int capacity, 
            ArrayPool<T> pool,
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var array = enumerable.ToArray(capacity, pool, x=>x);
            var result = new List<T>();
            var listLayout = UnsafeHelpers.As<List<T>, ListLayout<T>>(ref result);
            listLayout.Items = array;
            listLayout.Size = array.Length;
            result.Capacity = array.Length;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static List<T> ToList<T, TEnumerable, TEnumerator>(
            this TEnumerable enumerable, 
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _,
            int capacity = 0)
            where TEnumerable : IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            return enumerable.ToList<T, TEnumerable, TEnumerator>(capacity, ArrayPool<T>.Shared, _);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static List<T> ToList<T, TCollection, TEnumerator>(
            this TCollection collection, 
            Func<TCollection, IStructCollection<T, TEnumerator>> _)
            where TCollection : IStructCollection<T, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<T>
        {
            var array = collection.ToArray(x => x);
            var result = new List<T>();
            var listLayout = UnsafeHelpers.As<List<T>, ListLayout<T>>(ref result);
            listLayout.Items = array;
            listLayout.Size = array.Length;
            result.Capacity = array.Length;
            return result;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static List<T> ToList<T, TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, int capacity, ArrayPool<T> pool)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var array = enumerable.ToArray(capacity, pool, x => x);
            var result = new List<T>();
            var listLayout = UnsafeHelpers.As<List<T>, ListLayout<T>>(ref result);
            listLayout.Items = array;
            listLayout.Size = array.Length;
            result.Capacity = array.Length;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static List<T> ToList<T, TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, int capacity = 0)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            return enumerable.ToList(capacity, ArrayPool<T>.Shared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static List<T> ToList<T, TEnumerator>(this IRefStructCollection<T, TEnumerator> enumerable)
            where TEnumerator : struct, IRefCollectionEnumerator<T>
        {
            var array = enumerable.ToArray(x => x);
            var result = new List<T>();
            var listLayout = UnsafeHelpers.As<List<T>, ListLayout<T>>(ref result);
            listLayout.Items = array;
            listLayout.Size = array.Length;
            result.Capacity = array.Length;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static List<T> ToList<T, TEnumerable, TEnumerator>(
            this TEnumerable enumerable, 
            int capacity, 
            ArrayPool<T> pool,
            Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : IRefStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var array = enumerable.ToArray(capacity, pool, x => x);
            var result = new List<T>();
            var listLayout = UnsafeHelpers.As<List<T>, ListLayout<T>>(ref result);
            listLayout.Items = array;
            listLayout.Size = array.Length;
            result.Capacity = array.Length;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static List<T> ToList<T, TEnumerable, TEnumerator>(
            this TEnumerable enumerable, 
            Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _,
            int capacity = 0)
            where TEnumerable : IRefStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            return enumerable.ToList<T, TEnumerable, TEnumerator>(capacity, ArrayPool<T>.Shared, _);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static List<T> ToList<T, TEnumerable, TEnumerator>(
            this TEnumerable enumerable, 
            Func<TEnumerable, IRefStructCollection<T, TEnumerator>> _)
            where TEnumerable : IRefStructCollection<T, TEnumerator>
            where TEnumerator : struct, IRefCollectionEnumerator<T>
        {
            var array = enumerable.ToArray(x => x);
            var result = new List<T>();
            var listLayout = UnsafeHelpers.As<List<T>, ListLayout<T>>(ref result);
            listLayout.Items = array;
            listLayout.Size = array.Length;
            result.Capacity = array.Length;
            return result;
        }
    }
}
#endif