// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct RefStructEnumerable<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private bool TryRefInnerFirst(ref TEnumerator enumerator, ref T first)
        {
            if (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                enumerator.Dispose();
                first = current;
                return true;
            }
            enumerator.Dispose();
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private bool TryRefInnerFirst(ref TEnumerator enumerator, Func<T, bool> predicate, ref T first)
        {
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                if (predicate(current))
                {
                    first = current;
                    enumerator.Dispose();
                    return true;
                }
            }
            enumerator.Dispose();
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private bool TryRefInnerFirst<TFunc>(ref TEnumerator enumerator, ref TFunc predicate, ref T first)
            where TFunc : struct, IInFunction<T, bool>
        {
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                if (predicate.Eval(in current))
                {
                    first = current;
                    enumerator.Dispose();
                    return true;
                }
            }
            enumerator.Dispose();
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private T RefInnerFirst(ref TEnumerator enumerator)
        {
            if (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                enumerator.Dispose();
                return current;
            }
            enumerator.Dispose();
            throw new("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private T RefInnerFirst(ref TEnumerator enumerator, Func<T, bool> predicate)
        {
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                if (predicate(current))
                {
                    enumerator.Dispose();
                    return current;
                }
            }
            enumerator.Dispose();
            throw new("No Match");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private T RefInnerFirst<TFunc>(ref TEnumerator enumerator, ref TFunc predicate)
            where TFunc : struct, IFunction<T, bool>
        {
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                if (predicate.Eval(current))
                {
                    enumerator.Dispose();
                    return current;
                }
            }
            enumerator.Dispose();
            throw new("No Match");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public T First(Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
        {
            var enumerator = enumerable.GetEnumerator();
            return RefInnerFirst(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T First(this IRefStructEnumerable<T, TEnumerator> enumerable)
        {
            var enumerator = enumerable.GetEnumerator();
            return RefInnerFirst(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public T First(Func<T, bool> predicate, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
        {
            var enumerator = enumerable.GetEnumerator();
            return RefInnerFirst(ref enumerator, predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T First(Func<T, bool> predicate)
        {
            var enumerator = enumerable.GetEnumerator();
            return RefInnerFirst(ref enumerator, predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public T First<TFunc>(ref TFunc predicate, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TFunc : struct, IFunction<T, bool>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefInnerFirst<TFunc>(ref enumerator, ref predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T First<TFunc>(ref TFunc predicate)
            where TFunc : struct, IFunction<T, bool>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefInnerFirst<TFunc>(ref enumerator, ref predicate);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool TryFirst(ref T first, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
        {
            var enumerator = enumerable.GetEnumerator();
            return TryRefInnerFirst(ref enumerator, ref first);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryFirst(ref T first)
        {
            var enumerator = enumerable.GetEnumerator();
            return TryRefInnerFirst(ref enumerator, ref first);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool TryFirst(Func<T, bool> predicate, ref T first, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
        {
            var enumerator = enumerable.GetEnumerator();
            return TryRefInnerFirst(ref enumerator, predicate, ref first);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryFirst(Func<T, bool> predicate, ref T first)
        {
            var enumerator = enumerable.GetEnumerator();
            return TryRefInnerFirst(ref enumerator, predicate, ref first);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool TryFirst<TFunc>(ref TFunc predicate, ref T first, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TFunc : struct, IInFunction<T, bool>
        {
            var enumerator = enumerable.GetEnumerator();
            return TryRefInnerFirst(ref enumerator, ref predicate, ref first);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryFirst<TFunc>(ref TFunc predicate, ref T first)
            where TFunc : struct, IInFunction<T, bool>
        {
            var enumerator = enumerable.GetEnumerator();
            return TryRefInnerFirst(ref enumerator, ref predicate, ref first);
        }
    }
}