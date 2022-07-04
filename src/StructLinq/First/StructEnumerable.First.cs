// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct StructEnumerable<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool TryInnerFirst(ref TEnumerator enumerator, ref T first)
        {
            if (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                enumerator.Dispose();
                first = current;
                return true;
            }
            enumerator.Dispose();
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private bool TryInnerFirst(ref TEnumerator enumerator, Func<T, bool> predicate, ref T first)
        {
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
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
        private bool TryInnerFirst<TFunc>(ref TEnumerator enumerator, ref TFunc predicate, ref T first)
            where TFunc : struct, IFunction<T, bool>
        {
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                if (predicate.Eval(current))
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
        private T InnerFirst(ref TEnumerator enumerator)
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
        private T InnerFirst(ref TEnumerator enumerator, Func<T, bool> predicate)
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
        private static T InnerFirst<TFunc>(ref TEnumerator enumerator, ref TFunc predicate)
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
        public T First(Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
        {
            var enumerator = enumerable.GetEnumerator();
            return InnerFirst(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T First()
        {
            var enumerator = enumerable.GetEnumerator();
            return InnerFirst(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public T First(Func<T, bool> predicate, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
        {
            var enumerator = enumerable.GetEnumerator();
            return InnerFirst(ref enumerator, predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T First(Func<T, bool> predicate)
        {
            var enumerator = enumerable.GetEnumerator();
            return InnerFirst(ref enumerator, predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public T First<TFunc>(ref TFunc predicate, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TFunc : struct, IFunction<T, bool>
        {
            var enumerator = enumerable.GetEnumerator();
            return InnerFirst<TFunc>(ref enumerator, ref predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T First<TFunc>(ref TFunc predicate)
            where TFunc : struct, IFunction<T, bool>
        {
            var enumerator = enumerable.GetEnumerator();
            return InnerFirst<TFunc>(ref enumerator, ref predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool TryFirst(ref T first, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
        {
            var enumerator = enumerable.GetEnumerator();
            return TryInnerFirst(ref enumerator, ref first);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryFirst(ref T first)
        {
            var enumerator = enumerable.GetEnumerator();
            return TryInnerFirst(ref enumerator, ref first);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool TryFirst(Func<T, bool> predicate, ref T first, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
        {
            var enumerator = enumerable.GetEnumerator();
            return TryInnerFirst(ref enumerator, predicate, ref first);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryFirst(Func<T, bool> predicate, ref T first)
        {
            var enumerator = enumerable.GetEnumerator();
            return TryInnerFirst(ref enumerator, predicate, ref first);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool TryFirst<TFunc>(ref TFunc predicate, ref T first, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TFunc : struct, IFunction<T, bool>
        {
            var enumerator = enumerable.GetEnumerator();
            return TryInnerFirst(ref enumerator, ref predicate, ref first);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool TryFirst<TFunc>(ref TFunc predicate, ref T first)
            where TFunc : struct, IFunction<T, bool>
        {
            var enumerator = enumerable.GetEnumerator();
            return TryInnerFirst(ref enumerator, ref predicate, ref first);
        }

    }
}