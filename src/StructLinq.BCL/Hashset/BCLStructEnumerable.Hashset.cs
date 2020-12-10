using System.Runtime.CompilerServices;
using StructLinq.BCL.Hashset;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class BCLStructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static HashsetEnumerable<T> ToStructEnumerable<T>(this System.Collections.Generic.HashSet<T> hashset)
        {
            return new HashsetEnumerable<T>(hashset);
        }
    }
}
