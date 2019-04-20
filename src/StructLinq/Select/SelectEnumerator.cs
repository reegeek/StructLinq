using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StructLinq.Select
{
    public struct SelectEnumerator<TIn, TOut, TEnumerator, TFunction> : IEnumerator<TOut>
        where TFunction : struct, IFunction<TIn, TOut>
        where TEnumerator : IEnumerator<TIn>
    {
        #region private fields
        private TFunction function;
        private TEnumerator enumerator;
        #endregion
        public SelectEnumerator(ref TFunction function, ref TEnumerator enumerator)
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
        object IEnumerator.Current => Current;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            enumerator.Dispose();
        }
        public TOut Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => function.Eval(enumerator.Current);
        }
}
}