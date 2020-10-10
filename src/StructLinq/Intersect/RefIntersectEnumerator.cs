using System.Runtime.CompilerServices;
using StructLinq.Utils.Collections;

namespace StructLinq.Intersect
{
    public struct RefIntersectEnumerator<T, TEnumerator1, TEnumerator2, TComparer> : IRefStructEnumerator<T>
        where TEnumerator1 : struct, IRefStructEnumerator<T>
        where TEnumerator2 : struct, IRefStructEnumerator<T>
        where TComparer : IInEqualityComparer<T>
    {
        private TEnumerator1 enumerator1;
        private TEnumerator2 enumerator2;
        private InPooledSet<T, TComparer> set;

        internal RefIntersectEnumerator(ref TEnumerator1 enumerator1, ref TEnumerator2 enumerator2, ref InPooledSet<T, TComparer> set)
            : this()
        {
            this.enumerator1 = enumerator1;
            this.enumerator2 = enumerator2;
            this.set = set;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            set.Dispose();
            enumerator1.Dispose();
            enumerator2.Dispose();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            while (enumerator1.MoveNext())
            {
                ref var current = ref enumerator1.Current;
                set.AddIfNotPresent(in current);
            }

            while (enumerator2.MoveNext())
            {
                ref var current = ref enumerator2.Current;
                if (set.Remove(in current))
                    return true;
            }

            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            set.Clear();
            enumerator1.Reset();
            enumerator2.Reset();
        }

        public ref T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => ref enumerator2.Current;
        }
    }
}
