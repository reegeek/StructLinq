using System;
using System.Runtime.CompilerServices;

namespace StructLinq.Select
{
    public struct SelectEnumerator<TIn, TOut, TEnumerator, TFunction> : IStructEnumerator<TOut>
        where TFunction : struct, IFunction<TIn, TOut>
        where TEnumerator : struct, IStructEnumerator<TIn>
    {
        #region private fields
        private TFunction function;
        private TEnumerator enumerator;
        #endregion
        public SelectEnumerator(ref TFunction function, ref TEnumerator enumerator)
        {
            this.function = function;
            this.enumerator = enumerator;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            return enumerator.MoveNext();
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            enumerator.Reset();
        }
        public TOut Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => function.Eval(enumerator.Current);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            enumerator.Dispose();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor) where TVisitor : IVisitor<TOut>
        {
            var selectVisitor = new SelectVisitor<TIn, TOut, TFunction, TVisitor>(ref function, ref visitor);
            var visitStatus = enumerator.Visit(ref selectVisitor);
            visitor = selectVisitor.visitor;
            return visitStatus;
        }


    }

    public struct SelectEnumerator<TIn, TOut, TEnumerator> : IStructEnumerator<TOut>
        where TEnumerator : struct, IStructEnumerator<TIn>
    {
        #region private fields
        private Func<TIn, TOut> function;
        private TEnumerator enumerator;
        #endregion
        public SelectEnumerator(Func<TIn, TOut> function, ref TEnumerator enumerator)
        {
            this.function = function;
            this.enumerator = enumerator;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            return enumerator.MoveNext();
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            enumerator.Reset();
        }
        public TOut Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => function(enumerator.Current);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            enumerator.Dispose();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor) where TVisitor : IVisitor<TOut>
        {
            var selectVisitor = new SelectVisitor<TIn, TOut, TVisitor>(function, ref visitor);
            var visitStatus = enumerator.Visit(ref selectVisitor);
            visitor = selectVisitor.visitor;
            return visitStatus;
        }


    }
}