

// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool InnerCollectionAll<T, TEnumerator>(ref TEnumerator enumerator, Func<T, bool> predicate)
            where TEnumerator : struct, ICollectionEnumerator<T>
        {
            var count = enumerator.Count;
            for (int i = 0; i < count; i++)
            {
                var current = enumerator.Get(i);
                if (!predicate(current))
                {
                    enumerator.Dispose();
                    return false;
                }
            }
            enumerator.Dispose();
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool InnerCollectionAll<T, TEnumerator, TFunction>(ref TEnumerator enumerator, ref TFunction predicate)
            where TEnumerator : struct, ICollectionEnumerator<T>
            where TFunction : IFunction<T, bool>
        {
            var count = enumerator.Count;
            for (int i = 0; i < count; i++)
            {
                var current = enumerator.Get(i);
                if (!predicate.Eval(current))
                {
                    enumerator.Dispose();
                    return false;
                }
            }
            enumerator.Dispose();
            return true;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool All<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<T, bool> predicate, Func<TEnumerable, IStructCollection<T, TEnumerator>> _)
            where TEnumerable : IStructCollection<T, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return InnerCollectionAll(ref enumerator, predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool All<T, TEnumerator>(this IStructCollection<T, TEnumerator> enumerable, Func<T, bool> predicate)
            where TEnumerator : struct, ICollectionEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return InnerCollectionAll(ref enumerator, predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool All<T, TEnumerable, TEnumerator, TFunction>(this TEnumerable enumerable, ref TFunction predicate, Func<TEnumerable, IStructCollection<T, TEnumerator>> _)
            where TEnumerable : IStructCollection<T, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<T>
            where TFunction : IFunction<T, bool>
        {
            var enumerator = enumerable.GetEnumerator();
            return InnerCollectionAll<T, TEnumerator, TFunction>(ref enumerator, ref predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool All<T, TEnumerator>(this IStructCollection<T, TEnumerator> enumerable, IFunction<T, bool> predicate)
            where TEnumerator : struct, ICollectionEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return InnerCollectionAll<T, TEnumerator, IFunction<T, bool>>(ref enumerator, ref predicate);
        }
    }
}
