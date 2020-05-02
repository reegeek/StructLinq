namespace StructLinq
{
    public interface IInFunction<TIn, out TOut>
    {
        TOut Eval(in TIn element);
    }
}