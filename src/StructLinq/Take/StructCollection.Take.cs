// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct StructCollec<T, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructCollec<T, TEnumerator> Take(int count) => Slice(0, (uint)count);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public StructCollec<T, TEnumerator> Take(int count, Func<TEnumerator, ICollectionEnumerator<T>> _) => Take(count);
    }

    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TStructCollection Take<T,TStructCollection, TEnumerator>(this TStructCollection collection, int count, Func<TStructCollection, IStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, ICollectionEnumerator<T>
            where TStructCollection : struct, IStructCollection<T, TEnumerator>
        {
            var newCollection = collection;
            newCollection.Slice(0, (uint)count);
            return newCollection;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IStructCollection<T, TEnumerator> Take<T, TEnumerator>(this IStructCollection<T, TEnumerator> collection, int count)
            where TEnumerator : struct, ICollectionEnumerator<T>
        {
            var newCollection = (IStructCollection<T, TEnumerator>)collection.Clone();
            newCollection.Slice(0, (uint)count);
            return newCollection;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TRefStructCollection Take<T,TRefStructCollection, TEnumerator>(this TRefStructCollection collection, int count, Func<TRefStructCollection, IRefStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, IRefCollectionEnumerator<T>
            where TRefStructCollection : struct, IRefStructCollection<T, TEnumerator>
        {
            var newCollection = collection;
            newCollection.Slice(0, (uint)count);
            return newCollection;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IRefStructCollection<T, TEnumerator> Take<T, TEnumerator>(this IRefStructCollection<T, TEnumerator> collection, int count)
            where TEnumerator : struct, IRefCollectionEnumerator<T>
        {
            var newCollection = (IRefStructCollection<T, TEnumerator>)collection.Clone();
            newCollection.Slice(0, (uint)count);
            return newCollection;
        }
    }
    
}