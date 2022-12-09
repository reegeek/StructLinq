

// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct StructEnum<T, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Any()
        {
            var copy = enumerator;
            var result = copy.MoveNext();
            copy.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool Any(Func<TEnumerator, IStructEnumerator<T>> _)
        {
            var copy = enumerator;
            var result = copy.MoveNext();
            copy.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Any(Func<T, bool> predicate)
        {
            var copy = enumerator;
            while (copy.MoveNext())
            {
                var current = copy.Current;
                if (predicate(current))
                {
                    enumerator.Dispose();
                    return true;
                }
            }
            copy.Dispose();
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool Any(Func<T, bool> predicate, Func<TEnumerator, IStructEnumerator<T>> _)
        {
            var copy = enumerator;
            while (copy.MoveNext())
            {
                var current = copy.Current;
                if (predicate(current))
                {
                    enumerator.Dispose();
                    return true;
                }
            }
            copy.Dispose();
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Any<TFunction>(ref TFunction predicate)
               where TFunction : struct, IFunction<T, bool>
        {
            var copy = enumerator;
            while (copy.MoveNext())
            {
                var current = copy.Current;
                if (predicate.Eval(current))
                {
                    copy.Dispose();
                    return true;
                }
            }
            copy.Dispose();
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool Any<TFunction>(ref TFunction predicate, Func<TEnumerator, IStructEnumerator<T>> _)
               where TFunction : struct, IFunction<T, bool>
        {
            var copy = enumerator;
            while (copy.MoveNext())
            {
                var current = copy.Current;
                if (predicate.Eval(current))
                {
                    copy.Dispose();
                    return true;
                }
            }
            copy.Dispose();
            return false;
        }
    }

    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool InnerAny<T, TEnumerator>(ref TEnumerator enumerator, Func<T, bool> predicate)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                if (predicate(current))
                {
                    enumerator.Dispose();
                    return true;
                }
            }
            enumerator.Dispose();
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool InnerAny<T, TEnumerator, TFunction>(ref TEnumerator enumerator, ref TFunction predicate)
        where TEnumerator : struct, IStructEnumerator<T>
        where TFunction : IFunction<T, bool>
        {
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                if (predicate.Eval(current))
                {
                    enumerator.Dispose();
                    return true;
                }
            }
            enumerator.Dispose();
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Any<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            var result = enumerator.MoveNext();
            enumerator.Dispose();
            return result;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Any<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<T, bool> predicate, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return InnerAny(ref enumerator, predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Any<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, Func<T, bool> predicate)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return InnerAny(ref enumerator, predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Any<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            var result = enumerator.MoveNext();
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Any<T, TEnumerable, TEnumerator, TFunction>(this TEnumerable enumerable, ref TFunction predicate, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunction : IFunction<T, bool>
        {
            var enumerator = enumerable.GetEnumerator();
            return InnerAny<T, TEnumerator, TFunction>(ref enumerator, ref predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Any<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, IFunction<T, bool> predicate)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return InnerAny<T, TEnumerator, IFunction<T, bool>>(ref enumerator, ref predicate);
        }
    }
}
