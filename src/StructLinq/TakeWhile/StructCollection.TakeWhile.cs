
using System;
using System.Runtime.CompilerServices;
using StructLinq.TakeWhile;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct StructCollection<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public StructEnumerable<T, TakeWhileEnumerable<T, TFunction, TEnumerable, TEnumerator>, TakeWhileEnumerator<T, TFunction, TEnumerator>>
            TakeWhile<TFunction>(TFunction predicate, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TFunction : struct, IFunction<T, bool>
        {
            return new(new(enumerable, predicate));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnumerable<T, TakeWhileEnumerable<T, TFunction, TEnumerable, TEnumerator>, TakeWhileEnumerator<T, TFunction, TEnumerator>>
            TakeWhile<TFunction>(TFunction predicate)
            where TFunction : struct, IFunction<T, bool>
        {
            return new(new(enumerable, predicate));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public StructEnumerable<T, TakeWhileEnumerable<T, StructFunction<T, bool>, TEnumerable, TEnumerator>, TakeWhileEnumerator<T, StructFunction<T, bool>, TEnumerator>>
            TakeWhile(Func<T, bool> predicate, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
        {
            return new(new(enumerable, predicate.ToStruct()));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnumerable<T, TakeWhileEnumerable<T, StructFunction<T, bool>, TEnumerable, TEnumerator>, TakeWhileEnumerator<T, StructFunction<T, bool>, TEnumerator>>
            TakeWhile(Func<T, bool> predicate)
        {
            return new(new(enumerable, predicate.ToStruct()));
        }
    }

}
