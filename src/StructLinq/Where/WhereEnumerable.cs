using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.IEnumerable;

namespace StructLinq.Where
{
    public struct WhereEnumerable<TIn, TEnumerable, TEnumerator, TFunction> : IStructEnumerable<TIn, WhereEnumerator<TIn, TEnumerator, TFunction>>
        where TEnumerator : struct, IStructEnumerator<TIn> 
        where TFunction : struct, IFunction<TIn, bool>
        where TEnumerable : struct, IStructEnumerable<TIn, TEnumerator>
    {
        private TFunction function;
        private TEnumerable inner;
        public WhereEnumerable(ref TFunction function, ref TEnumerable inner)
        {
            this.function = function;
            this.inner = inner;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public WhereEnumerator<TIn, TEnumerator, TFunction> GetStructEnumerator()
        {
            var enumerator = inner.GetStructEnumerator();
            return new WhereEnumerator<TIn, TEnumerator, TFunction>(ref function, ref enumerator);
        }


        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<TIn> GetEnumerator()
        {
            return new StructEnumerator<TIn>(GetStructEnumerator());
        }

    }
}
