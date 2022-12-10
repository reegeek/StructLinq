

// ReSharper disable once CheckNamespace

using System.Runtime.CompilerServices;
using System;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct RefStructEnum<T, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Count()
        {
            int count = 0;
            var copy = enumerator; 
            while (copy.MoveNext())
            {
                count++;
            }
            copy.Dispose();
            return count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public int Count(Func<TEnumerator, IRefStructEnumerator<T>> _)
        {
            int count = 0;
            var copy = enumerator; 
            while (copy.MoveNext())
            {
                count++;
            }
            copy.Dispose();
            return count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long LongCount()
        {
            long count = 0;
            var copy = enumerator; 
            while (copy.MoveNext())
            {
                count++;
            }
            copy.Dispose();
            return count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public long LongCount(Func<TEnumerator, IRefStructEnumerator<T>> _)
        {
            long count = 0;
            var copy = enumerator; 
            while (copy.MoveNext())
            {
                count++;
            }
            copy.Dispose();
            return count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint UIntCount()
        {
            uint count = 0;
            var copy = enumerator; 
            while (copy.MoveNext())
            {
                count++;
            }
            copy.Dispose();
            return count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public uint UIntCount(Func<TEnumerator, IRefStructEnumerator<T>> _)
        {
            uint count = 0;
            var copy = enumerator; 
            while (copy.MoveNext())
            {
                count++;
            }
            copy.Dispose();
            return count;
        }

    }
}
