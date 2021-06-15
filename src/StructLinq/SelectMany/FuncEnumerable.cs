using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.IEnumerable;

namespace StructLinq.SelectMany
{
    public readonly struct FuncEnumerable<TSource, TResult> : IFunction<TSource, StructEnumerableFromIEnumerable<TResult>>
    {
        private readonly Func<TSource, IEnumerable<TResult>> func;

        public FuncEnumerable(Func<TSource, IEnumerable<TResult>> func)
        {
            this.func = func;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnumerableFromIEnumerable<TResult> Eval(TSource element)
        {
            return func(element).ToStructEnumerable();
        }
    }

    public readonly struct FuncEnumerable<TSource, TResult, TResultEnumerable, TResultEnumerator> : IFunction<TSource, TResultEnumerable> 
        where TResultEnumerable : IStructEnumerable<TResult, TResultEnumerator>
        where TResultEnumerator : struct, IStructEnumerator<TResult>
    {
        private readonly Func<TSource, TResultEnumerable> func;

        public FuncEnumerable(Func<TSource, TResultEnumerable> func)
        {
            this.func = func;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TResultEnumerable Eval(TSource element)
        {
            return func(element);
        }
    }
}
