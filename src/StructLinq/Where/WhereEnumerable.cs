using System.Runtime.CompilerServices;

namespace StructLinq.Where
{
    public struct WhereEnumerable<TIn, TEnumerable, TEnumerator, TFunction> : IStructEnumerable<TIn, WhereEnumerator<TIn, TEnumerator, TFunction>>
        where TEnumerator : struct, IStructEnumerator<TIn> 
        where TFunction : struct, IFunction<TIn, bool>
        where TEnumerable : IStructEnumerable<TIn, TEnumerator>
    {
        private TFunction function;
        private TEnumerable inner;
        public WhereEnumerable(ref TFunction function, ref TEnumerable inner)
        {
            this.function = function;
            this.inner = inner;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public WhereEnumerator<TIn, TEnumerator, TFunction> GetEnumerator()
        {
            var enumerator = inner.GetEnumerator();
            return new WhereEnumerator<TIn, TEnumerator, TFunction>(ref function, ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Visit<TVisitor>(TVisitor visitor)
            where TVisitor : IVisitor<TIn>
        {
            foreach (var input in this)
            {
                if (!visitor.Visit(input))
                    return;
            }
        }
    }
}
