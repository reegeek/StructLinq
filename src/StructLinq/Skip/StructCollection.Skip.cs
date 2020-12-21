﻿using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TStructCollection Skip<T,TStructCollection, TEnumerator>(this TStructCollection collection, int count, Func<TStructCollection, IStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, ICollectionEnumerator<T>
            where TStructCollection : struct, IStructCollection<T, TEnumerator>
        {
            var newCollection = collection;
            newCollection.Slice((uint)count, null);
            return newCollection;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IStructCollection<T, TEnumerator> Skip<T, TEnumerator>(this IStructCollection<T, TEnumerator> collection, int count)
            where TEnumerator : struct, ICollectionEnumerator<T>
        {
            var newCollection = (IStructCollection<T, TEnumerator>)collection.Clone();
            newCollection.Slice((uint)count, null);
            return newCollection;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TStructCollection Skip<T,TStructCollection, TEnumerator>(this TStructCollection collection, int count, Func<TStructCollection, IRefStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, IRefCollectionEnumerator<T>
            where TStructCollection : struct, IRefStructCollection<T, TEnumerator>
        {
            var newCollection = collection;
            newCollection.Slice((uint)count, null);
            return newCollection;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IRefStructCollection<T, TEnumerator> Skip<T, TEnumerator>(this IRefStructCollection<T, TEnumerator> collection, int count)
            where TEnumerator : struct, IRefCollectionEnumerator<T>
        {
            var newCollection = (IRefStructCollection<T, TEnumerator>)collection.Clone();
            newCollection.Slice((uint)count, null);
            return newCollection;
        }
    }
}