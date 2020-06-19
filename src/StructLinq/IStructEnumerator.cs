using System;

namespace StructLinq
{
    public interface IStructEnumerator<out T> : IDisposable
    {
        bool MoveNext();
        
        void Reset();
        
        T Current { get; }

    }
}
