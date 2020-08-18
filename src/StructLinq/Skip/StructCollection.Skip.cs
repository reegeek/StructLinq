using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TStructCollection Skip<T,TStructCollection, TEnumerator>(this TStructCollection collection, uint count, Func<TStructCollection, IStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TStructCollection : struct, IStructCollection<T, TEnumerator>
        {
            var newCollection = collection;
            newCollection.Slice(count, null);
            return newCollection;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IStructCollection<T, TEnumerator> Skip<T, TEnumerator>(this IStructCollection<T, TEnumerator> collection, uint count)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var newCollection = (IStructCollection<T, TEnumerator>)collection.Clone();
            newCollection.Slice(count, null);
            return newCollection;
        }
    }
}