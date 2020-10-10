using System;
using System.Buffers;
using System.Runtime.CompilerServices;

namespace StructLinq.Utils.Collections
{
    internal struct InPooledSet<T, TComparer> : IDisposable 
        where TComparer : IInEqualityComparer<T>
    {
        private const int Lower31BitMask = 0x7FFFFFFF;

        private readonly ArrayPool<int> bucketPool;
        private readonly ArrayPool<Slot<T>> slotPool;
        private readonly TComparer comparer;

        private int[] buckets;
        private Slot<T>[] slots;
        private int size;

        private int count;
        private int lastIndex;


        public InPooledSet(int capacity, ArrayPool<int> bucketPool, ArrayPool<Slot<T>> slotPool, TComparer comparer)
        {
            this.bucketPool = bucketPool;
            this.slotPool = slotPool;
            this.comparer = comparer;
            size = HashHelpers.GetPrime(capacity);
            buckets = bucketPool.Rent(size);
            System.Array.Clear(buckets, 0, buckets.Length);
            slots = slotPool.Rent(size);
            count = 0;
            lastIndex = 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private int InternalGetHashCode(in T item)
        {
            if (item == null)
            {
                return 0;
            }
            return comparer.GetHashCode(in item) & Lower31BitMask;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void IncreaseCapacity()
        {
            int newSize = HashHelpers.ExpandPrime(count);
            if (newSize <= count)
            {
                throw new InvalidOperationException("Capacity overflow");
            }

            // Able to increase capacity; copy elements to larger array and rehash
            SetCapacity(newSize);
        }

        private void SetCapacity(int newSize)
        {

            int[] newBuckets;
            Slot<T>[] newSlots;
            bool replaceArrays;

            // Because ArrayPool might have given us larger arrays than we asked for, see if we can 
            // use the existing capacity without actually resizing.
            if (buckets?.Length >= newSize && slots?.Length >= newSize)
            {
                System.Array.Clear(buckets, 0, buckets.Length);
                System.Array.Clear(slots, size, newSize - size);
                newBuckets = buckets;
                newSlots = slots;
                replaceArrays = false;
            }
            else
            {
                newSlots = slotPool.Rent(newSize);
                newBuckets = bucketPool.Rent(newSize);

                System.Array.Clear(newBuckets, 0, newBuckets.Length);
                if (slots != null)
                {
                    System.Array.Copy(slots, 0, newSlots, 0, lastIndex);
                }
                replaceArrays = true;
            }

            for (int i = 0; i < lastIndex; i++)
            {
                ref var newSlot = ref newSlots[i];
                int bucket = newSlot.hashCode % newSize;
                newSlot.next = newBuckets[bucket] - 1;
                newBuckets[bucket] = i + 1;
            }

            if (replaceArrays)
            {
                ReturnArrays();
                slots = newSlots;
                buckets = newBuckets;
            }

            size = newSize;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void ReturnArrays()
        {
            if (slots?.Length > 0)
            {
                try
                {
                    slotPool.Return(slots);
                }
                catch (ArgumentException)
                {
                    // oh well, the array pool didn't like our array
                }
            }

            if (buckets?.Length > 0)
            {
                try
                {
                    bucketPool.Return(buckets);
                }
                catch (ArgumentException)
                {
                    // shucks
                }
            }

            slots = null;
            buckets = null;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool AddIfNotPresent(in T value)
        {
            int hashCode = InternalGetHashCode(in value);
            int bucket = hashCode % size;
            int collisionCount = 0;
            Slot<T>[] tmpSlots = slots;
            for (int i = buckets[bucket] - 1; i >= 0; )
            {
                ref var slot = ref tmpSlots[i];
                if (slot.hashCode == hashCode && comparer.Equals(in slot.value, in value))
                    return false;

                if (collisionCount >= size)
                {
                    // The chain of entries forms a loop, which means a concurrent update has happened.
                    throw new InvalidOperationException("Concurrent operations are not supported.");
                }
                collisionCount++;
                i = slot.next;
            }

            int index;
            if (lastIndex == size)
            {
                IncreaseCapacity();
                // this will change during resize
                tmpSlots = slots;
                bucket = hashCode % size;
            }

            index = lastIndex;
            lastIndex++;

            ref var slot1 = ref tmpSlots[index];
            slot1.hashCode = hashCode;
            slot1.value = value;
            slot1.next = buckets[bucket] - 1;
            buckets[bucket] = index + 1;
            count++;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Remove(in T item)
        {
            int hashCode = InternalGetHashCode(in item);
            int bucket = hashCode % size;
            int last = -1;
            int collisionCount = 0;
            Slot<T>[] tmpSlots = slots;
            for (int i = buckets[bucket] - 1; i >= 0; last = i, i = tmpSlots[i].next)
            {
                ref var tmpSlot = ref tmpSlots[i];
                if (tmpSlot.hashCode == hashCode && comparer.Equals(in tmpSlot.value, in item))
                {
                    if (last < 0)
                    {
                        buckets[bucket] = tmpSlot.next + 1;
                    }
                    else
                    {
                        ref var lastSlot = ref tmpSlots[last];
                        lastSlot.next = tmpSlot.next;
                    }

                    tmpSlot.hashCode = -1;

                    count--;
                    if (count == 0)
                    {
                        lastIndex = 0;
                    }

                    return true;
                }

                if (collisionCount >= size)
                {
                    throw new InvalidOperationException("Concurrent operations are not supported.");
                }
                collisionCount++;
            }
            return false;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Clear()
        {
            if (lastIndex > 0)
            {
                // clear the elements so that the gc can reclaim the references.
                // clear only up to _lastIndex for _slots 
                System.Array.Clear(slots, 0, lastIndex);
                System.Array.Clear(buckets, 0, buckets.Length);
                lastIndex = 0;
                count = 0;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            ReturnArrays();
            size = 0;
            lastIndex = 0;
            count = 0;
        }
    }
}
