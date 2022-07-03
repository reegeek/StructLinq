// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct StructEnumerable<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool TryInnerElementAt(ref TEnumerator enumerator, ref T elementAt, int index)
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
        private T InnerElementAt(ref TEnumerator enumerator, int index)
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
        [Obsolete("Remove last argument")]
        public T ElementAt(int index, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
        {
            var enumerator = enumerable.GetEnumerator();
            return InnerElementAt(ref enumerator, index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T ElementAt(int index)
        {
            var enumerator = enumerable.GetEnumerator();
            return InnerElementAt(ref enumerator, index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool TryElementAt(ref T elementAt, int index, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
        {
            var enumerator = enumerable.GetEnumerator();
            return TryInnerElementAt(ref enumerator, ref elementAt, index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryElementAt(ref T elementAt, int index)
        {
            var enumerator = enumerable.GetEnumerator();
            return TryInnerElementAt(ref enumerator, ref elementAt, index);
        }
    }

}