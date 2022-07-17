﻿// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct StructEnumerable<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public T LastOrDefault(Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
        {
            var enumerator = enumerable.GetEnumerator();
            T last = default;
            TryInnerLast(ref enumerator, ref last);
            return last;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T LastOrDefault()
        {
            var enumerator = enumerable.GetEnumerator();
            T last = default;
            TryInnerLast(ref enumerator, ref last);
            return last;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public T LastOrDefault(Func<T, bool> predicate, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
        {
            var enumerator = enumerable.GetEnumerator();
            T last = default;
            TryInnerLast(ref enumerator, predicate, ref last);
            return last;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T LastOrDefault(Func<T, bool> predicate)
        {
            var enumerator = enumerable.GetEnumerator();
            T last = default;
            TryInnerLast(ref enumerator, predicate, ref last);
            return last;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public T LastOrDefault<TFunc>(ref TFunc predicate, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TFunc : struct, IFunction<T, bool>
        {
            var enumerator = enumerable.GetEnumerator();
            T last = default;
            TryInnerLast(ref enumerator, ref predicate, ref last);
            return last;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T LastOrDefault<TFunc>(ref TFunc predicate)
            where TFunc : struct, IFunction<T, bool>
        {
            var enumerator = enumerable.GetEnumerator();
            T last = default;
            TryInnerLast(ref enumerator, ref predicate, ref last);
            return last;
        }

    }

}