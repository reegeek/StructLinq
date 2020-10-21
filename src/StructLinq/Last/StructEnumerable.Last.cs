// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static T InnerLast<T, TEnumerator>(ref TEnumerator enumerator)
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
                return result;
            }
            enumerator.Dispose();
            throw new Exception("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static T InnerLast<T, TEnumerator>(ref TEnumerator enumerator, Func<T, bool> predicate)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            T result = default;
            bool found = false;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                if (predicate(current))
                {
                    result = current;
                    found = true;
                }
            }
            enumerator.Dispose();
            if (found)
                return result;
            throw new Exception("No Match");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static T InnerLast<T, TEnumerator, TFunc>(ref TEnumerator enumerator, ref TFunc predicate)
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : struct, IFunction<T, bool>
        {
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                if (predicate.Eval(current))
                {
                    enumerator.Dispose();
                    return current;
                }
            }
            enumerator.Dispose();
            throw new Exception("No Match");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Last<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : IStructEnumerable<T, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return InnerLast<T, TEnumerator>(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Last<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return InnerLast<T, TEnumerator>(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Last<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<T, bool> predicate, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : IStructEnumerable<T, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return InnerLast(ref enumerator, predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Last<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, Func<T, bool> predicate)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return InnerLast(ref enumerator, predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Last<T, TEnumerable, TEnumerator, TFunc>(this TEnumerable enumerable, ref TFunc predicate, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : IStructEnumerable<T, TEnumerator>
            where TFunc : struct, IFunction<T, bool>
        {
            var enumerator = enumerable.GetEnumerator();
            return InnerLast<T, TEnumerator, TFunc>(ref enumerator, ref predicate);
        }
    }
}