// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct RefStructEnumerable<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool RefTryInnerElementAt(ref TEnumerator enumerator, ref T elementAt, int index)
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
        private static T RefInnerElementAt(ref TEnumerator enumerator, int index)
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
        [Obsolete("Remove last argument")]
        public T ElementAt(int index, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
        {
            var enumerator = enumerable.GetEnumerator();
            return RefInnerElementAt(ref enumerator, index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T ElementAt(int index)
        {
            var enumerator = enumerable.GetEnumerator();
            return RefInnerElementAt(ref enumerator, index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool TryElementAt(ref T elementAt, int index, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
        {
            var enumerator = enumerable.GetEnumerator();
            return RefTryInnerElementAt(ref enumerator, ref elementAt, index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryElementAt(ref T elementAt, int index)
        {
            var enumerator = enumerable.GetEnumerator();
            return RefTryInnerElementAt(ref enumerator, ref elementAt, index);
        }
    }
}