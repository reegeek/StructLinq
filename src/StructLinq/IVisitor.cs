namespace StructLinq
{
    public interface IVisitor<in T>
    {
        bool Visit(T input);
    }
}
