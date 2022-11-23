using System.Linq;
using System.Runtime.CompilerServices;

namespace StructLinq.TakeWhile
{
    public struct TakeWhileEnumerator<T, TFunction, TEnumerator> : IStructEnumerator<T>
        where TFunction : struct, IFunction<T, bool>
        where TEnumerator : struct, IStructEnumerator<T>

    {
        private TFunction predicate;
        private TEnumerator enumerator;

        public TakeWhileEnumerator(TFunction predicate, TEnumerator enumerator)
        {
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
            while (enumerator.MoveNext())
            {
                var element = enumerator.Current;
                return predicate.Eval(element);
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
            var selector = new TakeWhileVisitor<TVisitor>(predicate, ref visitor);
            var visitStatus = enumerator.Visit(ref selector);
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
