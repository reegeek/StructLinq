using System;
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
    }
    
    public struct WhereEnumerable<TIn, TEnumerable, TEnumerator> : IStructEnumerable<TIn, WhereEnumerator<TIn, TEnumerator>>
        where TEnumerator : struct, IStructEnumerator<TIn> 
        where TEnumerable : IStructEnumerable<TIn, TEnumerator>
    {
        private Func<TIn, bool> function;
        private TEnumerable inner;
        public WhereEnumerable(Func<TIn, bool> function, ref TEnumerable inner)
        {
            this.function = function;
            this.inner = inner;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public WhereEnumerator<TIn, TEnumerator> GetEnumerator()
        {
            var enumerator = inner.GetEnumerator();
            return new WhereEnumerator<TIn, TEnumerator>(function, ref enumerator);
        }
    }
    
    internal struct WhereVisitor<TIn, TVisitor> : IVisitor<TIn>
            where TVisitor : IVisitor<TIn>
    {
        public Func<TIn, bool> function;
        public TVisitor visitor;

        public WhereVisitor(Func<TIn, bool> function, ref TVisitor visitor)
        {
            this.function = function;
            this.visitor = visitor;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Visit(TIn input)
        {
            return !function(input) || visitor.Visit(input);
        }
    }
}
