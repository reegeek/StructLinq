using System;
using System.Runtime.CompilerServices;
using StructLinq.Select;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SelectEnumerable<TIn, TOut, TEnumerable, TEnumerator, TFunction> Select<TIn, TOut, TEnumerable, TEnumerator, TFunction>(this TEnumerable enumerable, ref TFunction function, 
                                                                                                                                              Func<TEnumerable, IStructEnumerable<TIn, TEnumerator>> _, Func<TFunction, IFunction<TIn, TOut>> __)
            where TEnumerator : struct, IStructEnumerator<TIn>
            where TFunction : struct, IFunction<TIn, TOut>
            where TEnumerable : struct, IStructEnumerable<TIn, TEnumerator>
        {
            return new SelectEnumerable<TIn, TOut, TEnumerable, TEnumerator, TFunction>(ref function, ref enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SelectEnumerable<TIn, TOut, TEnumerable, TEnumerator> Select<TIn, TOut, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TIn, TOut> function, Func<TEnumerable, IStructEnumerable<TIn, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<TIn>
            where TEnumerable : struct, IStructEnumerable<TIn, TEnumerator>
        {
            return new SelectEnumerable<TIn, TOut, TEnumerable, TEnumerator>(function, ref enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefSelectEnumerable<TIn, TOut, TEnumerable, TEnumerator, TFunction> Select<TIn, TOut, TEnumerable, TEnumerator, TFunction>(this TEnumerable enumerable, ref TFunction function,
            Func<TEnumerable, IRefStructEnumerable<TIn, TEnumerator>> _, Func<TFunction, IInFunction<TIn, TOut>> __)
            where TEnumerator : struct, IRefStructEnumerator<TIn>
            where TFunction : struct, IInFunction<TIn, TOut>
            where TEnumerable : struct, IRefStructEnumerable<TIn, TEnumerator>
        {
            return new RefSelectEnumerable<TIn, TOut, TEnumerable, TEnumerator, TFunction>(ref function, ref enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefSelectEnumerable<TIn, TOut, TEnumerable, TEnumerator, StructInFunction<TIn, TOut>>
            Select<TIn, TOut, TEnumerable, TEnumerator>(this TEnumerable enumerable, InFunc<TIn, TOut> function, Func<TEnumerable, IRefStructEnumerable<TIn, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<TIn>
            where TEnumerable : struct, IRefStructEnumerable<TIn, TEnumerator>
        {
            var fct = function.ToStruct();
            return new RefSelectEnumerable<TIn, TOut, TEnumerable, TEnumerator, StructInFunction<TIn, TOut>>(ref fct, ref enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SelectEnumerable<TIn, TOut, IStructEnumerable<TIn, TEnumerator>, TEnumerator> Select<TIn, TOut, TEnumerator>(this IStructEnumerable<TIn, TEnumerator> enumerable, Func<TIn, TOut> function)
            where TEnumerator : struct, IStructEnumerator<TIn>
        {
            return new SelectEnumerable<TIn,TOut,IStructEnumerable<TIn, TEnumerator>,TEnumerator>(function, ref enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SelectEnumerable<TIn, TOut, IStructCollection<TIn, TEnumerator>, TEnumerator> Select<TIn, TOut, TEnumerator>(this IStructCollection<TIn, TEnumerator> enumerable, Func<TIn, TOut> function)
            where TEnumerator : struct, IStructEnumerator<TIn>
        {
            return new SelectEnumerable<TIn,TOut,IStructCollection<TIn, TEnumerator>,TEnumerator>(function, ref enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefSelectEnumerable<TIn, TOut, IRefStructEnumerable<TIn, TEnumerator>, TEnumerator, StructInFunction<TIn, TOut>> Select<TIn, TOut, TEnumerator>(this IRefStructEnumerable<TIn, TEnumerator> enumerable, InFunc<TIn, TOut> function)
            where TEnumerator : struct, IRefStructEnumerator<TIn>
        {
            var fct = function.ToStruct();
            return new RefSelectEnumerable<TIn,TOut,IRefStructEnumerable<TIn, TEnumerator>,TEnumerator,StructInFunction<TIn,TOut>>(ref fct, ref enumerable);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefSelectEnumerable<TIn, TOut, IRefStructCollection<TIn, TEnumerator>, TEnumerator, StructInFunction<TIn, TOut>> Select<TIn, TOut, TEnumerator>(this IRefStructCollection<TIn, TEnumerator> enumerable, InFunc<TIn, TOut> function)
            where TEnumerator : struct, IRefStructEnumerator<TIn>
        {
            var fct = function.ToStruct();
            return new RefSelectEnumerable<TIn,TOut,IRefStructCollection<TIn, TEnumerator>,TEnumerator,StructInFunction<TIn,TOut>>(ref fct, ref enumerable);
        }

    }
}