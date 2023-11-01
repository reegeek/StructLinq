// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T First<T, TCollection, TEnumerator>(this TCollection collection, Func<TCollection, IStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, ICollectionEnumerator<T>
            where TCollection : IStructCollection<T, TEnumerator>
        {
            if (collection.Count == 0)
                throw new Exception("No Elements");
            return collection.Get(0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T First<T, TEnumerator>(this IStructCollection<T, TEnumerator> collection)
            where TEnumerator : struct, ICollectionEnumerator<T>
        {
            if (collection.Count == 0)
                throw new Exception("No Elements");
            return collection.Get(0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T First<T, TCollection, TEnumerator>(this TCollection collection, Func<T, bool> predicate, Func<TCollection, IStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, ICollectionEnumerator<T>
            where TCollection : IStructCollection<T, TEnumerator>
        {
            if (collection.Count == 0)
                throw new Exception("No Elements");
            for (int i = 0; i < collection.Count; i++)
            {
                var first = collection.Get(i);
                if (predicate(first))
                    return first;
            }
            throw new Exception("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T First<T, TEnumerator>(this IStructCollection<T, TEnumerator> collection, Func<T, bool> predicate)
            where TEnumerator : struct, ICollectionEnumerator<T>
        {
            if (collection.Count == 0)
                throw new Exception("No Elements");
            for (int i = 0; i < collection.Count; i++)
            {
                var first = collection.Get(i);
                if (predicate(first))
                    return first;
            }
            throw new Exception("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T First<T, TCollection, TEnumerator, TFunc>(this TCollection collection, ref TFunc predicate, Func<TCollection, IStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, ICollectionEnumerator<T>
            where TCollection : IStructCollection<T, TEnumerator>
            where TFunc : struct, IFunction<T, bool>
        {
            if (collection.Count == 0)
                throw new Exception("No Elements");
            for (int i = 0; i < collection.Count; i++)
            {
                var first = collection.Get(i);
                if (predicate.Eval(first))
                    return first;
            }
            throw new Exception("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryFirst<T, TCollection, TEnumerator>(this TCollection collection, ref T first, Func<TCollection, IStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, ICollectionEnumerator<T>
            where TCollection : IStructCollection<T, TEnumerator>
        {
            if (collection.Count == 0)
                return false;
            first = collection.Get(0);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryFirst<T, TEnumerator>(this IStructCollection<T, TEnumerator> collection, ref T first)
            where TEnumerator : struct, ICollectionEnumerator<T>
        {
            if (collection.Count == 0)
                return false;
            first = collection.Get(0);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryFirst<T, TCollection, TEnumerator>(this TCollection collection, Func<T, bool> predicate, ref T first, Func<TCollection, IStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, ICollectionEnumerator<T>
            where TCollection : IStructCollection<T, TEnumerator>
        {
            if (collection.Count == 0)
                return false;
            for (int i = 0; i < collection.Count; i++)
            {
                var current = collection.Get(i);
                if (predicate(current))
                {
                    first = current;
                    return true;
                }
            }
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryFirst<T, TEnumerator>(this IStructCollection<T, TEnumerator> collection, Func<T, bool> predicate, ref T first)
            where TEnumerator : struct, ICollectionEnumerator<T>
        {
            if (collection.Count == 0)
                return false;
            for (int i = 0; i < collection.Count; i++)
            {
                var current = collection.Get(i);
                if (predicate(current))
                {
                    first = current;
                    return true;
                }
            }
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryFirst<T, TCollection, TEnumerator, TFunc>(this TCollection collection, ref TFunc predicate, ref T first, Func<TCollection, IStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, ICollectionEnumerator<T>
            where TCollection : IStructCollection<T, TEnumerator>
            where TFunc : struct, IFunction<T, bool>
        {
            if (collection.Count == 0)
                return false;
            for (int i = 0; i < collection.Count; i++)
            {
                var current = collection.Get(i);
                if (predicate.Eval(first))
                {
                    first = current;
                    return true;
                }
            }
            return false;
        }

    }
}