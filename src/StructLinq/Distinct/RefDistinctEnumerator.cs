using System.Buffers;
using System.Runtime.CompilerServices;
using StructLinq.Utils.Collections;

namespace StructLinq.Distinct
{
    public struct RefDistinctEnumerator<T, TEnumerator, TComparer> : IRefStructEnumerator<T>
        where TEnumerator : struct, IRefStructEnumerator<T>
        where TComparer : IInEqualityComparer<T>
    {
        private TEnumerator enumerator;
        private InPooledSet<T, TComparer> set;
        public RefDistinctEnumerator(ref TEnumerator enumerator, int capacity, ArrayPool<int> bucketPool, ArrayPool<Slot<T>> slotPool, TComparer comparer)
        {
            this.enumerator = enumerator;
            set = new InPooledSet<T, TComparer>(capacity, bucketPool, slotPool, comparer);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                if (set.AddIfNotPresent(in current))
                    return true;
            }
            return false;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            enumerator.Reset();
            set.Clear();
        }

        public ref T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => ref enumerator.Current;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            set.Dispose();
        }
    }
}
