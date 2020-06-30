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

        public bool MoveNext()
        {
            return index++ < count;
        }

        public void Reset()
        {
            index = 0;
        }

        public T Current => element;
    }
}
