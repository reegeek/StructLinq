// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstOrDefault<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TEnumerable : IRefStructEnumerable<T, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            T first = default;
            TryRefInnerFirst(ref enumerator, ref first);
            return first;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstOrDefault<T, TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            T first = default;
            TryRefInnerFirst(ref enumerator, ref first);
            return first;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstOrDefault<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<T, bool> predicate, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TEnumerable : IRefStructEnumerable<T, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            T first = default;
            TryRefInnerFirst(ref enumerator, predicate, ref first);
            return first;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstOrDefault<T, TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, Func<T, bool> predicate)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            T first = default;
            TryRefInnerFirst(ref enumerator, predicate, ref first);
            return first;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstOrDefault<T, TEnumerable, TEnumerator, TFunc>(this TEnumerable enumerable, ref TFunc predicate, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TEnumerable : IRefStructEnumerable<T, TEnumerator>
            where TFunc : struct, IInFunction<T, bool>
        {
            var enumerator = enumerable.GetEnumerator();
            T first = default;
            TryRefInnerFirst(ref enumerator, ref predicate, ref first);
            return first;
        }
    }
}