using System;
using System.Runtime.CompilerServices;
using StructLinq.Utils;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct StructCollection<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static T[] ToArray(ref TEnumerator enumerator)
        {
            var count = enumerator.Count;
            var result = ArrayHelpers.Create<T>(count);
            for (int i = 0; i < count; i++)
            {
                result[i] = enumerator.Get(i);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public T[] ToArray(
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
        {
            var enumerator = enumerable.GetEnumerator();
            return ToArray(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T[] ToArray()
        {
            var enumerator = enumerable.GetEnumerator();
            return ToArray(ref enumerator);
        }
    }
}
