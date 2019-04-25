namespace StructLinq
{
    public interface IFunction<TIn, out TOut>
    {
        TOut Eval(in TIn element);
    }
}