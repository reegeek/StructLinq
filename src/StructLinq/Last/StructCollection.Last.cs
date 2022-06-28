// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Last<T, TCollection, TEnumerator>(this TCollection collection, Func<TCollection, IStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, ICollectionEnumerator<T>
            where TCollection : IStructCollection<T, TEnumerator>
        {
            if (collection.Count == 0)
                throw new("No Elements");
            return collection.Get(collection.Count - 1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Last<T, TEnumerator>(this IStructCollection<T, TEnumerator> collection)
            where TEnumerator : struct, ICollectionEnumerator<T>
        {
            if (collection.Count == 0)
                throw new("No Elements");
            return collection.Get(collection.Count - 1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Last<T, TCollection, TEnumerator>(this TCollection collection, Func<T, bool> predicate, Func<TCollection, IStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, ICollectionEnumerator<T>
            where TCollection : IStructCollection<T, TEnumerator>
        {
            if (collection.Count == 0)
                throw new("No Elements");
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                var first = collection.Get(i);
                if (predicate(first))
                    return first;
            }
            throw new("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Last<T, TEnumerator>(this IStructCollection<T, TEnumerator> collection, Func<T, bool> predicate)
            where TEnumerator : struct, ICollectionEnumerator<T>
        {
            if (collection.Count == 0)
                throw new("No Elements");
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                var first = collection.Get(i);
                if (predicate(first))
                    return first;
            }
            throw new("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Last<T, TCollection, TEnumerator, TFunc>(this TCollection collection, ref TFunc predicate, Func<TCollection, IStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, ICollectionEnumerator<T>
            where TCollection : IStructCollection<T, TEnumerator>
            where TFunc : struct, IFunction<T, bool>
        {
            if (collection.Count == 0)
                throw new("No Elements");
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                var first = collection.Get(i);
                if (predicate.Eval(first))
                    return first;
            }
            throw new("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryLast<T, TCollection, TEnumerator>(this TCollection collection, ref T last, Func<TCollection, IStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, ICollectionEnumerator<T>
            where TCollection : IStructCollection<T, TEnumerator>
        {
            if (collection.Count == 0)
                return false;
            last = collection.Get(collection.Count - 1);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryLast<T, TEnumerator>(this IStructCollection<T, TEnumerator> collection, ref T last)
            where TEnumerator : struct, ICollectionEnumerator<T>
        {
            if (collection.Count == 0)
                return false;
            last = collection.Get(collection.Count - 1);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryLast<T, TCollection, TEnumerator>(this TCollection collection, Func<T, bool> predicate, ref T last, Func<TCollection, IStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, ICollectionEnumerator<T>
            where TCollection : IStructCollection<T, TEnumerator>
        {
            if (collection.Count == 0)
                return false;
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                last = collection.Get(i);
                if (predicate(last))
                    return true;
            }
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryLast<T, TEnumerator>(this IStructCollection<T, TEnumerator> collection, Func<T, bool> predicate, ref T last)
            where TEnumerator : struct, ICollectionEnumerator<T>
        {
            if (collection.Count == 0)
                return false;
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                last = collection.Get(i);
                if (predicate(last))
                    return true;
            }
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryLast<T, TCollection, TEnumerator, TFunc>(this TCollection collection, ref TFunc predicate, ref T last, Func<TCollection, IStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, ICollectionEnumerator<T>
            where TCollection : IStructCollection<T, TEnumerator>
            where TFunc : struct, IFunction<T, bool>
        {
            if (collection.Count == 0)
                return false;
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                last = collection.Get(i);
                if (predicate.Eval(last))
                    return true;
            }
            return false;
        }

    }
}