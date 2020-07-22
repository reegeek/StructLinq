using System.Runtime.CompilerServices;

namespace StructLinq.Repeat
{
    public struct RepeatEnumerator<T> : IStructEnumerator<T>
    {
        private readonly T element;
        private readonly uint count;
        private uint index;
        public RepeatEnumerator(T element, uint count)
        {
            this.element = element;
            this.count = count;
            index = 0;
        }

        public void Dispose()
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            return index++ < count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            index = 0;
        }

        public T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => element;
        }
    }
}
