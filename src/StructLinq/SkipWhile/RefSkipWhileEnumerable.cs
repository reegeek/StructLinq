using System.Runtime.CompilerServices;

namespace StructLinq.SkipWhile
{
    public readonly struct RefSkipWhileEnumerable<T, TFunction, TEnumerable, TEnumerator> : IRefStructEnumerable<T, RefSkipWhileEnumerator<T, TFunction, TEnumerator>>
        where TFunction : struct, IInFunction<T, bool>
        where TEnumerator : struct, IRefStructEnumerator<T>
        where TEnumerable : IRefStructEnumerable<T, TEnumerator>
    {
        private readonly TEnumerable enumerable;
        private readonly TFunction predicate;

        public RefSkipWhileEnumerable(TEnumerable enumerable, TFunction predicate)
        {
            this.enumerable = enumerable;
            this.predicate = predicate;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefSkipWhileEnumerator<T, TFunction, TEnumerator> GetEnumerator()
        {
            return new(predicate, enumerable.GetEnumerator());
        }
    }
}
