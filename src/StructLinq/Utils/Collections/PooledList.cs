using System;
using System.Buffers;
using System.Runtime.CompilerServices;

namespace StructLinq.Utils.Collections
{
    internal struct PooledList<T> : IDisposable
    {
        private static readonly T[] emptyArray = new T[0];

        private readonly ArrayPool<T> pool;
        private int index;

        public PooledList(int capacity, ArrayPool<T> pool)
        {
            this.pool = pool;
            Items = capacity > 0 ? pool.Rent(capacity) : emptyArray;
            index = -1;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void IncreaseCapacity()
        {
            var newItems = pool.Rent(index + 1);
            if (index > 0)
                System.Array.Copy(Items, newItems, index);
            ReturnArray();
            Items = newItems;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void ReturnArray()
        {
            if (Items.Length == 0)
                return;

            try
            {
                // Clear the elements so that the gc can reclaim the references.
                pool.Return(Items);
            }
            catch (ArgumentException)
            {
                // oh well, the array pool didn't like our array
            }

            Items = emptyArray;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Add(T item)
        {
            if (++index >= Items.Length)
                IncreaseCapacity();
            Items[index] = item;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Add(ref T item)
        {
            if (++index >= Items.Length)
                IncreaseCapacity();
            ref var elt = ref Items[index];
            elt = item;
        }


        internal T[] Items;

        internal int Size
        {
            get
            {
                return index + 1;

            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            ReturnArray();
            index = -1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T[] ToArray()
        {
            var result = ArrayHelpers.Create<T>(Size);
            System.Array.Copy(Items, result, Size);
            return result;
        }
    }
}
