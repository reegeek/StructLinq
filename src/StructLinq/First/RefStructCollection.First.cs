// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T First<T, TCollection, TEnumerator>(this TCollection collection, Func<TCollection, IRefStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, IRefCollectionEnumerator<T>
            where TCollection : IRefStructCollection<T, TEnumerator>
        {
            T first = default;
            if (TryFirst(collection, ref first, x => x))
                return first;
            throw new("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T First<T, TEnumerator>(this IRefStructCollection<T, TEnumerator> collection)
            where TEnumerator : struct, IRefCollectionEnumerator<T>
        {
            T first = default;
            if (TryFirst(collection, ref first))
                return first;
            throw new("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T First<T, TCollection, TEnumerator>(this TCollection collection, Func<T, bool> predicate, Func<TCollection, IRefStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, IRefCollectionEnumerator<T>
            where TCollection : IRefStructCollection<T, TEnumerator>
        {
            T first = default;
            if (TryFirst(collection, predicate, ref first, x => x))
                return first;
            throw new("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T First<T, TEnumerator>(this IRefStructCollection<T, TEnumerator> collection, Func<T, bool> predicate)
            where TEnumerator : struct, IRefCollectionEnumerator<T>
        {
            T first = default;
            if (TryFirst(collection, predicate, ref first))
                return first;
            throw new("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T First<T, TCollection, TEnumerator, TFunc>(this TCollection collection, ref TFunc predicate, Func<TCollection, IRefStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, IRefCollectionEnumerator<T>
            where TCollection : IRefStructCollection<T, TEnumerator>
            where TFunc : struct, IInFunction<T, bool>
        {
            T first = default;
            if (TryFirst(collection, ref predicate, ref first, x => x))
                return first;
            throw new("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryFirst<T, TCollection, TEnumerator>(this TCollection collection, ref T first, Func<TCollection, IRefStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, IRefCollectionEnumerator<T>
            where TCollection : IRefStructCollection<T, TEnumerator>
        {
            if (collection.Count == 0)
                return false;
            ref var result = ref collection.Get(0);
            first = result;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryFirst<T, TEnumerator>(this IRefStructCollection<T, TEnumerator> collection, ref T first)
            where TEnumerator : struct, IRefCollectionEnumerator<T>
        {
            if (collection.Count == 0)
                return false;
            ref var result = ref collection.Get(0);
            first = result;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryFirst<T, TCollection, TEnumerator>(this TCollection collection, Func<T, bool> predicate, ref T first, Func<TCollection, IRefStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, IRefCollectionEnumerator<T>
            where TCollection : IRefStructCollection<T, TEnumerator>
        {
            if (collection.Count == 0)
                return false;
            for (int i = 0; i < collection.Count; i++)
            {
                ref var result = ref collection.Get(i);
                if (predicate(result))
                {
                    first = result;
                    return true;
                }
            }
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryFirst<T, TEnumerator>(this IRefStructCollection<T, TEnumerator> collection, Func<T, bool> predicate, ref T first)
            where TEnumerator : struct, IRefCollectionEnumerator<T>
        {
            if (collection.Count == 0)
                return false;
            for (int i = 0; i < collection.Count; i++)
            {
                ref var result = ref collection.Get(i);
                if (predicate(result))
                {
                    first = result;
                    return true;
                }
            }
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryFirst<T, TCollection, TEnumerator, TFunc>(this TCollection collection, ref TFunc predicate, ref T first, Func<TCollection, IRefStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, IRefCollectionEnumerator<T>
            where TCollection : IRefStructCollection<T, TEnumerator>
            where TFunc : struct, IInFunction<T, bool>
        {
            if (collection.Count == 0)
                return false;

            for (int i = 0; i < collection.Count; i++)
            {
                ref var result = ref collection.Get(i);
                if (predicate.Eval(in result))
                {
                    first = result;
                    return true;
                }
            }
            return false;
        }

    }
}