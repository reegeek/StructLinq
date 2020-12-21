

// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;
using StructLinq.Reverse;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReverseStructCollection<T, TCollection, TEnumerator> Reverse<T, TCollection, TEnumerator>(
            this TCollection collection, 
            Func<TCollection, IStructCollection<T, TEnumerator>> _)
            where TCollection : IStructCollection<T, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<T>
        {
            return new ReverseStructCollection<T, TCollection, TEnumerator>(collection, 0, collection.Count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReverseStructCollection<T, IStructCollection<T, TEnumerator>, TEnumerator> Reverse<T, TEnumerator>(
            this IStructCollection<T, TEnumerator> collection)
            where TEnumerator : struct, ICollectionEnumerator<T>
        {
            return new ReverseStructCollection<T, IStructCollection<T, TEnumerator>, TEnumerator>(collection, 0, collection.Count);
        }

    }
}
