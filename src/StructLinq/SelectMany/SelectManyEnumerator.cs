using System.Runtime.CompilerServices;

namespace StructLinq.SelectMany
{
    public struct SelectManyEnumerator<TSource, TSourceEnumerator, TResult, TResultEnumerable, TResultEnumerator, TFunction> : IStructEnumerator<TResult>
        where TSourceEnumerator : struct, IStructEnumerator<TSource>
        where TResultEnumerator : struct, IStructEnumerator<TResult>
        where TResultEnumerable : IStructEnumerable<TResult, TResultEnumerator>
        where TFunction : IFunction<TSource, TResultEnumerable>
    {
        private TSourceEnumerator enumerator1;
        private TFunction function;
        private bool hasCurrent;
        private TResultEnumerator currentEnumerator;

        public SelectManyEnumerator(TSourceEnumerator enumerator1, TFunction function)
        {
            this.enumerator1 = enumerator1;
            this.function = function;
            currentEnumerator = new TResultEnumerator();
            hasCurrent = false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            if (hasCurrent)
                currentEnumerator.Dispose();
            enumerator1.Dispose();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            if (hasCurrent)
            {
                var moveNext = currentEnumerator.MoveNext();
                if (moveNext)
                    return true;
            }

            while (true)
            {
                if (!enumerator1.MoveNext())
                {
                    hasCurrent = false;
                    return false;
                }
                currentEnumerator = function.Eval(enumerator1.Current).GetEnumerator();
                if (!currentEnumerator.MoveNext())
                    continue;
                hasCurrent = true;
                return true;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            if (hasCurrent)
            {
                currentEnumerator.Reset();
                hasCurrent = false;
            }
            enumerator1.Reset();
        }

        public TResult Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => currentEnumerator.Current;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor) where TVisitor : IVisitor<TResult>
        {
            while (enumerator1.MoveNext())
            {
                var source = enumerator1.Current;
                var resultEnumerable = function.Eval(source);
                var status = resultEnumerable.Visit(ref visitor);
                if (status == VisitStatus.VisitorFinished)
                    return VisitStatus.VisitorFinished;
            }

            enumerator1.Reset();

            return VisitStatus.EnumeratorFinished;
        }
    }
}