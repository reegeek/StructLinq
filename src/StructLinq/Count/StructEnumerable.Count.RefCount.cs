

// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{

    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static int RefIntCount<T, TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            int count = 0;
            while (enumerator.MoveNext())
            {
                count++;
            }
            return count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Count<T, TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var structEnumerator = enumerable.GetEnumerator();
            return RefIntCount<T, TEnumerator>(ref structEnumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Count<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : IRefStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefIntCount<T, TEnumerator>(ref enumerator);
        }

        private static long RefLongCount<T, TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            long count = 0;
            while (enumerator.MoveNext())
            {
                count++;
            }
            return count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long LongCount<T, TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var structEnumerator = enumerable.GetEnumerator();
            return RefLongCount<T, TEnumerator>(ref structEnumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long LongCount<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IRefStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefLongCount<T, TEnumerator>(ref enumerator);
        }

        private static uint RefUintCount<T, TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            uint count = 0;
            while (enumerator.MoveNext())
            {
                count++;
            }
            return count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint UIntCount<T, TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var structEnumerator = enumerable.GetEnumerator();
            return RefUintCount<T, TEnumerator>(ref structEnumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint UIntCount<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IRefStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefUintCount<T, TEnumerator>(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Count<T, TCollection, TEnumerator>(this TCollection collection, Func<TCollection, IRefStructCollection<T, TEnumerator>> _)
            where TCollection : IRefStructCollection<T, TEnumerator>
            where TEnumerator : struct, IRefCollectionEnumerator<T>
        {
            return collection.Count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Count<T, TEnumerator>(this IRefStructCollection<T, TEnumerator> collection)
            where TEnumerator : struct, IRefCollectionEnumerator<T>
        {
            return collection.Count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint UIntCount<T, TCollection, TEnumerator>(this TCollection collection, Func<TCollection, IRefStructCollection<T, TEnumerator>> _)
            where TCollection : IRefStructCollection<T, TEnumerator>
            where TEnumerator : struct, IRefCollectionEnumerator<T>
        {
            return (uint)collection.Count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint UintCount<T, TEnumerator>(this IRefStructCollection<T, TEnumerator> collection)
            where TEnumerator : struct, IRefCollectionEnumerator<T>
        {
            return (uint)collection.Count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long LongCount<T, TCollection, TEnumerator>(this TCollection collection, Func<TCollection, IRefStructCollection<T, TEnumerator>> _)
            where TCollection : IRefStructCollection<T, TEnumerator>
            where TEnumerator : struct, IRefCollectionEnumerator<T>
        {
            return collection.Count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long LongCount<T, TEnumerator>(this IRefStructCollection<T, TEnumerator> collection)
            where TEnumerator : struct, IRefCollectionEnumerator<T>
        {
            return collection.Count;
        }

    }
}
