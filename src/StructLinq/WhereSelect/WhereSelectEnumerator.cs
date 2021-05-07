using System;
using System.Runtime.CompilerServices;

namespace StructLinq.WhereSelect
{
    public struct WhereSelectEnumerator<TIn, TOut, TEnumerator, TPredicate, TFunction> : IStructEnumerator<TOut>
        where TPredicate : struct, IFunction<TIn, bool>
        where TFunction : struct, IFunction<TIn, TOut>
        where TEnumerator : struct, IStructEnumerator<TIn>
    {
        #region private fields
        private TPredicate predicate;
        private TFunction function;
        private TEnumerator enumerator;
        #endregion
        public WhereSelectEnumerator(ref TPredicate predicate, ref TFunction function, ref TEnumerator enumerator)
        {
            this.predicate = predicate;
            this.function = function;
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
        public TOut Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => function.Eval(enumerator.Current); 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            enumerator.Dispose();
        }

    }
    
    public struct WhereSelectEnumerator<TIn, TOut, TEnumerator> : IStructEnumerator<TOut>
        where TEnumerator : struct, IStructEnumerator<TIn>
    {
        #region private fields
        private readonly Func<TIn, bool> predicate;
        private readonly Func<TIn, TOut> function;
        private TEnumerator enumerator;
        #endregion
        public WhereSelectEnumerator(Func<TIn, bool> predicate, Func<TIn, TOut> function, ref TEnumerator enumerator)
        {
            this.predicate = predicate;
            this.function = function;
            this.enumerator = enumerator;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                if (!predicate(current))
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
        public readonly TOut Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => function(enumerator.Current); 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            enumerator.Dispose();
        }

    }
    
}