using System.Runtime.CompilerServices;

namespace StructLinq.TakeWhile
{
    public readonly struct TakeWhileEnumerable<T, TFunction, TEnumerable, TEnumerator> : IStructEnumerable<T, TakeWhileEnumerator<T, TFunction, TEnumerator>>
        where TFunction : struct, IFunction<T, bool>
        where TEnumerator : struct, IStructEnumerator<T>
        where TEnumerable : IStructEnumerable<T, TEnumerator>
    {
        private readonly TEnumerable enumerable;
        private readonly TFunction predicate;

        public TakeWhileEnumerable(TEnumerable enumerable, TFunction predicate)
        {
            this.enumerable = enumerable;
            this.predicate = predicate;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TakeWhileEnumerator<T, TFunction, TEnumerator> GetEnumerator()
        {
            return new(predicate, enumerable.GetEnumerator());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<T>
        {
            var selector = new TakeWhileVisitor<TVisitor>(predicate, ref visitor);
            var visitStatus = enumerable.Visit(ref selector);
            visitor = selector.visitor;
            return visitStatus;
        }

        private struct TakeWhileVisitor<TVisitor> : IVisitor<T>
            where TVisitor : IVisitor<T>
        {
            public TVisitor visitor;
            private TFunction predicate;

            public TakeWhileVisitor(TFunction predicate, ref TVisitor visitor)
            {
                this.visitor = visitor;
                this.predicate = predicate;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(T input)
            {
                return predicate.Eval(input) && visitor.Visit(input);
            }
        }
    }
}
