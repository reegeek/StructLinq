using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.IEnumerable;

namespace StructLinq.AsEnumerable
{
    public readonly struct EnumerableFromStructEnumerable<T, TEnumerator> : IEnumerable<T> 
        where TEnumerator : struct, IStructEnumerator<T>
    {
        private readonly IStructEnumerable<T, TEnumerator> structEnumerable;
        public EnumerableFromStructEnumerable(IStructEnumerable<T, TEnumerator> structEnumerable)
        {
            this.structEnumerable = structEnumerable;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public IEnumerator<T> GetEnumerator()
        {
            var structEnumerator = structEnumerable.GetEnumerator();
            return new StructEnumerator<T,TEnumerator>(structEnumerator);
        }
    }
}

