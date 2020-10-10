using System.Buffers;
using System.Runtime.CompilerServices;
using StructLinq.Utils.Collections;

namespace StructLinq.Except
{
    public struct RefExceptEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2, TComparer> : IRefStructEnumerable<T, RefExceptEnumerator<T, TEnumerator1, TEnumerator2, TComparer>>
        where TEnumerable1 : IRefStructEnumerable<T, TEnumerator1>
        where TEnumerable2 : IRefStructEnumerable<T, TEnumerator2>
        where TEnumerator1 : struct, IRefStructEnumerator<T>
        where TEnumerator2 : struct, IRefStructEnumerator<T>
        where TComparer : IInEqualityComparer<T>
    {
        private readonly TEnumerable1 enumerable1;
        private readonly TEnumerable2 enumerable2;
        private readonly TComparer comparer;
        private readonly int capacity;
        private readonly ArrayPool<int> bucketPool;
        private readonly ArrayPool<Slot<T>> slotPool;

        internal RefExceptEnumerable(ref TEnumerable1 enumerable1, ref TEnumerable2 enumerable2, TComparer comparer, int capacity,
                                    ArrayPool<int> bucketPool, 
                                    ArrayPool<Slot<T>> slotPool)
        {
            this.enumerable1 = enumerable1;
            this.enumerable2 = enumerable2;
            this.comparer = comparer;
            this.capacity = capacity;
            this.bucketPool = bucketPool;
            this.slotPool = slotPool;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefExceptEnumerator<T, TEnumerator1, TEnumerator2, TComparer> GetEnumerator()
        {
            var enum1 = enumerable1.GetEnumerator();
            var enum2 = enumerable2.GetEnumerator();
            var set = new InPooledSet<T, TComparer>(capacity, bucketPool, slotPool, comparer);
            return new RefExceptEnumerator<T, TEnumerator1, TEnumerator2, TComparer>(ref enum1, ref  enum2, ref set);
        }
    }
}
