using System.Runtime.CompilerServices;

namespace StructLinq.Take
{
    public struct RefTakeEnumerator<T, TEnumerator> : IRefStructEnumerator<T>
        where TEnumerator : struct, IRefStructEnumerator<T>
    {
        private TEnumerator enumerator;
        private readonly int endIndex;
        private int index;
        public RefTakeEnumerator(ref TEnumerator enumerator, uint length)
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

        public ref T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => ref enumerator.Current;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            enumerator.Dispose();
        }
    }
}
