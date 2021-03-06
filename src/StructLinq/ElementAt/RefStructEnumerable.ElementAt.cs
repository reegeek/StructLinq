﻿// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool RefTryInnerElementAt<T, TEnumerator>(ref TEnumerator enumerator, ref T elementAt, int index)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            if (index < 0)
                return false;

            while (true)
            {
                if (!enumerator.MoveNext())
                {
                    enumerator.Dispose();
                    return false;
                }
                if (index == 0)
                {
                    elementAt = ref enumerator.Current;
                    enumerator.Dispose();
                    return true;
                }
                index--;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static T RefInnerElementAt<T, TEnumerator>(ref TEnumerator enumerator, int index)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {

            if (index < 0)
                throw new ArgumentOutOfRangeException("index");
            while (true)
            {
                if (!enumerator.MoveNext())
                {
                    enumerator.Dispose();
                    throw new ArgumentOutOfRangeException("index");
                }
                if (index == 0)
                {
                    ref var innerElementAt = ref enumerator.Current;
                    enumerator.Dispose();
                    return innerElementAt;
                }
                index--;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ElementAt<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, int index, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TEnumerable : IRefStructEnumerable<T, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefInnerElementAt<T, TEnumerator>(ref enumerator, index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ElementAt<T, TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, int index)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefInnerElementAt<T, TEnumerator>(ref enumerator, index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryElementAt<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, ref T elementAt, int index, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TEnumerable : IRefStructEnumerable<T, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefTryInnerElementAt(ref enumerator, ref elementAt, index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryElementAt<T, TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, ref T elementAt, int index)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefTryInnerElementAt(ref enumerator, ref elementAt, index);
        }
    }
}