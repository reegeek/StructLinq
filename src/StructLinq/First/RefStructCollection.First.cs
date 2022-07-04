// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct RefStructCollection<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public T First(Func<TEnumerable, IRefStructCollection<T, TEnumerator>> _)
        {
            T first = default;
            if (TryFirst(ref first, x => x))
                return first;
            throw new("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T First()
        {
            T first = default;
            if (TryFirst(ref first))
                return first;
            throw new("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public T First(Func<T, bool> predicate, Func<TEnumerable, IRefStructCollection<T, TEnumerator>> _)
        {
            T first = default;
            if (TryFirst(predicate, ref first))
                return first;
            throw new("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T First(Func<T, bool> predicate)
        {
            T first = default;
            if (TryFirst(predicate, ref first))
                return first;
            throw new("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public T First<TFunc>(ref TFunc predicate, Func<TEnumerable, IRefStructCollection<T, TEnumerator>> _)
            where TFunc : struct, IInFunction<T, bool>
        {
            T first = default;
            if (TryFirst(ref predicate, ref first))
                return first;
            throw new("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T First<TFunc>(ref TFunc predicate)
            where TFunc : struct, IInFunction<T, bool>
        {
            T first = default;
            if (TryFirst(ref predicate, ref first))
                return first;
            throw new("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool TryFirst(ref T first, Func<TEnumerable, IRefStructCollection<T, TEnumerator>> _)
        {
            if (enumerable.Count == 0)
                return false;
            ref var result = ref enumerable.Get(0);
            first = result;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryFirst(ref T first)
        {
            if (enumerable.Count == 0)
                return false;
            ref var result = ref enumerable.Get(0);
            first = result;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool TryFirst(Func<T, bool> predicate, ref T first, Func<TEnumerable, IRefStructCollection<T, TEnumerator>> _)
        {
            if (enumerable.Count == 0)
                return false;
            for (int i = 0; i < enumerable.Count; i++)
            {
                ref var result = ref enumerable.Get(i);
                if (predicate(result))
                {
                    first = result;
                    return true;
                }
            }
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryFirst(Func<T, bool> predicate, ref T first)
        {
            if (enumerable.Count == 0)
                return false;
            for (int i = 0; i < enumerable.Count; i++)
            {
                ref var result = ref enumerable.Get(i);
                if (predicate(result))
                {
                    first = result;
                    return true;
                }
            }
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool TryFirst<TFunc>(ref TFunc predicate, ref T first, Func<TEnumerable, IRefStructCollection<T, TEnumerator>> _)
            where TFunc : struct, IInFunction<T, bool>
        {
            if (enumerable.Count == 0)
                return false;

            for (int i = 0; i < enumerable.Count; i++)
            {
                ref var result = ref enumerable.Get(i);
                if (predicate.Eval(in result))
                {
                    first = result;
                    return true;
                }
            }
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryFirst<TFunc>(ref TFunc predicate, ref T first)
            where TFunc : struct, IInFunction<T, bool>
        {
            if (enumerable.Count == 0)
                return false;

            for (int i = 0; i < enumerable.Count; i++)
            {
                ref var result = ref enumerable.Get(i);
                if (predicate.Eval(in result))
                {
                    first = result;
                    return true;
                }
            }
            return false;
        }
    }
}