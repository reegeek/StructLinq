using System.Runtime.CompilerServices;

namespace StructLinq.SkipWhile
{
    public readonly struct SkipWhileEnumerable<T, TFunction, TEnumerable, TEnumerator> : IStructEnumerable<T, SkipWhileEnumerator<T, TFunction, TEnumerator>>
        where TFunction : struct, IFunction<T, bool>
        where TEnumerator : struct, IStructEnumerator<T>
        where TEnumerable : IStructEnumerable<T, TEnumerator>
    {
        private readonly TEnumerable enumerable;
        private readonly TFunction predicate;

        public SkipWhileEnumerable(TEnumerable enumerable, TFunction predicate)
        {
            this.enumerable = enumerable;
            this.predicate = predicate;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public SkipWhileEnumerator<T, TFunction, TEnumerator> GetEnumerator()
        {
            return new(predicate, enumerable.GetEnumerator());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<T>
        {
            var selector = new SkipeWhileVisitor<TVisitor>(predicate, ref visitor);
            var visitStatus = enumerable.Visit(ref selector);
            visitor = selector.visitor;
            return visitStatus;
        }

        private struct SkipeWhileVisitor<TVisitor> : IVisitor<T>
            where TVisitor : IVisitor<T>
        {
            private bool skipDone;
            public TVisitor visitor;
            private TFunction predicate;

            public SkipeWhileVisitor(TFunction predicate, ref TVisitor visitor)
            {
                skipDone = false;
                this.visitor = visitor;
                this.predicate = predicate;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(T input)
            {
                if (skipDone)
                    return visitor.Visit(input);

                if (predicate.Eval(input))
                    return true;

                skipDone = true;
                return visitor.Visit(input);
            }
        }
    }
}
