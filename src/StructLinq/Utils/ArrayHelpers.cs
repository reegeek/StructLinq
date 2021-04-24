using System;
using System.Runtime.CompilerServices;

namespace StructLinq.Utils
{
    public static class ArrayHelpers
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T[] Create<T>(int count)
        {
#if NET5_0_OR_GREATER
            return GC.AllocateUninitializedArray<T>(count);
#else
            return new T[count];
#endif
        }
    }
}