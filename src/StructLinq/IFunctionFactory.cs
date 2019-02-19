namespace StructLinq
{
    public interface IFunctionFactory<TIn, TOut, out TFunction>
        where TFunction : struct, IFunction<TIn, TOut>
    {
        TFunction Build();
    }
}