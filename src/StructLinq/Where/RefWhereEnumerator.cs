using System.Runtime.CompilerServices;

namespace StructLinq.Where
{
    public struct RefWhereEnumerator<TIn, TEnumerator, TFunction> : IRefStructEnumerator<TIn>
        where TFunction : struct, IInFunction<TIn, bool>
        where TEnumerator : struct, IRefStructEnumerator<TIn>
    {
        #region private fields
        private TFunction predicate;
        private TEnumerator enumerator;
        #endregion
        public RefWhereEnumerator(ref TFunction predicate, ref TEnumerator enumerator)
        {
            this.predicate = predicate;
            this.enumerator = enumerator;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                if (!predicate.Eval(in current))
                    continue;
                return true;
            }

            return false;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            enumerator.Reset();
        }
        public ref TIn Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => ref enumerator.Current;
        }
    }
}