using System.Runtime.CompilerServices;

namespace StructLinq.TakeWhile
{
    public readonly struct TakeWhileEnumerable<T, TFunction, TEnumerable, TEnumerator> : IStructEnumerable<T, TakeWhileEnumerator<T, TFunction, TEnumerator>>
        where TFunction : struct, IFunction<T, bool>
        where TEnumerator : struct, IStructEnumerator<T>
        where TEnumerable : IStructEnumerable<T, TEnumerator>
    {
        private readonly TEnumerable enumerable;
        private readonly TFunction predicate;

        public TakeWhileEnumerable(TEnumerable enumerable, TFunction predicate)
        {
            this.enumerable = enumerable;
            this.predicate = predicate;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TakeWhileEnumerator<T, TFunction, TEnumerator> GetEnumerator()
        {
            return new(predicate, enumerable.GetEnumerator());
        }
    }
}
