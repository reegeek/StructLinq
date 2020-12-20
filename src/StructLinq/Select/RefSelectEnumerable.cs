using System.Runtime.CompilerServices;

namespace StructLinq.Select
{
    public struct RefSelectEnumerable<TIn, TOut, TEnumerable, TEnumerator, TFunction> : IStructEnumerable<TOut, RefSelectEnumerator<TIn, TOut, TEnumerator, TFunction>>
        where TFunction : struct, IInFunction<TIn, TOut>
        where TEnumerator : struct, IRefCollectionEnumerator<TIn>
        where TEnumerable : IRefStructEnumerable<TIn, TEnumerator>
    {
        #region private fields
        private TFunction function;
        private TEnumerable inner;
        #endregion

        public RefSelectEnumerable(ref TFunction function, ref TEnumerable inner)
        {
            this.function = function;
            this.inner = inner;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefSelectEnumerator<TIn, TOut, TEnumerator, TFunction> GetEnumerator()
        {
            var typedEnumerator = inner.GetEnumerator();
            return new RefSelectEnumerator<TIn, TOut, TEnumerator, TFunction>(ref function, ref typedEnumerator);
        }
    }
}