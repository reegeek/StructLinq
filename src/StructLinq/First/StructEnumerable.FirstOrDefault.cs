// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstOrDefault<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : IStructEnumerable<T, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            T first = default;
            TryInnerFirst(ref enumerator, ref first);
            return first;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstOrDefault<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            T first = default;
            TryInnerFirst(ref enumerator, ref first);
            return first;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstOrDefault<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<T, bool> predicate, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : IStructEnumerable<T, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            T first = default;
            TryInnerFirst(ref enumerator, predicate, ref first);
            return first;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstOrDefault<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, Func<T, bool> predicate)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            T first = default;
            TryInnerFirst(ref enumerator, predicate, ref first);
            return first;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstOrDefault<T, TEnumerable, TEnumerator, TFunc>(this TEnumerable enumerable, ref TFunc predicate, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : IStructEnumerable<T, TEnumerator>
            where TFunc : struct, IFunction<T, bool>
        {
            var enumerator = enumerable.GetEnumerator();
            T first = default;
            TryInnerFirst(ref enumerator, ref predicate, ref first);
            return first;
        }
    }
}