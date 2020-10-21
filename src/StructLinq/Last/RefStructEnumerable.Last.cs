// ReSharper disable once CheckNamespace

using System;
using System.Buffers;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static ref T RefInnerLast<T, TEnumerator>(TEnumerator enumerator)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            if (enumerator.MoveNext())
            {
                var rent = ArrayPool<T>.Shared.Rent(1);
                do
                {
                    ref var elt = ref rent[0];
                    ref var current = ref enumerator.Current;
                    elt = current;
                }
                while (enumerator.MoveNext());
                enumerator.Dispose();
                ref var result = ref rent[0];
                ArrayPool<T>.Shared.Return(rent);
                return ref result;
            }
            enumerator.Dispose();
            throw new Exception("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static ref T RefInnerLast<T, TEnumerator>(TEnumerator enumerator, Func<T, bool> predicate)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var rent = ArrayPool<T>.Shared.Rent(1);
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                if (predicate(current))
                {
                    ref var elt = ref rent[0];
                    elt = current;
                }
            }
            enumerator.Dispose();
            ref var result = ref rent[0];
            ArrayPool<T>.Shared.Return(rent);
            return ref result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static ref T RefInnerLast<T, TEnumerator, TFunc>(TEnumerator enumerator, ref TFunc predicate)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TFunc : struct, IInFunction<T, bool>
        {
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                if (predicate.Eval(in current))
                {
                    enumerator.Dispose();
                    return ref current;
                }
            }
            enumerator.Dispose();
            throw new Exception("No Match");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T Last<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TEnumerable : IRefStructEnumerable<T, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return ref RefInnerLast<T, TEnumerator>(enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T Last<T, TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return ref RefInnerLast<T, TEnumerator>(enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T Last<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<T, bool> predicate, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TEnumerable : IRefStructEnumerable<T, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return ref RefInnerLast(enumerator, predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T Last<T, TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, Func<T, bool> predicate)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return ref RefInnerLast<T, TEnumerator>(enumerator, predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T Last<T, TEnumerable, TEnumerator, TFunc>(this TEnumerable enumerable, ref TFunc predicate, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TEnumerable : IRefStructEnumerable<T, TEnumerator>
            where TFunc : struct, IInFunction<T, bool>
        {
            var enumerator = enumerable.GetEnumerator();
            return ref RefInnerLast<T, TEnumerator, TFunc>(enumerator, ref predicate);
        }
    }
}