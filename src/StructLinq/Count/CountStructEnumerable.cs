

// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

namespace StructLinq
{
    public static partial class StructEnumerable
    {
        private static int IntCount<T,TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            int count = 0;
            while (enumerator.MoveNext())
            {
                count++;
            }
            return count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Count<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable) 
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var structEnumerator = enumerable.GetEnumerator();
            return IntCount<T, TEnumerator>(ref structEnumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Count<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return IntCount<T, TEnumerator>(ref enumerator);
        }

        private static long LongCount<T, TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            long count = 0;
            while (enumerator.MoveNext())
            {
                count++;
            }
            return count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long LongCount<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var structEnumerator = enumerable.GetEnumerator();
            return LongCount<T, TEnumerator>(ref structEnumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long LongCount<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return LongCount<T, TEnumerator>(ref enumerator);
        }

        private static uint UintCount<T, TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            uint count = 0;
            while (enumerator.MoveNext())
            {
                count++;
            }
            return count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint UIntCount<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var structEnumerator = enumerable.GetEnumerator();
            return UintCount<T, TEnumerator>(ref structEnumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint UIntCount<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return UintCount<T, TEnumerator>(ref enumerator);
        }


    }
}
