using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StructLinq.OrderBy
{
    internal class QuickSort
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Sort<T, TComparer>(int[] map, int left, int right, T[] keys, ref TComparer comparer)
            where TComparer : IComparer<T>
        {
            do
            {
                int i = left;
                int j = right;
                int x = map[i + ((j - i) >> 1)];
                do
                {
                    while (i < map.Length && comparer.Compare(keys[x], keys[map[i]]) > 0)
                        i++;
                    while (j >= 0 && comparer.Compare(keys[x], keys[map[j]]) < 0)
                        j--;
                    if (i > j)
                        break;
                    if (i < j)
                    {
                        int temp = map[i];
                        map[i] = map[j];
                        map[j] = temp;
                    }

                    i++;
                    j--;
                } while (i <= j);

                if (j - left <= right - i)
                {
                    if (left < j)
                        Sort(map, left, j, keys, ref comparer);
                    left = i;
                }
                else
                {
                    if (i < right)
                        Sort(map, i, right, keys, ref comparer);
                    right = j;
                }
            } while (left < right);
        }
    }
}
