// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct RefStructEnumerable<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public T FirstOrDefault(Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
        {
            var enumerator = enumerable.GetEnumerator();
            T first = default;
            TryRefInnerFirst(ref enumerator, ref first);
            return first;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T FirstOrDefault()
        {
            var enumerator = enumerable.GetEnumerator();
            T first = default;
            TryRefInnerFirst(ref enumerator, ref first);
            return first;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public T FirstOrDefault(Func<T, bool> predicate, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
        {
            var enumerator = enumerable.GetEnumerator();
            T first = default;
            TryRefInnerFirst(ref enumerator, predicate, ref first);
            return first;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T FirstOrDefault(Func<T, bool> predicate)
        {
            var enumerator = enumerable.GetEnumerator();
            T first = default;
            TryRefInnerFirst(ref enumerator, predicate, ref first);
            return first;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public T FirstOrDefault<TFunc>(ref TFunc predicate, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TFunc : struct, IInFunction<T, bool>
        {
            var enumerator = enumerable.GetEnumerator();
            T first = default;
            TryRefInnerFirst(ref enumerator, ref predicate, ref first);
            return first;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T FirstOrDefault<TFunc>(ref TFunc predicate)
            where TFunc : struct, IInFunction<T, bool>
        {
            var enumerator = enumerable.GetEnumerator();
            T first = default;
            TryRefInnerFirst(ref enumerator, ref predicate, ref first);
            return first;
        }
    }
}