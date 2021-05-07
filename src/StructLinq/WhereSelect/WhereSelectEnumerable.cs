using System;
using System.Runtime.CompilerServices;
using StructLinq.Where;

namespace StructLinq.WhereSelect
{
    public struct WhereSelectEnumerable<TIn, TOut, TEnumerable, TEnumerator, TPredicate, TFunction> : IStructEnumerable<TOut, WhereSelectEnumerator<TIn, TOut, TEnumerator, TPredicate, TFunction>>
        where TEnumerator : struct, IStructEnumerator<TIn> 
        where TPredicate : struct, IFunction<TIn, bool>
        where TFunction : struct, IFunction<TIn, TOut>
        where TEnumerable : IStructEnumerable<TIn, TEnumerator>
    {
        private TFunction function;
        private WhereEnumerable<TIn, TEnumerable, TEnumerator, TPredicate> whereEnumerable;
        public WhereSelectEnumerable(ref TFunction function, ref WhereEnumerable<TIn, TEnumerable, TEnumerator, TPredicate> whereEnumerable)
        {
            this.function = function;
            this.whereEnumerable = whereEnumerable;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public WhereSelectEnumerator<TIn, TOut, TEnumerator, TPredicate, TFunction> GetEnumerator()
        {
            var enumerator = whereEnumerable.Inner.GetEnumerator();
            var predicate = whereEnumerable.Function;
            return new WhereSelectEnumerator<TIn, TOut, TEnumerator, TPredicate, TFunction>(ref predicate, ref function, ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<TOut>
        {
            var predicate = whereEnumerable.Function;
            var whereSelectVisitor = new WhereSelectVisitor<TVisitor>(ref predicate, ref function, ref visitor);
            var visitStatus = whereEnumerable.Inner.Visit(ref whereSelectVisitor);
            visitor = whereSelectVisitor.Visitor;
            return visitStatus;
        }

        private struct WhereSelectVisitor<TVisitor> : IVisitor<TIn>
            where TVisitor : IVisitor<TOut>
        {
            private TPredicate predicate;
            private TFunction function;
            public TVisitor Visitor;
            public WhereSelectVisitor(ref TPredicate predicate, ref TFunction function, ref TVisitor visitor)
            {
                this.predicate = predicate;
                Visitor = visitor;
                this.function = function;
            }
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(TIn input)
            {
                if (predicate.Eval(input))
                    return Visitor.Visit(function.Eval(input));
                return true;
            }
        }
    }
    
    public struct WhereSelectEnumerable<TIn, TOut, TEnumerable, TEnumerator> : IStructEnumerable<TOut, WhereSelectEnumerator<TIn, TOut, TEnumerator>>
        where TEnumerator : struct, IStructEnumerator<TIn> 
        where TEnumerable : IWhereEnumerable<TIn, TEnumerator>
    {
        private Func<TIn, TOut> function;
        private TEnumerable whereEnumerable;
        public WhereSelectEnumerable(Func<TIn, TOut> function, ref TEnumerable whereEnumerable)
        {
            this.function = function;
            this.whereEnumerable = whereEnumerable;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public WhereSelectEnumerator<TIn, TOut, TEnumerator> GetEnumerator()
        {
            var enumerator = whereEnumerable.GetInnerEnumerator();
            var predicate = whereEnumerable.Function;
            return new WhereSelectEnumerator<TIn, TOut, TEnumerator>(predicate, function, ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<TOut>
        {
            var predicate = whereEnumerable.Function;
            var whereSelectVisitor = new WhereSelectVisitor<TVisitor>(predicate, function, ref visitor);
            var visitStatus = whereEnumerable.InnerVisit(ref whereSelectVisitor);
            visitor = whereSelectVisitor.Visitor;
            return visitStatus;
        }

        private struct WhereSelectVisitor<TVisitor> : IVisitor<TIn>
            where TVisitor : IVisitor<TOut>
        {
            private Func<TIn, bool> predicate;
            private Func<TIn, TOut> function;
            public TVisitor Visitor;
            public WhereSelectVisitor(Func<TIn, bool> predicate, Func<TIn, TOut> function, ref TVisitor visitor)
            {
                this.predicate = predicate;
                Visitor = visitor;
                this.function = function;
            }
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(TIn input)
            {
                return !predicate(input) || Visitor.Visit(function(input));
            }
        }
    }
}
