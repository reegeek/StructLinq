using System.Collections;
using System.Runtime.CompilerServices;

namespace StructLinq.Select
{
    public struct SelectEnumerator<TIn, TOut, TEnumerator, TFunction> : IStructEnumerator<TOut>
        where TFunction : struct, IFunction<TIn, TOut>
        where TEnumerator : struct, IStructEnumerator<TIn>
    {
        #region private fields
        private readonly TFunction function;
        private TEnumerator enumerator;
        #endregion
        public SelectEnumerator(in TFunction function,in TEnumerator enumerator)
        {
            this.function = function;
            this.enumerator = enumerator;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            return enumerator.MoveNext();
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            enumerator.Reset();
        }
        public readonly TOut Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => function.Eval(enumerator.Current);
        }
}
}