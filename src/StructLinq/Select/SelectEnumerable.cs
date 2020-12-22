using System;
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<TOut>
        {
            var selectVisitor = new SelectVisitor<TIn, TOut, TFunction, TVisitor>(ref function, ref visitor);
            var visitStatus = inner.Visit(ref selectVisitor);
            visitor = selectVisitor.visitor;
            return visitStatus;
        }
    }

    internal struct SelectVisitor<TIn, TOut, TFunction, TVisitor> : IVisitor<TIn> 
        where TFunction : struct, IFunction<TIn, TOut> where TVisitor : IVisitor<TOut>
    {
        public TFunction function;
        public TVisitor visitor;

        public SelectVisitor(ref TFunction function, ref TVisitor visitor)
        {
            this.function = function;
            this.visitor = visitor;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Visit(TIn input)
        {
            var output = function.Eval(input);
            return visitor.Visit(output);
        }
    }

    public struct
        SelectEnumerable<TIn, TOut, TEnumerable, TEnumerator> : IStructEnumerable<TOut,
            SelectEnumerator<TIn, TOut, TEnumerator>>
        where TEnumerator : struct, IStructEnumerator<TIn>
        where TEnumerable : IStructEnumerable<TIn, TEnumerator>
    {
        #region private fields
        private Func<TIn, TOut> function;
        private TEnumerable inner;
        #endregion

        public SelectEnumerable(Func<TIn, TOut> function, ref TEnumerable inner)
        {
            this.function = function;
            this.inner = inner;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public SelectEnumerator<TIn, TOut, TEnumerator> GetEnumerator()
        {
            var typedEnumerator = inner.GetEnumerator();
            return new SelectEnumerator<TIn, TOut, TEnumerator>(function, ref typedEnumerator);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<TOut>
        {
            var selectVisitor = new SelectVisitor<TIn, TOut, TVisitor>(function, ref visitor);
            var visitStatus = inner.Visit(ref selectVisitor);
            visitor = selectVisitor.visitor;
            return visitStatus;
        }
    }

    internal struct SelectVisitor<TIn, TOut, TVisitor> : IVisitor<TIn> where TVisitor : IVisitor<TOut>
    {
        public Func<TIn, TOut> function;
        public TVisitor visitor;

        public SelectVisitor(Func<TIn, TOut> function, ref TVisitor visitor)
        {
            this.function = function;
            this.visitor = visitor;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Visit(TIn input)
        {
            var output = function(input);
            return visitor.Visit(output);
        }
    }
}

    
