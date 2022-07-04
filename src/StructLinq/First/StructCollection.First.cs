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
        public T First(Func<TEnumerable, IStructCollection<T, TEnumerator>> _)
        {
            if (enumerable.Count == 0)
                throw new("No Elements");
            return enumerable.Get(0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T First()
        {
            if (enumerable.Count == 0)
                throw new("No Elements");
            return enumerable.Get(0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public T First(Func<T, bool> predicate, Func<TEnumerable, IStructCollection<T, TEnumerator>> _)
        {
            if (enumerable.Count == 0)
                throw new("No Elements");
            for (int i = 0; i < enumerable.Count; i++)
            {
                var first = enumerable.Get(i);
                if (predicate(first))
                    return first;
            }
            throw new("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T First(Func<T, bool> predicate)
        {
            if (enumerable.Count == 0)
                throw new("No Elements");
            for (int i = 0; i < enumerable.Count; i++)
            {
                var first = enumerable.Get(i);
                if (predicate(first))
                    return first;
            }
            throw new("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public T First<TFunc>(ref TFunc predicate, Func<TEnumerable, IStructCollection<T, TEnumerator>> _)
            where TFunc : struct, IFunction<T, bool>
        {
            if (enumerable.Count == 0)
                throw new("No Elements");
            for (int i = 0; i < enumerable.Count; i++)
            {
                var first = enumerable.Get(i);
                if (predicate.Eval(first))
                    return first;
            }
            throw new("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T First<TFunc>(ref TFunc predicate)
            where TFunc : struct, IFunction<T, bool>
        {
            if (enumerable.Count == 0)
                throw new("No Elements");
            for (int i = 0; i < enumerable.Count; i++)
            {
                var first = enumerable.Get(i);
                if (predicate.Eval(first))
                    return first;
            }
            throw new("No Elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool TryFirst(ref T first, Func<TEnumerable, IStructCollection<T, TEnumerator>> _)
        {
            if (enumerable.Count == 0)
                return false;
            first = enumerable.Get(0);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryFirst(ref T first)
        {
            if (enumerable.Count == 0)
                return false;
            first = enumerable.Get(0);
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool TryFirst(Func<T, bool> predicate, ref T first, Func<TEnumerable, IStructCollection<T, TEnumerator>> _)
        {
            if (enumerable.Count == 0)
                return false;
            for (int i = 0; i < enumerable.Count; i++)
            {
                first = enumerable.Get(i);
                if (predicate(first))
                    return true;
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
                first = enumerable.Get(i);
                if (predicate(first))
                    return true;
            }
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool TryFirst<TFunc>(ref TFunc predicate, ref T first, Func<TEnumerable, IStructCollection<T, TEnumerator>> _)
            where TFunc : struct, IFunction<T, bool>
        {
            if (enumerable.Count == 0)
                return false;
            for (int i = 0; i < enumerable.Count; i++)
            {
                first = enumerable.Get(i);
                if (predicate.Eval(first))
                    return true;
            }
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryFirst<TFunc>(ref TFunc predicate, ref T first)
            where TFunc : struct, IFunction<T, bool>
        {
            if (enumerable.Count == 0)
                return false;
            for (int i = 0; i < enumerable.Count; i++)
            {
                first = enumerable.Get(i);
                if (predicate.Eval(first))
                    return true;
            }
            return false;
        }

    }
}