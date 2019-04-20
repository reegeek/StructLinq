using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StructLinq.Where
{
    public struct WhereEnumerator<TIn, TEnumerator, TFunction> : IEnumerator<TIn>
        where TFunction : IFunction<TIn, bool>
        where TEnumerator : IEnumerator<TIn>
    {
        #region private fields
        private TFunction predicate;
        private TEnumerator enumerator;
        #endregion
        public WhereEnumerator(ref TFunction predicate, ref TEnumerator enumerator) : this()
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
                Current = current;
                return true;
            }

            return false;
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
        public TIn Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get;
            private set;
        }
    }
}