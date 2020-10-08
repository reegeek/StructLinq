

// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool RefInnerAny<T, TEnumerator>(ref TEnumerator enumerator, Func<T, bool> predicate)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                if (predicate(current))
                {
                    enumerator.Dispose();
                    return true;
                }
            }
            enumerator.Dispose();
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool RefInnerAny<T, TEnumerator, TFunction>(ref TEnumerator enumerator, ref TFunction predicate)
        where TEnumerator : struct, IRefStructEnumerator<T>
        where TFunction : IInFunction<T, bool>
        {
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                if (predicate.Eval(in current))
                {
                    enumerator.Dispose();
                    return true;
                }
            }
            enumerator.Dispose();
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Any<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : IRefStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            var result = enumerator.MoveNext();
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Any<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<T, bool> predicate, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : IRefStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefInnerAny(ref enumerator, predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Any<T, TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            var result = enumerator.MoveNext();
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Any<T, TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, Func<T, bool> predicate)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefInnerAny(ref enumerator, predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Any<T, TEnumerable, TEnumerator, TFunction>(this TEnumerable enumerable, ref TFunction predicate, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : IRefStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TFunction : IInFunction<T, bool>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefInnerAny<T, TEnumerator, TFunction>(ref enumerator, ref predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Any<T, TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, IInFunction<T, bool> predicate)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefInnerAny<T, TEnumerator, IInFunction<T, bool>>(ref enumerator, ref predicate);
        }
    }
}
