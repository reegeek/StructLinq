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
        public T Last(Func<TEnumerable, IRefStructCollection<T, TEnumerator>> _)
        {
            T last = default;
            if (TryLast(ref last))
                return last;
            throw new("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T Last()
        {
            T last = default;
            if (TryLast(ref last))
                return last;
            throw new("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public T Last(Func<T, bool> predicate, Func<TEnumerable, IRefStructCollection<T, TEnumerator>> _)
        {
            T last = default;
            if (TryLast(predicate, ref last))
                return last;
            throw new("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T Last(Func<T, bool> predicate)
        {
            T last = default;
            if (TryLast(predicate, ref last))
                return last;
            throw new("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public T Last<TFunc>(ref TFunc predicate, Func<TEnumerable, IRefStructCollection<T, TEnumerator>> _)
            where TFunc : struct, IInFunction<T, bool>
        {
            T last = default;
            if (TryLast(ref predicate, ref last))
                return last;
            throw new("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T Last<TFunc>(ref TFunc predicate)
            where TFunc : struct, IInFunction<T, bool>
        {
            T last = default;
            if (TryLast(ref predicate, ref last))
                return last;
            throw new("No Elements");
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool TryLast(ref T last, Func<TEnumerable, IRefStructCollection<T, TEnumerator>> _)
        {
            if (enumerable.Count == 0)
                return false;
            ref var result = ref enumerable.Get(enumerable.Count - 1);
            last = result;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryLast(ref T last)
        {
            if (enumerable.Count == 0)
                return false;
            ref var result = ref enumerable.Get(enumerable.Count - 1);
            last = result;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool TryLast(Func<T, bool> predicate, ref T last, Func<TEnumerable, IRefStructCollection<T, TEnumerator>> _)
        {
            if (enumerable.Count == 0)
                return false;
            for (int i = enumerable.Count - 1; i >= 0; i--)
            {
                ref var result = ref enumerable.Get(i);
                if (predicate(result))
                {
                    last = result;
                    return true;
                }
            }
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryLast(Func<T, bool> predicate, ref T last)
        {
            if (enumerable.Count == 0)
                return false;
            for (int i = enumerable.Count - 1; i >= 0; i--)
            {
                ref var result = ref enumerable.Get(i);
                if (predicate(result))
                {
                    last = result;
                    return true;
                }
            }
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool TryLast<TFunc>(ref TFunc predicate, ref T last, Func<TEnumerable, IRefStructCollection<T, TEnumerator>> _)
            where TFunc : struct, IInFunction<T, bool>
        {
            if (enumerable.Count == 0)
                return false;
            for (int i = enumerable.Count - 1; i >= 0; i--)
            {
                ref var result = ref enumerable.Get(i);
                if (predicate.Eval(in result))
                {
                    last = result;
                    return true;
                }
            }
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryLast<TFunc>(ref TFunc predicate, ref T last)
            where TFunc : struct, IInFunction<T, bool>
        {
            if (enumerable.Count == 0)
                return false;
            for (int i = enumerable.Count - 1; i >= 0; i--)
            {
                ref var result = ref enumerable.Get(i);
                if (predicate.Eval(in result))
                {
                    last = result;
                    return true;
                }
            }
            return false;
        }

    }
}