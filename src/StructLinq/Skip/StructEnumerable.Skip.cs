using System;
using System.Runtime.CompilerServices;
using StructLinq.Skip;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SkipEnumerable<T, TEnumerable, TEnumerator> Skip<T,TEnumerable, TEnumerator>(this TEnumerable enumerable, int count, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : IStructEnumerable<T, TEnumerator>
        {
            return new(ref enumerable, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SkipEnumerable<T, IStructEnumerable<T, TEnumerator>, TEnumerator> Skip<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, int count)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            return new(ref enumerable, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefSkipEnumerable<T, TEnumerable, TEnumerator> Skip<T,TEnumerable, TEnumerator>(this TEnumerable enumerable, int count, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TEnumerable : IRefStructEnumerable<T, TEnumerator>
        {
            return new(ref enumerable, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefSkipEnumerable<T, IRefStructEnumerable<T, TEnumerator>, TEnumerator> Skip<T, TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, int count)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            return new(ref enumerable, count);
        }
    }
}
