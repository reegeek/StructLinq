using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using StructLinq.Contains;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct StructEnum<T, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Contains<TComparer>(T x, TComparer comparer)
            where TComparer : IEqualityComparer<T>
        {
            var visitor = new ContainsVisitor<T, TComparer>(comparer, x);
            return Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool Contains<TComparer>(T x, TComparer comparer, Func<TEnumerator, IStructEnumerator<T>> _)
            where TComparer : IEqualityComparer<T>
        {
            var visitor = new ContainsVisitor<T, TComparer>(comparer, x);
            return Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

    }

    public static partial class StructEumerableExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<T, TEnumerator>(this StructEnum<T, TEnumerator> enumerable, T x)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            return enumerable.Contains(x, EqualityComparer<T>.Default);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<T, TEnumerator>(this StructEnum<T, TEnumerator> enumerable, T x, Func<TEnumerator, IStructEnumerator<T>> _)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            return enumerable.Contains(x, EqualityComparer<T>.Default);
        }
    }

    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<T, TEnumerable, TEnumerator, TComparer>(this TEnumerable enumerable, T x, TComparer comparer, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : IStructEnumerable<T, TEnumerator>
            where TComparer : IEqualityComparer<T>
        {
            var visitor = new ContainsVisitor<T, TComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, T x, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : IStructEnumerable<T, TEnumerator>
        {
            EqualityComparer<T> equalityComparer = EqualityComparer<T>.Default;
            var visitor = new ContainsVisitor<T, EqualityComparer<T>>(equalityComparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<T, TEnumerator, TComparer>(this IStructEnumerable<T, TEnumerator> enumerable, T x, TComparer comparer)
            where TEnumerator : struct, IStructEnumerator<T>
            where TComparer : IEqualityComparer<T>
        {
            var visitor = new ContainsVisitor<T, TComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, T x)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            EqualityComparer<T> equalityComparer = EqualityComparer<T>.Default;
            var visitor = new ContainsVisitor<T, EqualityComparer<T>>(equalityComparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }
    }
}
