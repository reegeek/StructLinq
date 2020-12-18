using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using StructLinq.Select;
using StructLinq.Utils.Collections;

namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TOut[] ToArray<TIn, TOut, TEnumerable, TEnumerator>(this SelectEnumerable<TIn, TOut, TEnumerable, TEnumerator> selectEnumerable)
            where TEnumerator : struct, IStructEnumerator<TIn>
            where TEnumerable : IStructCollection<TIn, TEnumerator>
        {
            var enumerator = selectEnumerable.GetEnumerator();
            return ToArray<TOut, SelectEnumerator<TIn, TOut, TEnumerator>>(ref enumerator, selectEnumerable.Inner.Count);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TOut[] ToArray2<TIn, TOut, TEnumerable, TEnumerator>(this SelectEnumerable<TIn, TOut, TEnumerable, TEnumerator> selectEnumerable)
            where TEnumerator : struct, IStructEnumerator<TIn>
            where TEnumerable : IStructCollection<TIn, TEnumerator>
        {
            var visitor = new ToArrayVisitor<TOut>(selectEnumerable.Inner.Count);
            selectEnumerable.Visit(ref visitor);
            return visitor.Array;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TOut[] ToArray<TIn, TOut, TEnumerable, TEnumerator>(this SelectEnumerable<TIn, TOut, TEnumerable, TEnumerator> selectEnumerable, Func<TEnumerable, IStructCollection<TIn, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<TIn>
            where TEnumerable : IStructCollection<TIn, TEnumerator>
        {
            var enumerator = selectEnumerable.GetEnumerator();
            return ToArray<TOut, SelectEnumerator<TIn, TOut, TEnumerator>>(ref enumerator, selectEnumerable.Inner.Count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TOut[] ToArray2<TIn, TOut, TEnumerable, TEnumerator>(this SelectEnumerable<TIn, TOut, TEnumerable, TEnumerator> selectEnumerable, Func<TEnumerable, IStructCollection<TIn, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<TIn>
            where TEnumerable : IStructCollection<TIn, TEnumerator>
        {
            var visitor = new ToArrayVisitor<TOut>(selectEnumerable.Inner.Count);
            selectEnumerable.Visit(ref visitor);
            return visitor.Array;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TOut[] ToArray<TIn, TOut, TEnumerable, TEnumerator, TFunction>(this SelectEnumerable<TIn, TOut, TEnumerable, TEnumerator, TFunction> selectEnumerable)
            where TEnumerator : struct, IStructEnumerator<TIn>
            where TFunction : struct, IFunction<TIn, TOut>
            where TEnumerable : IStructCollection<TIn, TEnumerator>
        {
            var enumerator = selectEnumerable.GetEnumerator();
            return ToArray<TOut, SelectEnumerator<TIn, TOut, TEnumerator, TFunction>>(ref enumerator, selectEnumerable.Inner.Count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TOut[] ToArray<TIn, TOut, TEnumerable, TEnumerator, TFunction>(this SelectEnumerable<TIn, TOut, TEnumerable, TEnumerator, TFunction> selectEnumerable, Func<TEnumerable, IStructCollection<TIn, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<TIn>
            where TFunction : struct, IFunction<TIn, TOut>
            where TEnumerable : IStructCollection<TIn, TEnumerator>
        {
            var enumerator = selectEnumerable.GetEnumerator();
            return ToArray<TOut, SelectEnumerator<TIn, TOut, TEnumerator, TFunction>>(ref enumerator, selectEnumerable.Inner.Count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TOut[] ToArray2<TIn, TOut, TEnumerable, TEnumerator, TFunction>(this SelectEnumerable<TIn, TOut, TEnumerable, TEnumerator, TFunction> selectEnumerable, Func<TEnumerable, IStructCollection<TIn, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<TIn>
            where TFunction : struct, IFunction<TIn, TOut>
            where TEnumerable : IStructCollection<TIn, TEnumerator>
        {
            var visitor = new ToArrayVisitor<TOut>(selectEnumerable.Inner.Count);
            selectEnumerable.Visit(ref visitor);
            return visitor.Array;
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TOut[] ToArray<TIn, TOut, TEnumerable, TEnumerator, TFunction>(this RefSelectEnumerable<TIn, TOut, TEnumerable, TEnumerator, TFunction> selectEnumerable)
            where TEnumerator : struct, IRefStructEnumerator<TIn>
            where TFunction : struct, IInFunction<TIn, TOut>
            where TEnumerable : IRefStructCollection<TIn, TEnumerator>
        {
            var enumerator = selectEnumerable.GetEnumerator();
            return ToArray<TOut, RefSelectEnumerator<TIn, TOut, TEnumerator, TFunction>>(ref enumerator, selectEnumerable.Inner.Count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TOut[] ToArray<TIn, TOut, TEnumerable, TEnumerator, TFunction>(this RefSelectEnumerable<TIn, TOut, TEnumerable, TEnumerator, TFunction> selectEnumerable, Func<TEnumerable, IRefStructCollection<TIn, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<TIn>
            where TFunction : struct, IInFunction<TIn, TOut>
            where TEnumerable : IRefStructCollection<TIn, TEnumerator>
        {
            var enumerator = selectEnumerable.GetEnumerator();
            return ToArray<TOut, RefSelectEnumerator<TIn, TOut, TEnumerator, TFunction>>(ref enumerator, selectEnumerable.Inner.Count);
        }

    }
}
