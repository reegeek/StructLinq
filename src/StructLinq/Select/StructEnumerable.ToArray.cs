using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using StructLinq.Select;

namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TOut[] ToArray<TIn, TOut, TEnumerable, TEnumerator, TFunction>(this SelectEnumerable<TIn, TOut, TEnumerable, TEnumerator, TFunction> selectEnumerable)
            where TEnumerator : struct, IStructEnumerator<TIn>
            where TFunction : struct, IFunction<TIn, TOut>
            where TEnumerable : IStructCollection<TIn, TEnumerator>
        {
            var enumerator = selectEnumerable.GetEnumerator();
            return ToArray(ref enumerator, selectEnumerable.Inner.Count, ArrayPool<TOut>.Shared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TOut[] ToArray<TIn, TOut, TEnumerable, TEnumerator, TFunction>(this SelectEnumerable<TIn, TOut, TEnumerable, TEnumerator, TFunction> selectEnumerable, Func<TEnumerable, IStructCollection<TIn, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<TIn>
            where TFunction : struct, IFunction<TIn, TOut>
            where TEnumerable : IStructCollection<TIn, TEnumerator>
        {
            var enumerator = selectEnumerable.GetEnumerator();
            return ToArray(ref enumerator, selectEnumerable.Inner.Count, ArrayPool<TOut>.Shared);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TOut[] ToArray<TIn, TOut, TEnumerable, TEnumerator, TFunction>(this RefSelectEnumerable<TIn, TOut, TEnumerable, TEnumerator, TFunction> selectEnumerable)
            where TEnumerator : struct, IRefStructEnumerator<TIn>
            where TFunction : struct, IInFunction<TIn, TOut>
            where TEnumerable : IRefStructCollection<TIn, TEnumerator>
        {
            var enumerator = selectEnumerable.GetEnumerator();
            return ToArray(ref enumerator, selectEnumerable.Inner.Count, ArrayPool<TOut>.Shared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TOut[] ToArray<TIn, TOut, TEnumerable, TEnumerator, TFunction>(this RefSelectEnumerable<TIn, TOut, TEnumerable, TEnumerator, TFunction> selectEnumerable, Func<TEnumerable, IRefStructCollection<TIn, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<TIn>
            where TFunction : struct, IInFunction<TIn, TOut>
            where TEnumerable : IRefStructCollection<TIn, TEnumerator>
        {
            var enumerator = selectEnumerable.GetEnumerator();
            return ToArray(ref enumerator, selectEnumerable.Inner.Count, ArrayPool<TOut>.Shared);
        }

    }
}
