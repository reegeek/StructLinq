﻿// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static T InnerFirstOrDefault<T, TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            if (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                enumerator.Dispose();
                return current;
            }
            enumerator.Dispose();
            return default;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static T InnerFirstOrDefault<T, TEnumerator>(ref TEnumerator enumerator, Func<T, bool> predicate)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                if (predicate(current))
                {
                    enumerator.Dispose();
                    return current;
                }
            }
            enumerator.Dispose();
            return default;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static T InnerFirstOrDefault<T, TEnumerator, TFunc>(ref TEnumerator enumerator, ref TFunc predicate)
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
            return default;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstOrDefault<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : IStructEnumerable<T, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return InnerFirstOrDefault<T, TEnumerator>(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstOrDefault<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return InnerFirstOrDefault<T, TEnumerator>(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstOrDefault<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<T, bool> predicate, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : IStructEnumerable<T, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return InnerFirstOrDefault(ref enumerator, predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstOrDefault<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, Func<T, bool> predicate)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return InnerFirstOrDefault(ref enumerator, predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FirstOrDefault<T, TEnumerable, TEnumerator, TFunc>(this TEnumerable enumerable, ref TFunc predicate, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : IStructEnumerable<T, TEnumerator>
            where TFunc : struct, IFunction<T, bool>
        {
            var enumerator = enumerable.GetEnumerator();
            return InnerFirstOrDefault<T, TEnumerator, TFunc>(ref enumerator, ref predicate);
        }
    }
}