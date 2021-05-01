using System.Runtime.CompilerServices;

namespace StructLinq.TakeWhile
{
    public struct RefTakeWhileEnumerator<T, TFunction, TEnumerator> : IRefStructEnumerator<T>
        where TFunction : struct, IInFunction<T, bool>
        where TEnumerator : struct, IRefStructEnumerator<T>

    {
        private TFunction predicate;
        private TEnumerator enumerator;

        public RefTakeWhileEnumerator(TFunction predicate, TEnumerator enumerator)
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
                ref var current = ref enumerator.Current;
                return predicate.Eval(in current);
            }
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            enumerator.Reset();
        }

        public ref T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => ref enumerator.Current;
        }
    }
}
