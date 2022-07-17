// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct StructEnumerable<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool TryInnerLast(ref TEnumerator enumerator, ref T last)
        {
            if (enumerator.MoveNext())
            {
                T result;
                do
                {
                    result = enumerator.Current;

                }
                while (enumerator.MoveNext());
                enumerator.Dispose();
                last = result;
                return true;
            }
            enumerator.Dispose();
            return false;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool TryInnerLast(ref TEnumerator enumerator, Func<T, bool> predicate, ref T last)
        {
            bool found = false;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
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
        private static bool TryInnerLast<TFunc>(ref TEnumerator enumerator, ref TFunc predicate, ref T last)
            where TFunc : struct, IFunction<T, bool>
        {
            bool found = false;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                if (predicate.Eval(current))
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
        public T Last(Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
        {
            var enumerator = enumerable.GetEnumerator();
            T last = default;
            if (TryInnerLast(ref enumerator, ref last))
                return last;
            throw new("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T Last()
        {
            var enumerator = enumerable.GetEnumerator();
            T last = default;
            if (TryInnerLast(ref enumerator, ref last))
                return last;
            throw new("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public T Last(Func<T, bool> predicate, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
        {
            var enumerator = enumerable.GetEnumerator();
            T last = default;
            if (TryInnerLast(ref enumerator, predicate, ref last))
                return last;
            throw new("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T Last(Func<T, bool> predicate)
        {
            var enumerator = enumerable.GetEnumerator();
            T last = default;
            if (TryInnerLast(ref enumerator, predicate, ref last))
                return last;
            throw new("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public T Last<TFunc>(ref TFunc predicate, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TFunc : struct, IFunction<T, bool>
        {
            var enumerator = enumerable.GetEnumerator();
            T last = default;
            if (TryInnerLast(ref enumerator, ref predicate, ref last))
                return last;
            throw new("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool TryLast(ref T last, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
        {
            var enumerator = enumerable.GetEnumerator();
            return TryInnerLast(ref enumerator, ref last);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryLast(ref T last)
        {
            var enumerator = enumerable.GetEnumerator();
            return TryInnerLast(ref enumerator, ref last);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool TryLast(Func<T, bool> predicate, ref T last, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
        {
            var enumerator = enumerable.GetEnumerator();
            return TryInnerLast(ref enumerator, predicate, ref last);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryLast(Func<T, bool> predicate, ref T last)
        {
            var enumerator = enumerable.GetEnumerator();
            return TryInnerLast(ref enumerator, predicate, ref last);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool TryLast<TFunc>(ref TFunc predicate, ref T last, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TFunc : struct, IFunction<T, bool>
        {
            var enumerator = enumerable.GetEnumerator();
            return TryInnerLast(ref enumerator, ref predicate, ref last);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryLast<TFunc>(ref TFunc predicate, ref T last)
            where TFunc : struct, IFunction<T, bool>
        {
            var enumerator = enumerable.GetEnumerator();
            return TryInnerLast(ref enumerator, ref predicate, ref last);
        }

    }
}