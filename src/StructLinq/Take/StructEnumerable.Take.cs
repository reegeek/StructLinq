using System;
using System.Runtime.CompilerServices;
using StructLinq.Skip;
using StructLinq.Take;

namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TakeEnumerable<T, TEnumerable, TEnumerator> Take<T,TEnumerable, TEnumerator>(this TEnumerable enumerable, int count, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : IStructEnumerable<T, TEnumerator>
        {
            return new TakeEnumerable<T, TEnumerable, TEnumerator>(ref enumerable, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TakeEnumerable<T, IStructEnumerable<T, TEnumerator>, TEnumerator> Take<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, int count)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            return new TakeEnumerable<T, IStructEnumerable<T, TEnumerator>, TEnumerator>(ref enumerable, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefTakeEnumerable<T, TEnumerable, TEnumerator> Take<T,TEnumerable, TEnumerator>(this TEnumerable enumerable, int count, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TEnumerable : IRefStructEnumerable<T, TEnumerator>
        {
            return new RefTakeEnumerable<T, TEnumerable, TEnumerator>(ref enumerable, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefTakeEnumerable<T, IRefStructEnumerable<T, TEnumerator>, TEnumerator> Take<T, TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, int count)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            return new RefTakeEnumerable<T, IRefStructEnumerable<T, TEnumerator>, TEnumerator>(ref enumerable, count);
        }
    }
}
