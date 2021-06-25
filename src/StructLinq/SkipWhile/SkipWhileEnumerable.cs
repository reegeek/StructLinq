using System.Runtime.CompilerServices;

namespace StructLinq.SkipWhile
{
    public readonly struct SkipWhileEnumerable<T, TFunction, TEnumerable, TEnumerator> : IStructEnumerable<T, SkipWhileEnumerator<T, TFunction, TEnumerator>>
        where TFunction : struct, IFunction<T, bool>
        where TEnumerator : struct, IStructEnumerator<T>
        where TEnumerable : IStructEnumerable<T, TEnumerator>
    {
        private readonly TEnumerable enumerable;
        private readonly TFunction predicate;

        public SkipWhileEnumerable(TEnumerable enumerable, TFunction predicate)
        {
            this.enumerable = enumerable;
            this.predicate = predicate;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public SkipWhileEnumerator<T, TFunction, TEnumerator> GetEnumerator()
        {
            return new(predicate, enumerable.GetEnumerator());
        }
    }
}
