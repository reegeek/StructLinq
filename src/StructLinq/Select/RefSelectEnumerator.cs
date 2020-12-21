using System.Runtime.CompilerServices;

namespace StructLinq.Select
{
    public struct RefSelectEnumerator<TIn, TOut, TEnumerator, TFunction> : ICollectionEnumerator<TOut>
        where TFunction : struct, IInFunction<TIn, TOut>
        where TEnumerator : struct, IRefCollectionEnumerator<TIn>
    {
        #region private fields
        private TFunction function;
        private TEnumerator enumerator;
        #endregion
        public RefSelectEnumerator(ref TFunction function, ref TEnumerator enumerator)
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
        public TOut Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ref var enumeratorCurrent = ref enumerator.Current;
                return function.Eval(in enumeratorCurrent);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            enumerator.Dispose();
        }

        public int Count
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => enumerator.Count;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TOut Get(int i)
        {
            var element = enumerator.Get(i);
            return function.Eval(element);
        }
    }
}