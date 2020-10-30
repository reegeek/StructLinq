// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ElementAt<T, TCollection, TEnumerator>(this TCollection collection, int index, Func<TCollection, IRefStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TCollection : IRefStructCollection<T, TEnumerator>
        {
            if (index >= collection.Count || index < 0)
                throw new ArgumentOutOfRangeException("index");
            return collection.Get(index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ElementAt<T, TEnumerator>(this IRefStructCollection<T, TEnumerator> collection, int index)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            if (index >= collection.Count || index < 0)
                throw new ArgumentOutOfRangeException("index");
            return collection.Get(index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryElementAt<T, TCollection, TEnumerator>(this TCollection collection, ref T elementAt, int index, Func<TCollection, IRefStructCollection<T, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TCollection : IRefStructCollection<T, TEnumerator>
        {
            if (index >= collection.Count || index < 0)
                return false;
            elementAt = ref collection.Get(index);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryElementAt<T, TEnumerator>(this IRefStructCollection<T, TEnumerator> collection, ref T elementAt, int index)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            if (index >= collection.Count || index < 0)
                return false;
            elementAt = ref collection.Get(index);
            return true;
        }

    }
}