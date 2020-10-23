// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool TryInnerLast<T, TEnumerator>(ref TEnumerator enumerator, ref T last)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            if (enumerator.MoveNext())
            {
                T result;
                do
                {
                    result = enumerator.Current;

                }
                while (enumerator.MoveNext());
                enumerator.Dispose();
                last = result;
                return true;
            }
            enumerator.Dispose();
            return false;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool TryInnerLast<T, TEnumerator>(ref TEnumerator enumerator, Func<T, bool> predicate, ref T last)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            bool found = false;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
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
        private static bool TryInnerLast<T, TEnumerator, TFunc>(ref TEnumerator enumerator, ref TFunc predicate, ref T last)
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : struct, IFunction<T, bool>
        {
            bool found = false;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                if (predicate.Eval(current))
                {
                    last = current;
                    found = true;
                }
            }
            enumerator.Dispose();
            return found;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Last<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : IStructEnumerable<T, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            T last = default;
            if (TryInnerLast(ref enumerator, ref last))
                return last;
            throw new Exception("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Last<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            T last = default;
            if (TryInnerLast(ref enumerator, ref last))
                return last;
            throw new Exception("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Last<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<T, bool> predicate, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : IStructEnumerable<T, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            T last = default;
            if (TryInnerLast(ref enumerator, predicate, ref last))
                return last;
            throw new Exception("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Last<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, Func<T, bool> predicate)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            T last = default;
            if (TryInnerLast(ref enumerator, predicate, ref last))
                return last;
            throw new Exception("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Last<T, TEnumerable, TEnumerator, TFunc>(this TEnumerable enumerable, ref TFunc predicate, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : IStructEnumerable<T, TEnumerator>
            where TFunc : struct, IFunction<T, bool>
        {
            var enumerator = enumerable.GetEnumerator();
            T last = default;
            if (TryInnerLast(ref enumerator, ref predicate, ref last))
                return last;
            throw new Exception("No Elements");
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryLast<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, ref T last, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : IStructEnumerable<T, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return TryInnerLast(ref enumerator, ref last);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryLast<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, ref T last)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return TryInnerLast(ref enumerator, ref last);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryLast<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<T, bool> predicate, ref T last, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : IStructEnumerable<T, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return TryInnerLast(ref enumerator, predicate, ref last);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryLast<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, Func<T, bool> predicate, ref T last)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return TryInnerLast(ref enumerator, predicate, ref last);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryLast<T, TEnumerable, TEnumerator, TFunc>(this TEnumerable enumerable, ref TFunc predicate, ref T last, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : IStructEnumerable<T, TEnumerator>
            where TFunc : struct, IFunction<T, bool>
        {
            var enumerator = enumerable.GetEnumerator();
            return TryInnerLast(ref enumerator, ref predicate, ref last);
        }

    }
}