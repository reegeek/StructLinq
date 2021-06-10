using System;
using System.Runtime.CompilerServices;
using StructLinq.Zip;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ZipEnumerable<T1, TEnumerable1, TEnumerator1, T2, TEnumerable2, TEnumerator2> SelectMany<T1, TEnumerable1, TEnumerator1, T2, TEnumerable2, TEnumerator2>(this TEnumerable1 enumerable1, TEnumerable2 enumerable2, 
                                                                                                                                                                        Func<TEnumerable1, IStructEnumerable<T1, TEnumerator1>> _,
                                                                                                                                                                        Func<TEnumerable2, IStructEnumerable<T2, TEnumerator2>> __)
            where TEnumerable1 : IStructEnumerable<T1, TEnumerator1>
            where TEnumerator1 : struct, IStructEnumerator<T1>
            where TEnumerable2 : IStructEnumerable<T2, TEnumerator2>
            where TEnumerator2 : struct, IStructEnumerator<T2>
        {
            return new (enumerable1, enumerable2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ZipEnumerable<T1, IStructEnumerable<T1, TEnumerator1>, TEnumerator1, T2, IStructEnumerable<T2, TEnumerator2>, TEnumerator2> SelectMany<T1, TEnumerator1, T2, TEnumerator2>(this IStructEnumerable<T1, TEnumerator1> enumerable1, IStructEnumerable<T2, TEnumerator2> enumerable2)
            where TEnumerator1 : struct, IStructEnumerator<T1>
            where TEnumerator2 : struct, IStructEnumerator<T2>
        {
            return new (enumerable1, enumerable2);
        }

    }
}
