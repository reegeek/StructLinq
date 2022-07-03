

// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct RefStructEnumerable<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static int RefIntCount(ref TEnumerator enumerator)
        {
            int count = 0;
            while (enumerator.MoveNext())
            {
                count++;
            }
            return count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Count()
        {
            var structEnumerator = enumerable.GetEnumerator();
            return RefIntCount(ref structEnumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public int Count(Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
        {
            var enumerator = enumerable.GetEnumerator();
            return RefIntCount(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static long RefLongCount(ref TEnumerator enumerator)
        {
            long count = 0;
            while (enumerator.MoveNext())
            {
                count++;
            }
            return count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long LongCount()
        {
            var structEnumerator = enumerable.GetEnumerator();
            return RefLongCount(ref structEnumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public long LongCount(Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
        {
            var enumerator = enumerable.GetEnumerator();
            return RefLongCount(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static uint RefUintCount(ref TEnumerator enumerator)
        {
            uint count = 0;
            while (enumerator.MoveNext())
            {
                count++;
            }
            return count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint UIntCount()
        {
            var structEnumerator = enumerable.GetEnumerator();
            return RefUintCount(ref structEnumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public uint UIntCount(Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
        {
            var enumerator = enumerable.GetEnumerator();
            return RefUintCount(ref enumerator);
        }

    }
}
