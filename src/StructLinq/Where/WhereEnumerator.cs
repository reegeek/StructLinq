using System;
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<TIn>
        {
            var selector = new WhereVisitor<TVisitor>(ref predicate, ref visitor);
            var visitStatus = enumerator.Visit(ref selector);
            visitor = selector.visitor;
            return visitStatus;
        }

        private struct WhereVisitor<TVisitor> : IVisitor<TIn>
            where TVisitor : IVisitor<TIn>
        {
            public TFunction function;
            public TVisitor visitor;
            public WhereVisitor(ref TFunction function, ref TVisitor visitor)
            {
                this.function = function;
                this.visitor = visitor;
            }
            public bool Visit(TIn input)
            {
                if (function.Eval(input))
                    return visitor.Visit(input);
                return true;
            }
        }
    }

    public struct WhereEnumerator<TIn, TEnumerator> : IStructEnumerator<TIn>
        where TEnumerator : struct, IStructEnumerator<TIn>
    {
        #region private fields

        private Func<TIn, bool> predicate;
        private TEnumerator enumerator;

        #endregion

        public WhereEnumerator(Func<TIn, bool> predicate, ref TEnumerator enumerator)
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<TIn>
        {
            var whereVisitor = new WhereVisitor<TIn, TVisitor>(predicate, ref visitor);
            var visitStatus = enumerator.Visit(ref whereVisitor);
            visitor = whereVisitor.visitor;
            return visitStatus;
        }
    }
}
