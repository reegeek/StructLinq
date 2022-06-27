using System;
using System.Runtime.CompilerServices;

namespace StructLinq.Select
{
    public struct SelectCollection<TIn, TOut, TEnumerable, TEnumerator> : IStructCollection<TOut, SelectCollectionEnumerator<TIn, TOut, TEnumerator>>
        where TEnumerator : struct, ICollectionEnumerator<TIn>
        where TEnumerable : IStructCollection<TIn, TEnumerator>
    {
        #region private fields
        private Func<TIn, TOut> function;
        private TEnumerable inner;
        #endregion

        public SelectCollection(Func<TIn, TOut> function, ref TEnumerable inner)
        {
            this.function = function;
            this.inner = inner;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly SelectCollectionEnumerator<TIn, TOut, TEnumerator> GetEnumerator()
        {
            var typedEnumerator = inner.GetEnumerator();
            return new SelectCollectionEnumerator<TIn, TOut, TEnumerator>(function, ref typedEnumerator);
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
            return function(inner.Get(i));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly VisitStatus Visit<TVisitor>(ref TVisitor visitor) where TVisitor : IVisitor<TOut>
        {
            var selectVisitor = new SelectVisitor<TIn, TOut, TVisitor>(function, ref visitor);
            var visitStatus = inner.Visit(ref selectVisitor);
            visitor = selectVisitor.visitor;
            return visitStatus;
        }
    }

    public struct SelectCollection<TIn, TOut, TEnumerable, TEnumerator, TFunction> : IStructCollection<TOut, SelectCollectionEnumerator<TIn, TOut, TEnumerator, TFunction>>
        where TFunction : struct, IFunction<TIn, TOut>
        where TEnumerator : struct, ICollectionEnumerator<TIn>
        where TEnumerable : IStructCollection<TIn, TEnumerator>
    {
        #region private fields
        private TFunction function;
        private TEnumerable inner;
        #endregion

        public SelectCollection(ref TFunction function, ref TEnumerable inner)
        {
            this.function = function;
            this.inner = inner;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public SelectCollectionEnumerator<TIn, TOut, TEnumerator, TFunction> GetEnumerator()
        {
            var typedEnumerator = inner.GetEnumerator();
            return new SelectCollectionEnumerator<TIn, TOut, TEnumerator, TFunction>(ref function, ref typedEnumerator);
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
        public TOut Get(int i)
        {
            return function.Eval(inner.Get(i));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor) where TVisitor : IVisitor<TOut>
        {
            var selectVisitor = new SelectVisitor<TIn, TOut, TFunction, TVisitor>(ref function, ref visitor);
            var visitStatus = inner.Visit(ref selectVisitor);
            visitor = selectVisitor.visitor;
            return visitStatus;
        }
    }
}