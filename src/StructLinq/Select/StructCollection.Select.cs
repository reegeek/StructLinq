using System;
using System.Runtime.CompilerServices;
using StructLinq.Select;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct StructCollection<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public StructCollection<TOut, SelectCollection<T, TOut, TEnumerable, TEnumerator, TFunction>, SelectCollectionEnumerator<T, TOut, TEnumerator, TFunction>> Select<TOut, TFunction>(
            ref TFunction function, 
            Func<TEnumerable, IStructCollection<T, TEnumerator>> _, 
            Func<TFunction, IFunction<T, TOut>> __)
            where TFunction : struct, IFunction<T, TOut>
        {
            return new(new(ref function, ref enumerable));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructCollection<TOut, SelectCollection<T, TOut, TEnumerable, TEnumerator, TFunction>, SelectCollectionEnumerator<T, TOut, TEnumerator, TFunction>> Select<TOut, TFunction>(
            ref TFunction function,
            Func<TFunction, IFunction<T, TOut>> __)
            where TFunction : struct, IFunction<T, TOut>
        {
            return new(new(ref function, ref enumerable));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public StructCollection<TOut, SelectCollection<T, TOut, TEnumerable, TEnumerator>, SelectCollectionEnumerator<T, TOut, TEnumerator>> Select<TOut>(Func<T, TOut> function,
            Func<TEnumerable, IStructCollection<T, TEnumerator>> _)
        {
            return new(new(function, ref enumerable));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructCollection<TOut, SelectCollection<T, TOut, TEnumerable, TEnumerator>, SelectCollectionEnumerator<T, TOut, TEnumerator>> Select<TOut>(Func<T, TOut> function)
        {
            return new(new(function, ref enumerable));
        }
    }
}