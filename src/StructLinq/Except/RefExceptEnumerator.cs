using System.Buffers;
using System.Runtime.CompilerServices;
using StructLinq.Utils.Collections;

namespace StructLinq.Except
{
    public struct RefExceptEnumerator<T, TEnumerator1, TEnumerator2, TComparer> : IRefStructEnumerator<T>
        where TEnumerator1 : struct, IRefStructEnumerator<T>
        where TEnumerator2 : struct, IRefStructEnumerator<T>
        where TComparer : IInEqualityComparer<T>
    {
        private TEnumerator1 enumerator1;
        private TEnumerator2 enumerator2;
        private InPooledSet<T, TComparer> set;

        internal RefExceptEnumerator(ref TEnumerator1 enumerator1, ref TEnumerator2 enumerator2, TComparer comparer, int capacity, ArrayPool<int> bucketPool, ArrayPool<Slot<T>> slotPool)
            : this()
        {
            this.enumerator1 = enumerator1;
            this.enumerator2 = enumerator2;
            this.set = new InPooledSet<T, TComparer>(capacity, bucketPool, slotPool, comparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            set.Dispose();
            enumerator1.Dispose();
            enumerator2.Dispose();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            while (enumerator2.MoveNext())
            {
                ref var current = ref enumerator2.Current;
                set.AddIfNotPresent(in current);
            }

            while (enumerator1.MoveNext())
            {
                ref var current = ref enumerator1.Current;
                if (set.AddIfNotPresent(in current))
                    return true;
            }

            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            set.Clear();
            enumerator1.Reset();
            enumerator2.Reset();
        }

        public ref T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => ref enumerator1.Current;
        }
    }
}
