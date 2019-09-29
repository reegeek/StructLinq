using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StructLinq.Where
{
    public struct WhereEnumerator<TIn, TEnumerator, TFunction> : IEnumerator<TIn>
        where TFunction : struct, IFunction<TIn, bool>
        where TEnumerator : struct, IEnumerator<TIn>
    {
        #region private fields
        private readonly TFunction predicate;
        private TEnumerator enumerator;
        #endregion
        public WhereEnumerator(in TFunction predicate, in TEnumerator enumerator) : this()
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
        readonly object IEnumerator.Current => Current;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            enumerator.Dispose();
        }
        public readonly TIn Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => enumerator.Current; 
        }
    }
}