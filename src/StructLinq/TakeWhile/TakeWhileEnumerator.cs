using System.Runtime.CompilerServices;

namespace StructLinq.TakeWhile
{
    public struct TakeWhileEnumerator<T, TFunction, TEnumerator> : IStructEnumerator<T>
        where TFunction : struct, IFunction<T, bool>
        where TEnumerator : struct, IStructEnumerator<T>

    {
        private TFunction predicate;
        private TEnumerator enumerator;

        public TakeWhileEnumerator(TFunction predicate, TEnumerator enumerator)
        {
            this.predicate = predicate;
            this.enumerator = enumerator;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            enumerator.Dispose();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            while (enumerator.MoveNext())
            {
                var element = enumerator.Current;
                return predicate.Eval(element);
            }
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            enumerator.Reset();
        }

        public T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => enumerator.Current;
        }
    }
}
