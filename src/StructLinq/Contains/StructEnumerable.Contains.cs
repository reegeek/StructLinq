using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.Contains;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<T, TEnumerable, TEnumerator, TComparer>(this TEnumerable enumerable, T x, TComparer comparer, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : IStructEnumerable<T, TEnumerator>
            where TComparer : IEqualityComparer<T>
        {
            var visitor = new ContainsVisitor<T, TComparer>(comparer, x);
            var enumerator = enumerable.GetEnumerator();
            var result = enumerator.Visit(ref visitor) == VisitStatus.VisitorFinished;
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, T x, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : IStructEnumerable<T, TEnumerator>
        {
            EqualityComparer<T> equalityComparer = EqualityComparer<T>.Default;
            var visitor = new ContainsVisitor<T, EqualityComparer<T>>(equalityComparer, x);
            var enumerator = enumerable.GetEnumerator();
            var result = enumerator.Visit(ref visitor) == VisitStatus.VisitorFinished;
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<T, TEnumerator, TComparer>(this IStructEnumerable<T, TEnumerator> enumerable, T x, TComparer comparer)
            where TEnumerator : struct, IStructEnumerator<T>
            where TComparer : IEqualityComparer<T>
        {
            var visitor = new ContainsVisitor<T, TComparer>(comparer, x);
            var enumerator = enumerable.GetEnumerator();
            var result = enumerator.Visit(ref visitor) == VisitStatus.VisitorFinished;
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, T x)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            EqualityComparer<T> equalityComparer = EqualityComparer<T>.Default;
            var visitor = new ContainsVisitor<T, EqualityComparer<T>>(equalityComparer, x);
            var enumerator = enumerable.GetEnumerator();
            var result = enumerator.Visit(ref visitor) == VisitStatus.VisitorFinished;
            enumerator.Dispose();
            return result;
        }
    }
}
