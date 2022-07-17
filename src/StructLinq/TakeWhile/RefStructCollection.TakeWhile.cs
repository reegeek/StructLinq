
using System;
using System.Runtime.CompilerServices;
using StructLinq.TakeWhile;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct RefStructCollection<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public RefStructEnumerable<T, RefTakeWhileEnumerable<T, TFunction, TEnumerable, TEnumerator>, RefTakeWhileEnumerator<T, TFunction, TEnumerator>>
            TakeWhile<TFunction>(TFunction predicate, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TFunction : struct, IInFunction<T, bool>
        {
            return new(new(enumerable, predicate));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefStructEnumerable<T, RefTakeWhileEnumerable<T, TFunction, TEnumerable, TEnumerator>, RefTakeWhileEnumerator<T, TFunction, TEnumerator>>
            TakeWhile<TFunction>(TFunction predicate)
            where TFunction : struct, IInFunction<T, bool>
        {
            return new(new(enumerable, predicate));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public RefStructEnumerable<T, RefTakeWhileEnumerable<T, StructInFunction<T, bool>, TEnumerable, TEnumerator>, RefTakeWhileEnumerator<T, StructInFunction<T, bool>, TEnumerator>>
            TakeWhile(InFunc<T, bool> predicate, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
        {
            return new(new(enumerable, predicate.ToStruct()));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefStructEnumerable<T, RefTakeWhileEnumerable<T, StructInFunction<T, bool>, TEnumerable, TEnumerator>, RefTakeWhileEnumerator<T, StructInFunction<T, bool>, TEnumerator>>
            TakeWhile(InFunc<T, bool> predicate)
        {
            return new(new(enumerable, predicate.ToStruct()));
        }

    }

}
