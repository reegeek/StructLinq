using System.Runtime.CompilerServices;

namespace StructLinq.Utils.Collections
{
    internal static class PoolLists
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Fill<T, TEnumerator>(ref PooledList<T> list, ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                list.Add(current);
            }
            enumerator.Dispose();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void FillRef<T, TEnumerator>(ref PooledList<T> list, ref TEnumerator enumerator)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                list.Add(ref current);
            }
            enumerator.Dispose();
        }

    }
}
