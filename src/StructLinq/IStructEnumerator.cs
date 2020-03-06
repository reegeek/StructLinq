namespace StructLinq
{
    public interface IStructEnumerator<out T>
    {
        bool MoveNext();
        
        void Reset();
        
        T Current { get; }
    }
}
