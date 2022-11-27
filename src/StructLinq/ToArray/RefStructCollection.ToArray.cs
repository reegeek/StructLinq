using System;
using System.Runtime.CompilerServices;
using StructLinq.Utils;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct RefStructCollec<T, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T[] ToArray()
        {
            var count = enumerator.Count;
            var result = ArrayHelpers.Create<T>(count);
            for (int i = 0; i < count; i++)
            {
                ref var item = ref result[i];
                ref var elt = ref enumerator.Get(i);
                item = elt;
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public T[] ToArray(Func<TEnumerator, IRefCollectionEnumerator<T>> _) => ToArray();

    }
}
