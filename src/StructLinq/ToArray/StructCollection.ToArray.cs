using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static T[] ToArray<T, TEnumerator>(ref TEnumerator enumerator, int size)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var result = new T[size];
            var i = 0;
            while (enumerator.MoveNext())
            {
                result[i++] = enumerator.Current;
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static T[] ToRefArray<T, TEnumerator>(ref TEnumerator enumerator, int size)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var result = new T[size];
            var i = 0;
            while (enumerator.MoveNext())
            {
                ref var item = ref result[i++];
                ref var elt = ref enumerator.Current;
                item = elt;
            }
            enumerator.Dispose();
            return result;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T[] ToArray<T, TEnumerator>(this IRefStructCollection<T, TEnumerator> collection)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var refStructEnumerator = collection.GetEnumerator();
            return ToRefArray<T, TEnumerator>(ref refStructEnumerator, collection.Count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T[] ToArray<T, TCollection, TEnumerator>(
            this TCollection collection,
            Func<TCollection, IRefStructCollection<T, TEnumerator>> _)
            where TCollection : IRefStructCollection<T, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = collection.GetEnumerator();
            return ToRefArray<T, TEnumerator>(ref enumerator, collection.Count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T[] ToArray<T, TCollection, TEnumerator>(
            this TCollection collection,
            Func<TCollection, IStructCollection<T, TEnumerator>> _)
            where TCollection : IStructCollection<T, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<T>
        {
            var enumerator = collection.GetEnumerator();
            return ToArray<T, TEnumerator>(ref enumerator, collection.Count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T[] ToArray<T, TEnumerator>(this IStructCollection<T, TEnumerator> collection)
            where TEnumerator : struct, ICollectionEnumerator<T>
        {
            var enumerator = collection.GetEnumerator();
            return ToArray<T, TEnumerator>(ref enumerator, collection.Count);
        }


    }
}
