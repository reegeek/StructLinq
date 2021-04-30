using System;
using System.Runtime.CompilerServices;

namespace StructLinq.SkipWhile
{
    public struct SkipWhileEnumerator<T, TFunction, TEnumerator> : IStructEnumerator<T>
        where TFunction : struct, IFunction<T, bool>
        where TEnumerator : struct, IStructEnumerator<T>

    {
        private bool skipDone;
        private TFunction predicate;
        private TEnumerator enumerator;

        public SkipWhileEnumerator(TFunction predicate, TEnumerator enumerator)
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
                var element = enumerator.Current;
                if (predicate.Eval(element))
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

        public T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => enumerator.Current;
        }
    }
}
