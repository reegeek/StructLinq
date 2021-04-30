using System.Runtime.CompilerServices;

namespace StructLinq.SkipWhile
{
    public struct RefSkipWhileEnumerator<T, TFunction, TEnumerator> : IRefStructEnumerator<T>
        where TFunction : struct, IInFunction<T, bool>
        where TEnumerator : struct, IRefStructEnumerator<T>

    {
        private bool skipDone;
        private TFunction predicate;
        private TEnumerator enumerator;

        public RefSkipWhileEnumerator(TFunction predicate, TEnumerator enumerator)
        {
            skipDone = false;
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
            if (skipDone)
                return enumerator.MoveNext();

            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                if (predicate.Eval(in current))
                    continue;
                skipDone = true;
                return true;
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
