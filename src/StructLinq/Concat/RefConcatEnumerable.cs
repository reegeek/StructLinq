using System.Runtime.CompilerServices;

namespace StructLinq.Concat
{
    public readonly struct RefConcatEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2> : IRefStructEnumerable<T, RefConcatEnumerator<T, TEnumerator1, TEnumerator2>>
        where TEnumerable1 : IRefStructEnumerable<T, TEnumerator1>
        where TEnumerable2 : IRefStructEnumerable<T, TEnumerator2>
        where TEnumerator2 : struct, IRefStructEnumerator<T>
        where TEnumerator1 : struct, IRefStructEnumerator<T>
    {
        private readonly TEnumerable1 enumerable1;
        private readonly TEnumerable2 enumerable2;

        public RefConcatEnumerable(TEnumerable1 enumerable1, TEnumerable2 enumerable2)
        {
            this.enumerable1 = enumerable1;
            this.enumerable2 = enumerable2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefConcatEnumerator<T, TEnumerator1, TEnumerator2> GetEnumerator()
        {
            var enum1 = enumerable1.GetEnumerator();
            var enum2 = enumerable2.GetEnumerator();
            return new RefConcatEnumerator<T, TEnumerator1, TEnumerator2>(ref  enum1, ref  enum2);
        }
    }
}
