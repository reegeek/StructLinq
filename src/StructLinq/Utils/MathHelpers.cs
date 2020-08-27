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
        public static int Min(params int[] tab)
        {
            int min = int.MaxValue;
            for (int i = 0; i < tab.Length; i++)
            {
                var a = tab[i];
                min = min > a ? a : min;
            }
            return min;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Max(params int[] tab)
        {
            int max = int.MinValue;
            for (int i = 0; i < tab.Length; i++)
            {
                var a = tab[i];
                max = max > a ? max : a;
            }
            return max;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Min(uint a, uint b)
        {
            return a > b ? b : a;
        }

    }
}