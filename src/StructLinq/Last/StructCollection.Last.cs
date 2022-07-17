// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct StructCollection<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public T Last(Func<TEnumerable, IStructCollection<T, TEnumerator>> _)
        {
            if (enumerable.Count == 0)
                throw new("No Elements");
            return enumerable.Get(enumerable.Count - 1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T Last()
        {
            if (enumerable.Count == 0)
                throw new("No Elements");
            return enumerable.Get(enumerable.Count - 1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public T Last(Func<T, bool> predicate, Func<TEnumerable, IStructCollection<T, TEnumerator>> _)
        {
            if (enumerable.Count == 0)
                throw new("No Elements");
            for (int i = enumerable.Count - 1; i >= 0; i--)
            {
                var first = enumerable.Get(i);
                if (predicate(first))
                    return first;
            }
            throw new("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T Last(Func<T, bool> predicate)
        {
            if (enumerable.Count == 0)
                throw new("No Elements");
            for (int i = enumerable.Count - 1; i >= 0; i--)
            {
                var first = enumerable.Get(i);
                if (predicate(first))
                    return first;
            }
            throw new("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public T Last<TFunc>(ref TFunc predicate, Func<TEnumerable, IStructCollection<T, TEnumerator>> _)
            where TFunc : struct, IFunction<T, bool>
        {
            if (enumerable.Count == 0)
                throw new("No Elements");
            for (int i = enumerable.Count - 1; i >= 0; i--)
            {
                var first = enumerable.Get(i);
                if (predicate.Eval(first))
                    return first;
            }
            throw new("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T Last<TFunc>(ref TFunc predicate)
            where TFunc : struct, IFunction<T, bool>
        {
            if (enumerable.Count == 0)
                throw new("No Elements");
            for (int i = enumerable.Count - 1; i >= 0; i--)
            {
                var first = enumerable.Get(i);
                if (predicate.Eval(first))
                    return first;
            }
            throw new("No Elements");
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool TryLast(ref T last, Func<TEnumerable, IStructCollection<T, TEnumerator>> _)
        {
            if (enumerable.Count == 0)
                return false;
            last = enumerable.Get(enumerable.Count - 1);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryLast(ref T last)
        {
            if (enumerable.Count == 0)
                return false;
            last = enumerable.Get(enumerable.Count - 1);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool TryLast(Func<T, bool> predicate, ref T last, Func<TEnumerable, IStructCollection<T, TEnumerator>> _)
        {
            if (enumerable.Count == 0)
                return false;
            for (int i = enumerable.Count - 1; i >= 0; i--)
            {
                last = enumerable.Get(i);
                if (predicate(last))
                    return true;
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
                last = enumerable.Get(i);
                if (predicate(last))
                    return true;
            }
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool TryLast<TFunc>(ref TFunc predicate, ref T last, Func<TEnumerable, IStructCollection<T, TEnumerator>> _)
            where TFunc : struct, IFunction<T, bool>
        {
            if (enumerable.Count == 0)
                return false;
            for (int i = enumerable.Count - 1; i >= 0; i--)
            {
                last = enumerable.Get(i);
                if (predicate.Eval(last))
                    return true;
            }
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryLast<TFunc>(ref TFunc predicate, ref T last)
            where TFunc : struct, IFunction<T, bool>
        {
            if (enumerable.Count == 0)
                return false;
            for (int i = enumerable.Count - 1; i >= 0; i--)
            {
                last = enumerable.Get(i);
                if (predicate.Eval(last))
                    return true;
            }
            return false;
        }

    }
}