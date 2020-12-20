using System.Runtime.CompilerServices;
using StructLinq.Utils.Collections;

namespace StructLinq.Reverse
{
    public struct ReverseEnumerator<T> : IStructEnumerator<T>
    {
        private PooledList<T> list;
        private int index;

        internal ReverseEnumerator(PooledList<T> list)
        {
            this.list = list;
            index = list.Size;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            return --index >= 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            index = list.Size;
        }

        public T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => list.Items[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            list.Dispose();
        }
    }

    public struct ReverseEnumerator<T, TStructCollection, TEnumerator> : ICollectionEnumerator<T>
        where TStructCollection : IStructCollection<T, TEnumerator> 
        where TEnumerator : struct, ICollectionEnumerator<T>
    {
        private readonly TStructCollection structCollection;
        private readonly int endIndex;
        private readonly int start;
        private readonly int offset;
        private int index;

        public ReverseEnumerator(TStructCollection structCollection, int start, int length)
        {
            this.structCollection = structCollection;
            endIndex = length - 1 + start;
            this.start = start;
            index = start - 1;
            offset = structCollection.Count - 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            return ++index <= endIndex;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            index = start - 1;
        }
        public T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => structCollection.Get(offset - index);
        }
    }
}
