using System.Runtime.CompilerServices;

namespace StructLinq.SkipWhile
{
    public struct SkipWhileEnumerator<T, TFunction, TEnumerator> : IStructEnumerator<T>
        where TFunction : struct, IFunction<T, bool>
        where TEnumerator : struct, IStructEnumerator<T>

    {
        private bool skipDone;
        private TFunction predicate;
        private TEnumerator enumerator;

        public SkipWhileEnumerator(TFunction predicate, TEnumerator enumerator)
        {
            skipDone = false;
            this.predicate = predicate;
            this.enumerator = enumerator;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            enumerator.Dispose();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            if (skipDone)
                return enumerator.MoveNext();

            while (enumerator.MoveNext())
            {
                var element = enumerator.Current;
                if (predicate.Eval(element))
                    continue;
                skipDone = true;
                return true;
            }
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            enumerator.Reset();
        }

        public T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => enumerator.Current;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<T>
        {
            var selector = new SkipeWhileVisitor<TVisitor>(predicate, ref visitor);
            var visitStatus = enumerator.Visit(ref selector);
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
