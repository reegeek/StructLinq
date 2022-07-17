// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct RefStructEnumerable<T, TEnumerable, TEnumerator> 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool RefTryInnerLast(ref TEnumerator enumerator, ref T last)
        {
            if (enumerator.MoveNext())
            {
                do
                {
                    ref var current = ref enumerator.Current;
                    last = current;
                }
                while (enumerator.MoveNext());
                enumerator.Dispose();
                return true;
            }
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool TryRefInnerLast(ref TEnumerator enumerator, Func<T, bool> predicate, ref T last)
        {
            bool found = false;
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                if (predicate(current))
                {
                    last = current;
                    found = true;
                }
            }
            enumerator.Dispose();
            return found;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool TryRefInnerLast<TFunc>(ref TEnumerator enumerator, ref TFunc predicate, ref T last)
            where TFunc : struct, IInFunction<T, bool>
        {
            bool found = false;
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                if (predicate.Eval(in current))
                {
                    last = current;
                    found = true;
                }
            }
            enumerator.Dispose();
            return found;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool TryLast(ref T last, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
        {
            var enumerator = enumerable.GetEnumerator();
            return RefTryInnerLast(ref enumerator, ref last);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryLast(ref T last)
        {
            var enumerator = enumerable.GetEnumerator();
            return RefTryInnerLast(ref enumerator, ref last);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool TryLast(Func<T, bool> predicate, ref T last, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
        {
            var enumerator = enumerable.GetEnumerator();
            return  TryRefInnerLast(ref enumerator, predicate, ref last);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryLast(Func<T, bool> predicate, ref T last)
        {
            var enumerator = enumerable.GetEnumerator();
            return  TryRefInnerLast(ref enumerator, predicate, ref last);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool TryLast<TFunc>(ref TFunc predicate, ref T last, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TFunc : struct, IInFunction<T, bool>
        {
            var enumerator = enumerable.GetEnumerator();
            return TryRefInnerLast(ref enumerator, ref predicate, ref last);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryLast<TFunc>(ref TFunc predicate, ref T last)
            where TFunc : struct, IInFunction<T, bool>
        {
            var enumerator = enumerable.GetEnumerator();
            return TryRefInnerLast(ref enumerator, ref predicate, ref last);
        }

    }
}