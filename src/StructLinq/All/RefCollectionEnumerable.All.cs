

// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bool InnerRefCollectionAll<T, TEnumerator>(ref TEnumerator enumerator, Func<T, bool> predicate)
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
        internal static bool InnerRefCollectionAll<T, TEnumerator, TFunction>(ref TEnumerator enumerator, ref TFunction predicate)
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
    }

    public readonly partial struct RefStructCollection<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool All(Func<T, bool> predicate, Func<TEnumerable, IRefStructCollection<T, TEnumerator>> _)
        {
            var enumerator = enumerable.GetEnumerator();
            return StructEnumerable.InnerRefCollectionAll(ref enumerator, predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool All(Func<T, bool> predicate)
        {
            var enumerator = enumerable.GetEnumerator();
            return StructEnumerable.InnerRefCollectionAll(ref enumerator, predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool All<TFunction>(ref TFunction predicate, Func<TEnumerable, IRefStructCollection<T, TEnumerator>> _)
            where TFunction : IInFunction<T, bool>
        {
            var enumerator = enumerable.GetEnumerator();
            return StructEnumerable.InnerRefCollectionAll<T, TEnumerator, TFunction>(ref enumerator, ref predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool All<TFunction>(ref TFunction predicate)
            where TFunction : IInFunction<T, bool>
        {
            var enumerator = enumerable.GetEnumerator();
            return StructEnumerable.InnerRefCollectionAll<T, TEnumerator, TFunction>(ref enumerator, ref predicate);
        }

    }
}
