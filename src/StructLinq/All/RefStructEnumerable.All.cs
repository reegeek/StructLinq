﻿

// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool RefInnerAll<T, TEnumerator>(ref TEnumerator enumerator, Func<T, bool> predicate)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
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
        private static bool RefInnerAll<T, TEnumerator, TFunction>(ref TEnumerator enumerator, ref TFunction predicate)
        where TEnumerator : struct, IRefStructEnumerator<T>
        where TFunction : IInFunction<T, bool>
        {
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
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
        public static bool All<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<T, bool> predicate, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : IRefStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefInnerAll(ref enumerator, predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool All<T, TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, Func<T, bool> predicate)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefInnerAll(ref enumerator, predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool All<T, TEnumerable, TEnumerator, TFunction>(this TEnumerable enumerable, ref TFunction predicate, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : IRefStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TFunction : IInFunction<T, bool>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefInnerAll<T, TEnumerator, TFunction>(ref enumerator, ref predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool All<T, TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, IInFunction<T, bool> predicate)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefInnerAll<T, TEnumerator, IInFunction<T, bool>>(ref enumerator, ref predicate);
        }
    }
}
