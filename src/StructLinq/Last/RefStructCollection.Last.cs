﻿// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Last<T, TCollection, TEnumerator>(this TCollection collection, Func<TCollection, IRefStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, IRefCollectionEnumerator<T>
            where TCollection : IRefStructCollection<T, TEnumerator>
        {
            T last = default;
            if (TryLast(collection, ref last, x=>x))
                return last;
            throw new Exception("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Last<T, TEnumerator>(this IRefStructCollection<T, TEnumerator> collection)
            where TEnumerator : struct, IRefCollectionEnumerator<T>
        {
            T last = default;
            if (TryLast(collection, ref last))
                return last;
            throw new Exception("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Last<T, TCollection, TEnumerator>(this TCollection collection, Func<T, bool> predicate, Func<TCollection, IRefStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, IRefCollectionEnumerator<T>
            where TCollection : IRefStructCollection<T, TEnumerator>
        {
            T last = default;
            if (TryLast(collection, predicate, ref last, x=>x))
                return last;
            throw new Exception("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Last<T, TEnumerator>(this IRefStructCollection<T, TEnumerator> collection, Func<T, bool> predicate)
            where TEnumerator : struct, IRefCollectionEnumerator<T>
        {
            T last = default;
            if (TryLast(collection, predicate, ref last))
                return last;
            throw new Exception("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Last<T, TCollection, TEnumerator, TFunc>(this TCollection collection, ref TFunc predicate, Func<TCollection, IRefStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, IRefCollectionEnumerator<T>
            where TCollection : IRefStructCollection<T, TEnumerator>
            where TFunc : struct, IInFunction<T, bool>
        {
            T last = default;
            if (TryLast(collection, ref predicate, ref last, x=>x))
                return last;
            throw new Exception("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryLast<T, TCollection, TEnumerator>(this TCollection collection, ref T last, Func<TCollection, IRefStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, IRefCollectionEnumerator<T>
            where TCollection : IRefStructCollection<T, TEnumerator>
        {
            if (collection.Count == 0)
                return false;
            ref var result = ref collection.Get(collection.Count - 1);
            last = result;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryLast<T, TEnumerator>(this IRefStructCollection<T, TEnumerator> collection, ref T last)
            where TEnumerator : struct, IRefCollectionEnumerator<T>
        {
            if (collection.Count == 0)
                return false;
            ref var result = ref collection.Get(collection.Count - 1);
            last = result;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryLast<T, TCollection, TEnumerator>(this TCollection collection, Func<T, bool> predicate, ref T last, Func<TCollection, IRefStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, IRefCollectionEnumerator<T>
            where TCollection : IRefStructCollection<T, TEnumerator>
        {
            if (collection.Count == 0)
                return false;
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                ref var result = ref collection.Get(i);
                if (predicate(result))
                {
                    last = result;
                    return true;
                }
            }
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryLast<T, TEnumerator>(this IRefStructCollection<T, TEnumerator> collection, Func<T, bool> predicate, ref T last)
            where TEnumerator : struct, IRefCollectionEnumerator<T>
        {
            if (collection.Count == 0)
                return false;
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                ref var result = ref collection.Get(i);
                if (predicate(result))
                {
                    last = result;
                    return true;
                }
            }
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryLast<T, TCollection, TEnumerator, TFunc>(this TCollection collection, ref TFunc predicate, ref T last, Func<TCollection, IRefStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, IRefCollectionEnumerator<T>
            where TCollection : IRefStructCollection<T, TEnumerator>
            where TFunc : struct, IInFunction<T, bool>
        {
            if (collection.Count == 0)
                return false;
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                ref var result = ref collection.Get(i);
                if (predicate.Eval(in result))
                {
                    last = result;
                    return true;
                }
            }
            return false;
        }

    }
}