using System;
using System.Runtime.CompilerServices;
using StructLinq.Where;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct RefStructCollection<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public RefStructEnumerable<T, RefWhereEnumerable<T, TEnumerable, TEnumerator, TFunction>, RefWhereEnumerator<T, TEnumerator, TFunction>>
    Where<TFunction>(ref TFunction predicate, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
    where TFunction : struct, IInFunction<T, bool>
        {
            return new(new(ref predicate, ref enumerable));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public RefStructEnumerable<T, RefWhereEnumerable<T, TEnumerable, TEnumerator, StructInFunction<T, bool>>, RefWhereEnumerator<T, TEnumerator, StructInFunction<T, bool>>>
            Where(InFunc<T, bool> predicate, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
        {
            var structPredicate = predicate.ToStruct();
            return new(new(ref structPredicate, ref enumerable));

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefStructEnumerable<T, RefWhereEnumerable<T, TEnumerable, TEnumerator, TFunction>, RefWhereEnumerator<T, TEnumerator, TFunction>>
            Where<TFunction>(ref TFunction predicate)
            where TFunction : struct, IInFunction<T, bool>
        {
            return new(new(ref predicate, ref enumerable));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefStructEnumerable<T, RefWhereEnumerable<T, TEnumerable, TEnumerator, StructInFunction<T, bool>>, RefWhereEnumerator<T, TEnumerator, StructInFunction<T, bool>>>
            Where(InFunc<T, bool> predicate)
        {
            var structPredicate = predicate.ToStruct();
            return new(new(ref structPredicate, ref enumerable));

        }

    }
}
