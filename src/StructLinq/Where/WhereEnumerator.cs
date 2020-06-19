using System.Runtime.CompilerServices;

namespace StructLinq.Where
{
    public struct WhereEnumerator<TIn, TEnumerator, TFunction> : IStructEnumerator<TIn>
        where TFunction : struct, IFunction<TIn, bool>
        where TEnumerator : struct, IStructEnumerator<TIn>
    {
        #region private fields
        private TFunction predicate;
        private TEnumerator enumerator;
        #endregion
        public WhereEnumerator(ref TFunction predicate, ref TEnumerator enumerator)
        {
            this.predicate = predicate;
            this.enumerator = enumerator;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                if (!predicate.Eval(current))
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
        public readonly TIn Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => enumerator.Current; 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            enumerator.Dispose();
        }

    }
}