using System.Runtime.CompilerServices;

namespace StructLinq.Utils
{
    static class MathHelpers
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Min(int a, int b)
        {
            return a > b ? b : a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Min(uint a, uint b)
        {
            return a > b ? b : a;
        }

    }
}