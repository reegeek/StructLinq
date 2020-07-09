

// ReSharper disable once CheckNamespace

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StructLinq
{
    public static partial class StructEnumerable
    {
        private static void FillList<T, TEnumerator>(List<T> list, TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                list.Add(current);
            }
            enumerator.Dispose();
        }

        private static void RefFillList<T, TEnumerator>(List<T> list, TEnumerator enumerator)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                list.Add(current);
            }
            enumerator.Dispose();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static List<T> ToList<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var list = new List<T>();
            FillList(list, enumerable.GetEnumerator());
            return list;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static List<T> ToList<T, TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var list = new List<T>();
            RefFillList(list, enumerable.GetEnumerator());
            return list;
        }

    }
}
