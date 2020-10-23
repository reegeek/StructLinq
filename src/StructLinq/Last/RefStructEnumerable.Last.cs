// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool RefTryInnerLast<T, TEnumerator>(ref TEnumerator enumerator, ref T last)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            if (enumerator.MoveNext())
            {
                do
                {
                    ref var current = ref enumerator.Current;
                    last = current;
                }
                while (enumerator.MoveNext());
                enumerator.Dispose();
                return true;
            }
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool TryRefInnerLast<T, TEnumerator>(ref TEnumerator enumerator, Func<T, bool> predicate, ref T last)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            bool found = false;
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                if (predicate(current))
                {
                    last = current;
                    found = true;
                }
            }
            enumerator.Dispose();
            return found;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool TryRefInnerLast<T, TEnumerator, TFunc>(ref TEnumerator enumerator, ref TFunc predicate, ref T last)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TFunc : struct, IInFunction<T, bool>
        {
            bool found = false;
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                if (predicate.Eval(in current))
                {
                    last = current;
                    found = true;
                }
            }
            enumerator.Dispose();
            return found;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryLast<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, ref T last, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TEnumerable : IRefStructEnumerable<T, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefTryInnerLast<T, TEnumerator>(ref enumerator, ref last);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryLast<T, TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, ref T last)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefTryInnerLast<T, TEnumerator>(ref enumerator, ref last);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryLast<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<T, bool> predicate, ref T last, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TEnumerable : IRefStructEnumerable<T, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return  TryRefInnerLast(ref enumerator, predicate, ref last);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryLast<T, TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, Func<T, bool> predicate, ref T last)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return  TryRefInnerLast(ref enumerator, predicate, ref last);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryLast<T, TEnumerable, TEnumerator, TFunc>(this TEnumerable enumerable, ref TFunc predicate, ref T last, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TEnumerable : IRefStructEnumerable<T, TEnumerator>
            where TFunc : struct, IInFunction<T, bool>
        {
            var enumerator = enumerable.GetEnumerator();
            return TryRefInnerLast(ref enumerator, ref predicate, ref last);
        }
    }
}