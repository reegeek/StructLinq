namespace StructLinq
{
    public interface IAggregation<in T, TAccumulate>
    {
        void Aggregate(T element);
        TAccumulate Result { get; set; }
    }
}