using System;

namespace StructLinq
{
    public interface IRefStructEnumerator<T> : IDisposable
    {
        bool MoveNext();

        void Reset();

        ref T Current { get; }
    }
}