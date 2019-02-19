using System.Collections;
using System.Collections.Generic;

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
        public bool MoveNext()
        {
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                if (predicate.Eval(current))
                {
                    Current = current;
                    return true;
                }
            }

            return false;
        }
        public void Reset()
        {
            enumerator.Reset();
        }
        object IEnumerator.Current => Current;
        public void Dispose()
        {
            enumerator.Dispose();
        }
        public TIn Current { get; private set; }
    }
}