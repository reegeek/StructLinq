// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstOrDefault<T, TCollection, TEnumerator>(this TCollection collection, Func<TCollection, IStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, ICollectionEnumerator<T>
            where TCollection : IStructCollection<T, TEnumerator>
        {
            T first = default;
            collection.TryFirst(ref first, x => x);
            return first;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstOrDefault<T, TEnumerator>(this IStructCollection<T, TEnumerator> collection)
            where TEnumerator : struct, ICollectionEnumerator<T>
        {
            T first = default;
            collection.TryFirst(ref first, x => x);
            return first;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstOrDefault<T, TCollection, TEnumerator>(this TCollection collection, Func<T, bool> predicate, Func<TCollection, IStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, ICollectionEnumerator<T>
            where TCollection : IStructEnumerable<T, TEnumerator>
        {
            T first = default;
            collection.TryFirst(predicate, ref first, x => x);
            return first;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstOrDefault<T, TEnumerator>(this IStructCollection<T, TEnumerator> collection, Func<T, bool> predicate)
            where TEnumerator : struct, ICollectionEnumerator<T>
        {
            T first = default;
            collection.TryFirst(predicate, ref first, x => x);
            return first;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstOrDefault<T, TCollection, TEnumerator, TFunc>(this TCollection collection, ref TFunc predicate, Func<TCollection, IStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, ICollectionEnumerator<T>
            where TCollection : IStructEnumerable<T, TEnumerator>
            where TFunc : struct, IFunction<T, bool>
        {
            T first = default;
            collection.TryFirst(ref predicate, ref first, x => x);
            return first;
        }
    }
}