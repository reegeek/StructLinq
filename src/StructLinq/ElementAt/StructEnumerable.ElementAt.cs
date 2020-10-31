// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool TryInnerElementAt<T, TEnumerator>(ref TEnumerator enumerator, ref T elementAt, int index)
            where TEnumerator : struct, IStructEnumerator<T>
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
                    elementAt = enumerator.Current;
                    enumerator.Dispose();
                    return true;
                }
                index--;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static T InnerElementAt<T, TEnumerator>(ref TEnumerator enumerator, int index)
            where TEnumerator : struct, IStructEnumerator<T>
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
                    var innerElementAt = enumerator.Current;
                    enumerator.Dispose();
                    return innerElementAt;
                }
                index--;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ElementAt<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, int index, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : IStructEnumerable<T, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return InnerElementAt<T, TEnumerator>(ref enumerator, index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ElementAt<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, int index)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return InnerElementAt<T, TEnumerator>(ref enumerator, index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryElementAt<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, ref T elementAt, int index, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : IStructEnumerable<T, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return TryInnerElementAt(ref enumerator, ref elementAt, index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryElementAt<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, ref T elementAt, int index)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return TryInnerElementAt(ref enumerator, ref elementAt, index);
        }
    }
}