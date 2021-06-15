using System.Runtime.CompilerServices;

namespace StructLinq.SelectMany
{
    public readonly struct SelectManyEnumerable<TSource, TSourceEnumerable, TSourceEnumerator, TResult, TResultEnumerable, TResultEnumerator, TFunction> : IStructEnumerable<TResult, SelectManyEnumerator<TSource, TSourceEnumerator, TResult, TResultEnumerable, TResultEnumerator, TFunction>>
        where TSourceEnumerable : IStructEnumerable<TSource, TSourceEnumerator>
        where TSourceEnumerator : struct, IStructEnumerator<TSource>
        where TResultEnumerable : IStructEnumerable<TResult, TResultEnumerator>
        where TResultEnumerator : struct, IStructEnumerator<TResult>
        where TFunction : IFunction<TSource, TResultEnumerable>
    {
        private readonly TSourceEnumerable enumerable;
        private readonly TFunction function;

        public SelectManyEnumerable(TSourceEnumerable enumerable, TFunction function)
        {
            this.enumerable = enumerable;
            this.function = function;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public SelectManyEnumerator<TSource, TSourceEnumerator, TResult, TResultEnumerable, TResultEnumerator, TFunction> GetEnumerator()
        {
            return new (enumerable.GetEnumerator(), function);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor) where TVisitor : IVisitor<TResult>
        {
            foreach (var source in enumerable)
            {
                var resultEnumerable = function.Eval(source);
                var status = resultEnumerable.Visit(ref visitor);
                if (status == VisitStatus.VisitorFinished)
                    return VisitStatus.VisitorFinished;
            }

            return VisitStatus.EnumeratorFinished;
        }
    }
}
