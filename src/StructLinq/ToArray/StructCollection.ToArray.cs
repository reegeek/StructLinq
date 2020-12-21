using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static T[] ToArray<T, TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, ICollectionEnumerator<T>
        {
            var count = enumerator.Count;
            var result = new T[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = enumerator.Get(i);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static T[] ToRefArray<T, TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IRefCollectionEnumerator<T>
        {
            var count = enumerator.Count;
            var result = new T[count];
            for (int i = 0; i < count; i++)
            {
                ref var item = ref result[i];
                ref var elt = ref enumerator.Get(i);
                item = elt;
            }
            enumerator.Dispose();
            return result;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T[] ToArray<T, TEnumerator>(this IRefStructCollection<T, TEnumerator> collection)
            where TEnumerator : struct, IRefCollectionEnumerator<T>
        {
            var refStructEnumerator = collection.GetEnumerator();
            return ToRefArray<T, TEnumerator>(ref refStructEnumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T[] ToArray<T, TCollection, TEnumerator>(
            this TCollection collection,
            Func<TCollection, IRefStructCollection<T, TEnumerator>> _)
            where TCollection : IRefStructCollection<T, TEnumerator>
            where TEnumerator : struct, IRefCollectionEnumerator<T>
        {
            var enumerator = collection.GetEnumerator();
            return ToRefArray<T, TEnumerator>(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T[] ToArray<T, TCollection, TEnumerator>(
            this TCollection collection,
            Func<TCollection, IStructCollection<T, TEnumerator>> _)
            where TCollection : IStructCollection<T, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<T>
        {
            var enumerator = collection.GetEnumerator();
            return ToArray<T, TEnumerator>(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T[] ToArray<T, TEnumerator>(this IStructCollection<T, TEnumerator> collection)
            where TEnumerator : struct, ICollectionEnumerator<T>
        {
            var enumerator = collection.GetEnumerator();
            return ToArray<T, TEnumerator>(ref enumerator);
        }


    }
}
