using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StructLinq
{
    public interface IStructEnumerable<out T, out TEnumerator>
        where TEnumerator : struct, IStructEnumerator<T>
    {
        TEnumerator GetEnumerator();

        VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<T>;
    }


    public interface IStructEnumerable2<T>
    {
        void Initialization();

        bool MoveNext();
        
        void Reset();
        
        T Current { get; }
    }

    public struct Enumerator<T, TEnumerable>
        where TEnumerable : IStructEnumerable2<T>
    {
        private TEnumerable enumerable;
        public Enumerator(TEnumerable enumerable)
        {
            this.enumerable = enumerable;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            return enumerable.MoveNext();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            enumerable.Reset();
        }

        public T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => enumerable.Current;
        }
    }
}
