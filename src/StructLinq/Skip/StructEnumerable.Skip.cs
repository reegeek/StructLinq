using System;
using System.Runtime.CompilerServices;
using StructLinq.Skip;

namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SkipEnumerable<T, TEnumerable, TEnumerator> Skip<T,TEnumerable, TEnumerator>(this TEnumerable enumerable, uint count, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : IStructEnumerable<T, TEnumerator>
        {
            return new SkipEnumerable<T, TEnumerable, TEnumerator>(ref enumerable, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SkipEnumerable<T, IStructEnumerable<T, TEnumerator>, TEnumerator> Skip<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, uint count)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            return new SkipEnumerable<T, IStructEnumerable<T, TEnumerator>, TEnumerator>(ref enumerable, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefSkipEnumerable<T, TEnumerable, TEnumerator> Skip<T,TEnumerable, TEnumerator>(this TEnumerable enumerable, uint count, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TEnumerable : IRefStructEnumerable<T, TEnumerator>
        {
            return new RefSkipEnumerable<T, TEnumerable, TEnumerator>(ref enumerable, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefSkipEnumerable<T, IRefStructEnumerable<T, TEnumerator>, TEnumerator> Skip<T, TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, uint count)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            return new RefSkipEnumerable<T, IRefStructEnumerable<T, TEnumerator>, TEnumerator>(ref enumerable, count);
        }
    }
}
