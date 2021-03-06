﻿

// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;
using StructLinq.Count;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Count<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable) 
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var visitor = new IntCountVisitor<T>(0);
            enumerable.Visit(ref visitor);
            return visitor.Count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Count<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var visitor = new IntCountVisitor<T>(0);
            enumerable.Visit(ref visitor);
            return visitor.Count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long LongCount<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var visitor = new LongCountVisitor<T>(0);
            enumerable.Visit(ref visitor);
            return visitor.Count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long LongCount<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var visitor = new LongCountVisitor<T>(0);
            enumerable.Visit(ref visitor);
            return visitor.Count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint UIntCount<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var visitor = new UIntCountVisitor<T>(0);
            enumerable.Visit(ref visitor);
            return visitor.Count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint UIntCount<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var visitor = new UIntCountVisitor<T>(0);
            enumerable.Visit(ref visitor);
            return visitor.Count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Count<T, TCollection, TEnumerator>(this TCollection collection, Func<TCollection, IStructCollection<T, TEnumerator>> _)
            where TCollection : IStructCollection<T, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<T>
        {
            return collection.Count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Count<T, TEnumerator>(this IStructCollection<T, TEnumerator> collection)
            where TEnumerator : struct, ICollectionEnumerator<T>
        {
            return collection.Count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint UIntCount<T, TCollection, TEnumerator>(this TCollection collection, Func<TCollection, IStructCollection<T, TEnumerator>> _)
            where TCollection : IStructCollection<T, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<T>
        {
            return (uint)collection.Count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint UIntCount<T, TEnumerator>(this IStructCollection<T, TEnumerator> collection)
            where TEnumerator : struct, ICollectionEnumerator<T>
        {
            return (uint)collection.Count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long LongCount<T, TCollection, TEnumerator>(this TCollection collection, Func<TCollection, IStructCollection<T, TEnumerator>> _)
            where TCollection : IStructCollection<T, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<T>
        {
            return collection.Count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long LongCount<T, TEnumerator>(this IStructCollection<T, TEnumerator> collection)
            where TEnumerator : struct, ICollectionEnumerator<T>
        {
            return collection.Count;
        }
    }
}
