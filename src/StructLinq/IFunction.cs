namespace StructLinq
{
    public interface IFunction<in TIn, out TOut>
    {
        TOut Eval(TIn element);
    }
}