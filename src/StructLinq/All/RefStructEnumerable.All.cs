

// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bool RefInnerAll<T, TEnumerator>(ref TEnumerator enumerator, Func<T, bool> predicate)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                if (!predicate(current))
                {
                    enumerator.Dispose();
                    return false;
                }
            }
            enumerator.Dispose();
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bool RefInnerAll<T, TEnumerator, TFunction>(ref TEnumerator enumerator, ref TFunction predicate)
        where TEnumerator : struct, IRefStructEnumerator<T>
        where TFunction : IInFunction<T, bool>
        {
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                if (!predicate.Eval(in current))
                {
                    enumerator.Dispose();
                    return false;
                }
            }
            enumerator.Dispose();
            return true;
        }
    }

    public readonly partial struct RefStructEnumerable<T, TEnumerable, TEnumerator>
        where TEnumerable : IRefStructEnumerable<T, TEnumerator>
        where TEnumerator : struct, IRefStructEnumerator<T>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool All(Func<T, bool> predicate, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
        {
            var enumerator = enumerable.GetEnumerator();
            return StructEnumerable.RefInnerAll(ref enumerator, predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool All(Func<T, bool> predicate)
        {
            var enumerator = enumerable.GetEnumerator();
            return StructEnumerable.RefInnerAll(ref enumerator, predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool All<TFunction>(ref TFunction predicate, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TFunction : IInFunction<T, bool>
        {
            var enumerator = enumerable.GetEnumerator();
            return StructEnumerable.RefInnerAll<T, TEnumerator, TFunction>(ref enumerator, ref predicate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool All<TFunction>(ref TFunction predicate)
            where TFunction : IInFunction<T, bool>
        {
            var enumerator = enumerable.GetEnumerator();
            return StructEnumerable.RefInnerAll<T, TEnumerator, TFunction>(ref enumerator, ref predicate);
        }
    }
}
