using System;
using System.Runtime.CompilerServices;
using StructLinq.Where;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct RefStructEnum<T, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefStructEnum<T, RefWhereEnumerator<T, TEnumerator, TFunction>> Where<TFunction>(ref TFunction predicate)
            where TFunction : struct, IInFunction<T, bool>
        {
            var copy = enumerator;
            return new(new(ref predicate, ref copy));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public RefStructEnum<T, RefWhereEnumerator<T, TEnumerator, TFunction>> Where<TFunction>(ref TFunction predicate, Func<TEnumerator, IRefStructEnumerator<T>> _)
            where TFunction : struct, IInFunction<T, bool>
        {
            var copy = enumerator;
            return new(new(ref predicate, ref copy));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefStructEnum<T, RefWhereEnumerator<T, TEnumerator, StructInFunction<T, bool>>> Where(InFunc<T, bool> predicate)
        {
            var copy = enumerator;
            var inFunc = predicate.ToStruct();
            return new(new(ref inFunc, ref copy));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public RefStructEnum<T, RefWhereEnumerator<T, TEnumerator, StructInFunction<T, bool>>> Where(InFunc<T, bool> predicate, Func<TEnumerator, IRefStructEnumerator<T>> _)
        {
            var copy = enumerator;
            var inFunc = predicate.ToStruct();
            return new(new(ref inFunc, ref copy));
        }

    }
}
