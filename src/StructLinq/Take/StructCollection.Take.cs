// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TStructCollection Take<T,TStructCollection, TEnumerator>(this TStructCollection collection, int count, Func<TStructCollection, IStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TStructCollection : struct, IStructCollection<T, TEnumerator>
        {
            var newCollection = collection;
            newCollection.Slice(0, (uint)count);
            return newCollection;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IStructCollection<T, TEnumerator> Take<T, TEnumerator>(this IStructCollection<T, TEnumerator> collection, int count)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var newCollection = (IStructCollection<T, TEnumerator>)collection.Clone();
            newCollection.Slice(0, (uint)count);
            return newCollection;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TRefStructCollection Take<T,TRefStructCollection, TEnumerator>(this TRefStructCollection collection, int count, Func<TRefStructCollection, IRefStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TRefStructCollection : struct, IRefStructCollection<T, TEnumerator>
        {
            var newCollection = collection;
            newCollection.Slice(0, (uint)count);
            return newCollection;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IRefStructCollection<T, TEnumerator> Take<T, TEnumerator>(this IRefStructCollection<T, TEnumerator> collection, int count)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var newCollection = (IRefStructCollection<T, TEnumerator>)collection.Clone();
            newCollection.Slice(0, (uint)count);
            return newCollection;
        }
    }
    
}