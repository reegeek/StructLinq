using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructLinq.Repeat
{
    public readonly struct RepeatEnumerable<T> : IStructEnumerable<T, RepeatEnumerator<T>>
    {
        private readonly T element;
        private readonly uint count;

        public RepeatEnumerable(T element, uint count)
        {
            this.element = element;
            this.count = count;
        }

        public RepeatEnumerator<T> GetEnumerator()
        {
            return new RepeatEnumerator<T>(element, count);
        }
    }
}
