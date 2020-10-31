using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StructLinq.IList
{
    public struct IListEnumerator<T> : IStructEnumerator<T>
    {
        #region private fields
        private readonly IList<T> list;
        private readonly int endIndex;
        private int index;

        #endregion
        public IListEnumerator(IList<T> list, int start, int length)
        {
            this.list = list;
            endIndex = length - 1 + start;
            index = start - 1;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            return ++index <= endIndex;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            index = -1;
        }
        public T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => list[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            if (list is IDisposable dispose)
            {
                dispose.Dispose();
            }
        }
    }
}