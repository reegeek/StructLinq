using StructLinq.Select;

namespace StructLinq
{
    public static partial class StructEnumerable
    {
        public static int Count<TIn, TOut, TEnumerable, TEnumerator, TFunction>(this SelectEnumerable<TIn, TOut, TEnumerable, TEnumerator, TFunction> selectEnumerable)
            where TEnumerator : struct, IStructEnumerator<TIn>
            where TFunction : struct, IFunction<TIn, TOut>
            where TEnumerable : IStructEnumerable<TIn, TEnumerator>

        {
            return selectEnumerable.Inner.Count(x=>x);
        }
    }
}
