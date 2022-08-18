using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.Contains;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct StructEnumerable<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool Contains<TComparer>(T x, TComparer comparer, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TComparer : IEqualityComparer<T>
        {
            var visitor = new ContainsVisitor<T, TComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool Contains(T x, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
        {
            EqualityComparer<T> equalityComparer = EqualityComparer<T>.Default;
            var visitor = new ContainsVisitor<T, EqualityComparer<T>>(equalityComparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Contains<TComparer>(T x, TComparer comparer)
            where TComparer : IEqualityComparer<T>
        {
            var visitor = new ContainsVisitor<T, TComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Contains(T x)
        {
            EqualityComparer<T> equalityComparer = EqualityComparer<T>.Default;
            var visitor = new ContainsVisitor<T, EqualityComparer<T>>(equalityComparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }
    }
}
