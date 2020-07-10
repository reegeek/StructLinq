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
}
