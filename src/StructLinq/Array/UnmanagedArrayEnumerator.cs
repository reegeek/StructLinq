using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace StructLinq.Array
{
    public unsafe struct UnmanagedArrayEnumerator<T> : IEnumerator<T> where T : unmanaged
    {
        #region private fields
        private GCHandle handle;
        private T* ptr;
        private int index;
        private readonly int endIndex;
        private bool isInOfRange;
        #endregion
        public UnmanagedArrayEnumerator(ref T[] array)
        {
            handle = GCHandle.Alloc(array, GCHandleType.Pinned);
            ptr = (T*) handle.AddrOfPinnedObject();
            endIndex = array.Length;
            index = -1;
            isInOfRange = false;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            if (index >= endIndex)
            {
                isInOfRange = false;
                return false;
            }

            ++index;
            isInOfRange = index < endIndex;
            return isInOfRange;
        }
        public void Reset()
        {
            index = -1;
        }
        object IEnumerator.Current => Current;
        public void Dispose()
        {
            handle.Free();
            ptr = (T*) IntPtr.Zero;
        }
        public T Current
        {
            get
            {
                if (!isInOfRange)
                    throw new IndexOutOfRangeException();
                return *(ptr + index);
            }
        }
    }
}