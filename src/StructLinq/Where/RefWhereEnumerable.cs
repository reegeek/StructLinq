using System.Runtime.CompilerServices;

namespace StructLinq.Where
{
    public struct RefWhereEnumerable<TIn, TEnumerable, TEnumerator, TFunction> : IRefStructEnumerable<TIn, RefWhereEnumerator<TIn, TEnumerator, TFunction>>
        where TEnumerator : struct, IRefStructEnumerator<TIn>
        where TFunction : struct, IInFunction<TIn, bool>
        where TEnumerable : IRefStructEnumerable<TIn, TEnumerator>
    {
        private TFunction function;
        private TEnumerable inner;
        public RefWhereEnumerable(ref TFunction function, ref TEnumerable inner)
        {
            this.function = function;
            this.inner = inner;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefWhereEnumerator<TIn, TEnumerator, TFunction> GetEnumerator()
        {
            var enumerator = inner.GetEnumerator();
            return new RefWhereEnumerator<TIn, TEnumerator, TFunction>(ref function, ref enumerator);
        }

    }
}