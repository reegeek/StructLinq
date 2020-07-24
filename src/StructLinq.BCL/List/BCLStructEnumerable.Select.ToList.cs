using System;
using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.Select;

namespace StructLinq
{
    public static partial class BCLStructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static List<TOut> ToList<TIn, TOut, TEnumerable, TEnumerator, TFunction>(this SelectEnumerable<TIn, TOut, TEnumerable, TEnumerator, TFunction> selectEnumerable)
            where TEnumerator : struct, IStructEnumerator<TIn>
            where TFunction : struct, IFunction<TIn, TOut>
            where TEnumerable : IStructCollection<TIn, TEnumerator>
        {
            return selectEnumerable.ToList(selectEnumerable.Inner.Count, ArrayPool<TOut>.Shared, x => x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static List<TOut> ToList<TIn, TOut, TEnumerator, TFunction>(this SelectEnumerable<TIn, TOut, IStructCollection<TIn, TEnumerator>, TEnumerator, TFunction> selectEnumerable)
            where TEnumerator : struct, IStructEnumerator<TIn>
            where TFunction : struct, IFunction<TIn, TOut>
        {
            return selectEnumerable.ToList(selectEnumerable.Inner.Count, ArrayPool<TOut>.Shared, x => x);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static List<TOut> ToList<TIn, TOut, TEnumerable, TEnumerator, TFunction>(this SelectEnumerable<TIn, TOut, TEnumerable, TEnumerator, TFunction> selectEnumerable, Func<TEnumerable, IStructCollection<TIn, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<TIn>
            where TFunction : struct, IFunction<TIn, TOut>
            where TEnumerable : IStructCollection<TIn, TEnumerator>
        {
            return selectEnumerable.ToList(selectEnumerable.Inner.Count, ArrayPool<TOut>.Shared, x => x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static List<TOut> ToList<TIn, TOut, TEnumerable, TEnumerator, TFunction>(this RefSelectEnumerable<TIn, TOut, TEnumerable, TEnumerator, TFunction> selectEnumerable)
            where TEnumerator : struct, IRefStructEnumerator<TIn>
            where TFunction : struct, IInFunction<TIn, TOut>
            where TEnumerable : IRefStructCollection<TIn, TEnumerator>
        {
            return selectEnumerable.ToList(selectEnumerable.Inner.Count, ArrayPool<TOut>.Shared, x => x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static List<TOut> ToList<TIn, TOut, TEnumerator, TFunction>(this RefSelectEnumerable<TIn, TOut, IRefStructCollection<TIn, TEnumerator>, TEnumerator, TFunction> selectEnumerable)
            where TEnumerator : struct, IRefStructEnumerator<TIn>
            where TFunction : struct, IInFunction<TIn, TOut>
        {
            return selectEnumerable.ToList(selectEnumerable.Inner.Count, ArrayPool<TOut>.Shared, x => x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static List<TOut> ToList<TIn, TOut, TEnumerable, TEnumerator, TFunction>(this RefSelectEnumerable<TIn, TOut, TEnumerable, TEnumerator, TFunction> selectEnumerable, Func<TEnumerable, IRefStructCollection<TIn, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<TIn>
            where TFunction : struct, IInFunction<TIn, TOut>
            where TEnumerable : IRefStructCollection<TIn, TEnumerator>
        {
            return selectEnumerable.ToList(selectEnumerable.Inner.Count, ArrayPool<TOut>.Shared, x => x);
        }

    }
}
