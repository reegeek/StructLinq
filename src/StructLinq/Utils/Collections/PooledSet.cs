using System;
using System.Buffers;
using System.Collections.Generic;

namespace StructLinq.Utils.Collections
{
    internal struct PooledSet<T, TComparer> where TComparer : IEqualityComparer<T>, IDisposable
    {
        private const int Lower31BitMask = 0x7FFFFFFF;

        private readonly ArrayPool<int> bucketPool;
        private readonly ArrayPool<Slot> slotPool;
        private readonly TComparer comparer;

        private int[] buckets;
        private Slot[] slots;
        private int size;

        private int count;
        private int lastIndex;
        private int freeList;


        public PooledSet(int capacity, ArrayPool<int> bucketPool, ArrayPool<Slot> slotPool, TComparer comparer)
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
            freeList = -1;
        }

        private int InternalGetHashCode(T item)
        {
            if (item == null)
            {
                return 0;
            }
            return comparer.GetHashCode(item) & Lower31BitMask;
        }

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
            Slot[] newSlots;
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


        public void Add(T value)
        {
            int hashCode = InternalGetHashCode(value);
            int bucket = hashCode % size;
            int collisionCount = 0;
            Slot[] tmpSlots = slots;
            for (int i = buckets[bucket] - 1; i >= 0; )
            {
                ref var slot = ref tmpSlots[i];
                if (slot.hashCode == hashCode && comparer.Equals(slot.value, value))
                    return;

                if (collisionCount >= size)
                {
                    // The chain of entries forms a loop, which means a concurrent update has happened.
                    throw new InvalidOperationException("Concurrent operations are not supported.");
                }
                collisionCount++;
                i = slot.next;
            }

            int index;
            if (freeList >= 0)
            {
                index = freeList;
                ref var slot = ref tmpSlots[index];
                freeList = slot.next;
            }
            else
            {
                if (lastIndex == size)
                {
                    IncreaseCapacity();
                    // this will change during resize
                    tmpSlots = slots;
                    bucket = hashCode % size;
                }
                index = lastIndex;
                lastIndex++;
            }

            ref var slot1 = ref tmpSlots[index];
            slot1.hashCode = hashCode;
            slot1.value = value;
            slot1.next = buckets[bucket] - 1;
            buckets[bucket] = index + 1;
            count++;
        }


        public void Dispose()
        {
            ReturnArrays();
            size = 0;
            lastIndex = 0;
            count = 0;
            freeList = -1;
        }

        internal struct Slot
        {
            internal int hashCode;      // Lower 31 bits of hash code, -1 if unused
            internal int next;          // Index of next entry, -1 if last
            internal T value;
        }

    }
}
