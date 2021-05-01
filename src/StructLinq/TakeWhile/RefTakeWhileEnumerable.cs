using System.Runtime.CompilerServices;

namespace StructLinq.TakeWhile
{
    public readonly struct RefTakeWhileEnumerable<T, TFunction, TEnumerable, TEnumerator> : IRefStructEnumerable<T, RefTakeWhileEnumerator<T, TFunction, TEnumerator>>
        where TFunction : struct, IInFunction<T, bool>
        where TEnumerator : struct, IRefStructEnumerator<T>
        where TEnumerable : IRefStructEnumerable<T, TEnumerator>
    {
        private readonly TEnumerable enumerable;
        private readonly TFunction predicate;

        public RefTakeWhileEnumerable(TEnumerable enumerable, TFunction predicate)
        {
            this.enumerable = enumerable;
            this.predicate = predicate;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefTakeWhileEnumerator<T, TFunction, TEnumerator> GetEnumerator()
        {
            return new(predicate, enumerable.GetEnumerator());
        }
    }
}
