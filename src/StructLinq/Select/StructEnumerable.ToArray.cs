using System.Buffers;
using StructLinq.Select;

namespace StructLinq
{
    public static partial class StructEnumerable
    {
        public static TOut[] ToArray<TIn, TOut, TEnumerable, TEnumerator, TFunction>(this SelectEnumerable<TIn, TOut, TEnumerable, TEnumerator, TFunction> selectEnumerable)
            where TEnumerator : struct, IStructEnumerator<TIn>
            where TFunction : struct, IFunction<TIn, TOut>
            where TEnumerable : IStructCollection<TIn, TEnumerator>
        {
            return selectEnumerable.ToArray(selectEnumerable.Inner.Count, ArrayPool<TOut>.Shared, x => x);
        }

        public static TOut[] ToArray<TIn, TOut, TEnumerable, TEnumerator, TFunction>(this RefSelectEnumerable<TIn, TOut, TEnumerable, TEnumerator, TFunction> selectEnumerable)
            where TEnumerator : struct, IRefStructEnumerator<TIn>
            where TFunction : struct, IInFunction<TIn, TOut>
            where TEnumerable : IRefStructCollection<TIn, TEnumerator>
        {
            return selectEnumerable.ToArray(selectEnumerable.Inner.Count, ArrayPool<TOut>.Shared, x => x);
        }
    }
}
