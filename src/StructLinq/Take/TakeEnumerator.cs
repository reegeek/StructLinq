using System.Runtime.CompilerServices;

namespace StructLinq.Take
{
    public struct TakeEnumerator<T, TEnumerator> : IStructEnumerator<T>
        where TEnumerator : struct, IStructEnumerator<T>
    {
        private TEnumerator enumerator;
        private readonly int endIndex;
        private int index;
        public TakeEnumerator(ref TEnumerator enumerator, uint length)
        {
            this.enumerator = enumerator;
            endIndex = (int)length - 1;
            index = -1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            return enumerator.MoveNext() && ++index <= endIndex;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            enumerator.Reset();
            index = -1;
        }

        public T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => enumerator.Current;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            enumerator.Dispose();
        }
    }
}
