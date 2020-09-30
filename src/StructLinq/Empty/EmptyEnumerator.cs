using System;
using System.Runtime.CompilerServices;

namespace StructLinq.Empty
{
    public struct EmptyEnumerator<T> : IStructEnumerator<T>
    {
        public void Dispose()
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
        }

        public T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => throw new NotImplementedException();
        }
    }
}
