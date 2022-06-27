using System.Runtime.CompilerServices;

namespace StructLinq.Select
{
    public struct RefSelectCollection<TIn, TOut, TEnumerable, TEnumerator, TFunction> : IStructCollection<TOut, RefSelectCollectionEnumerator<TIn, TOut, TEnumerator, TFunction>>
        where TFunction : struct, IInFunction<TIn, TOut>
        where TEnumerator : struct, IRefCollectionEnumerator<TIn>
        where TEnumerable : IRefStructCollection<TIn, TEnumerator>
    {
        #region private fields
        private TFunction function;
        private TEnumerable inner;
        #endregion

        public RefSelectCollection(ref TFunction function, ref TEnumerable inner)
        {
            this.function = function;
            this.inner = inner;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefSelectCollectionEnumerator<TIn, TOut, TEnumerator, TFunction> GetEnumerator()
        {
            var typedEnumerator = inner.GetEnumerator();
            return new RefSelectCollectionEnumerator<TIn, TOut, TEnumerator, TFunction>(ref function, ref typedEnumerator);
        }

        public readonly int Count
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => inner.Count;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Slice(uint start, uint? length)
        {
            inner.Slice(start, length);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public object Clone()
        {
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly TOut Get(int i)
        {
            return function.Eval(inner.Get(i));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly VisitStatus Visit<TVisitor>(ref TVisitor visitor) where TVisitor : IVisitor<TOut>
        {
            var count = Count;
            for (int i = 0; i < count; i++)
            {
                var tout = Get(i);
                if (!visitor.Visit(tout))
                    return VisitStatus.VisitorFinished;
            }
            return VisitStatus.EnumeratorFinished;
        }
    }
}