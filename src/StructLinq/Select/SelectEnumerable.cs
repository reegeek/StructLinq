using System.Runtime.CompilerServices;

namespace StructLinq.Select
{
    public struct SelectEnumerable<TIn, TOut, TEnumerable, TEnumerator, TFunction> : IStructEnumerable<TOut, SelectEnumerator<TIn, TOut, TEnumerator, TFunction>>
        where TFunction : struct, IFunction<TIn, TOut>
        where TEnumerator : struct, IStructEnumerator<TIn>
        where TEnumerable : IStructEnumerable<TIn, TEnumerator>
    {
        #region private fields
        private TFunction function;
        private TEnumerable inner;
        #endregion

        public SelectEnumerable(ref TFunction function, ref TEnumerable inner)
        {
            this.function = function;
            this.inner = inner;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public SelectEnumerator<TIn, TOut, TEnumerator, TFunction> GetEnumerator()
        {
            var typedEnumerator = inner.GetEnumerator();
            return new SelectEnumerator<TIn, TOut, TEnumerator, TFunction>(ref function, ref typedEnumerator);
        }

        internal TEnumerable Inner
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => inner;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<TOut>
        {
            foreach (var input in this)
            {
                if (!visitor.Visit(input))
                    return;
            }
        }
    }
}

    
