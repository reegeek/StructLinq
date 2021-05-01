
using System;
using System.Runtime.CompilerServices;
using StructLinq.SkipWhile;
using StructLinq.TakeWhile;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TakeWhileEnumerable<T, TFunction, TEnumerable, TEnumerator> TakeWhile<T, TFunction, TEnumerable, TEnumerator>(this TEnumerable enumerable, TFunction predicate,
                                                                                                                                    Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TFunction : struct, IFunction<T, bool>
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : IStructEnumerable<T, TEnumerator>
        {
            return new(enumerable, predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TakeWhileEnumerable<T, StructFunction<T, bool>, TEnumerable, TEnumerator> TakeWhile<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<T, bool> predicate,
                                                                                                                                       Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : IStructEnumerable<T, TEnumerator>
        {
            return new(enumerable, predicate.ToStruct());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TakeWhileEnumerable<T, StructFunction<T, bool>, IStructEnumerable<T, TEnumerator>, TEnumerator> TakeWhile<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, Func<T, bool> predicate)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            return new(enumerable, predicate.ToStruct());
        }

    }
}
