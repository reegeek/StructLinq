namespace StructLinq
{
    public interface IAction<in T>
    {
        void Do(T element);
    }
}