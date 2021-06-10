﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.IEnumerable;

namespace StructLinq
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
}