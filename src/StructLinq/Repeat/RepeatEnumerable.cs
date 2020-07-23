namespace StructLinq.Repeat
{
    public readonly struct RepeatEnumerable<T> : IStructCollection<T, RepeatEnumerator<T>>
    {
        private readonly T element;
        private readonly uint count;

        public RepeatEnumerable(T element, uint count)
        {
            this.element = element;
            this.count = count;
        }

        public RepeatEnumerator<T> GetEnumerator()
        {
            return new RepeatEnumerator<T>(element, count);
        }

        public int Count => (int)count;
    }
}
