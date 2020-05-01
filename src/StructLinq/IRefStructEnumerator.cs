namespace StructLinq
{
    public interface IRefStructEnumerator<T>
    {
        bool MoveNext();

        void Reset();

        ref T Current { get; }
    }
}