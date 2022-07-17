// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct StructCollection<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public T LastOrDefault(Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
        {
            T last = default;
            TryLast(ref last);
            return last;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T LastOrDefault()
        {
            T last = default;
            TryLast(ref last);
            return last;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public T LastOrDefault(Func<T, bool> predicate, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
        {
            T last = default;
            TryLast(predicate, ref last);
            return last;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T LastOrDefault(Func<T, bool> predicate)
        {
            T last = default;
            TryLast(predicate, ref last);
            return last;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public T LastOrDefault<TFunc>(ref TFunc predicate, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TFunc : struct, IFunction<T, bool>
        {
            T last = default;
            TryLast(ref predicate, ref last);
            return last;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T LastOrDefault<TFunc>(ref TFunc predicate)
            where TFunc : struct, IFunction<T, bool>
        {
            T last = default;
            TryLast(ref predicate, ref last);
            return last;
        }

    }

}