

// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool InnerRefCollectionAll<T, TEnumerator>(ref TEnumerator enumerator, Func<T, bool> predicate)
            where TEnumerator : struct, IRefCollectionEnumerator<T>
        {
            var count = enumerator.Count;
            for (int i = 0; i < count; i++)
            {
                ref var current = ref enumerator.Get(i);
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
        private static bool InnerRefCollectionAll<T, TEnumerator, TFunction>(ref TEnumerator enumerator, ref TFunction predicate)
            where TEnumerator : struct, IRefCollectionEnumerator<T>
            where TFunction : IInFunction<T, bool>
        {
            var count = enumerator.Count;
            for (int i = 0; i < count; i++)
            {
                ref var current = ref enumerator.Get(i);
                if (!predicate.Eval(in current))
                {
                    enumerator.Dispose();
                    return false;
                }
            }
            enumerator.Dispose();
            return true;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool All<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<T, bool> predicate, Func<TEnumerable, IRefStructCollection<T, TEnumerator>> _)
            where TEnumerable : IRefStructCollection<T, TEnumerator>
            where TEnumerator : struct, IRefCollectionEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return InnerRefCollectionAll(ref enumerator, predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool All<T, TEnumerator>(this IRefStructCollection<T, TEnumerator> enumerable, Func<T, bool> predicate)
            where TEnumerator : struct, IRefCollectionEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return InnerRefCollectionAll(ref enumerator, predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool All<T, TEnumerable, TEnumerator, TFunction>(this TEnumerable enumerable, ref TFunction predicate, Func<TEnumerable, IRefStructCollection<T, TEnumerator>> _)
            where TEnumerable : IRefStructCollection<T, TEnumerator>
            where TEnumerator : struct, IRefCollectionEnumerator<T>
            where TFunction : IInFunction<T, bool>
        {
            var enumerator = enumerable.GetEnumerator();
            return InnerRefCollectionAll<T, TEnumerator, TFunction>(ref enumerator, ref predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool All<T, TEnumerator>(this IRefStructCollection<T, TEnumerator> enumerable, IInFunction<T, bool> predicate)
            where TEnumerator : struct, IRefCollectionEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return InnerRefCollectionAll<T, TEnumerator, IInFunction<T, bool>>(ref enumerator, ref predicate);
        }
    }
}
