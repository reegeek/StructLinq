using System.Runtime.CompilerServices;
using StructLinq.Select;

namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Count<TIn, TOut, TEnumerable, TEnumerator, TFunction>(this SelectEnumerable<TIn, TOut, TEnumerable, TEnumerator, TFunction> selectEnumerable)
            where TEnumerator : struct, IStructEnumerator<TIn>
            where TFunction : struct, IFunction<TIn, TOut>
            where TEnumerable : IStructEnumerable<TIn, TEnumerator>

        {
            return selectEnumerable.Inner.Count(x=>x);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Count<TIn, TOut, TEnumerable, TEnumerator, TFunction>(this RefSelectEnumerable<TIn, TOut, TEnumerable, TEnumerator, TFunction> selectEnumerable)
            where TEnumerator : struct, IRefStructEnumerator<TIn>
            where TFunction : struct, IInFunction<TIn, TOut>
            where TEnumerable : IRefStructEnumerable<TIn, TEnumerator>

        {
            return selectEnumerable.Inner.Count(x=>x);
        }

    }
}
