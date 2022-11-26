namespace StructLinq
{
    public readonly partial struct RefStructEnum<T, TEnumerator>
        where TEnumerator : struct, IRefStructEnumerator<T>
    {
        private readonly TEnumerator enumerator;

        public RefStructEnum(TEnumerator enumerator)
        {
            this.enumerator = enumerator;
        }

        public TEnumerator GetEnumerator() => enumerator;
    }

    public interface IRefStructEnumerable<out T, out TEnumerator>
        where TEnumerator : struct, IRefStructEnumerator<T>
    {
        TEnumerator GetEnumerator();
    }
}