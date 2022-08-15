using System;
using System.Runtime.CompilerServices;
using StructLinq.Select;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct RefStructEnumerable<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public StructEnumerable<TOut, RefSelectEnumerable<T, TOut, TEnumerable, TEnumerator, TFunction>, RefSelectEnumerator<T, TOut, TEnumerator, TFunction>> Select<TOut, TFunction>(
            ref TFunction function,
            Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _, 
            Func<TFunction, IInFunction<T, TOut>> __)
            where TFunction : struct, IInFunction<T, TOut>
        {
            return new( new(ref function, ref enumerable));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnumerable<TOut, RefSelectEnumerable<T, TOut, TEnumerable, TEnumerator, TFunction>, RefSelectEnumerator<T, TOut, TEnumerator, TFunction>> Select<TOut, TFunction>(
            ref TFunction function,
            Func<TFunction, IInFunction<T, TOut>> __)
            where TFunction : struct, IInFunction<T, TOut>
        {
            return new(new(ref function, ref enumerable));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public StructEnumerable<TOut, RefSelectEnumerable<T, TOut, TEnumerable, TEnumerator, StructInFunction<T, TOut>>, RefSelectEnumerator<T, TOut, TEnumerator, StructInFunction<T, TOut>>>
            Select<TOut>(
                InFunc<T, TOut> function, 
                Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
        {
            var fct = function.ToStruct();
            return new(new(ref fct, ref enumerable));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnumerable<TOut, RefSelectEnumerable<T, TOut, TEnumerable, TEnumerator, StructInFunction<T, TOut>>, RefSelectEnumerator<T, TOut, TEnumerator, StructInFunction<T, TOut>>>
            Select<TOut>(
                InFunc<T, TOut> function)
        {
            var fct = function.ToStruct();
            return new(new(ref fct, ref enumerable));
        }
    }
}