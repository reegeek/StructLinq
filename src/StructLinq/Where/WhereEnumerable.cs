using System;
using System.Collections.Generic;
using System.Text;

namespace StructLinq.Where
{
    class WhereEnumerable<TIn, TEnumerator, TFunction> : AbstractTypedEnumerable<TIn, WhereEnumerator<TIn, TEnumerator, TFunction>>
        where TEnumerator : IEnumerator<TIn> 
        where TFunction : IFunction<TIn, bool>
    {
        private TFunction function;
        private readonly ITypedEnumerable<TIn, TEnumerator> inner;
        public WhereEnumerable(ref TFunction function, ITypedEnumerable<TIn, TEnumerator> inner)
        {
            this.function = function;
            this.inner = inner;
        }
        public override WhereEnumerator<TIn, TEnumerator, TFunction> GetTypedEnumerator()
        {
            var enumerator = inner.GetTypedEnumerator();
            return new WhereEnumerator<TIn, TEnumerator, TFunction>(ref function, ref enumerator);
        }
    }
}
