

// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    internal struct AllVisitor<T, TFunction> : IVisitor<T>
        where TFunction : IFunction<T, bool>
    {
        private readonly TFunction function;
        public AllVisitor(TFunction function)
        {
            this.function = function;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Visit(T input)
        {
            return function.Eval(input);
        }
    }

    internal struct AllVisitor<T> : IVisitor<T>
    {
        private readonly Func<T, bool> function;
        public AllVisitor(Func<T, bool> function)
        {
            this.function = function;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Visit(T input)
        {
            return function(input);
        }
    }

    public readonly partial struct StructEnumerable<T, TEnumerable, TEnumerator> 
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool All(Func<T, bool> predicate, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
        {
            var visitor = new AllVisitor<T>(predicate);
            return enumerable.Visit(ref visitor) == VisitStatus.EnumeratorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool All(Func<T, bool> predicate)
        {
            var visitor = new AllVisitor<T>(predicate);
            return enumerable.Visit(ref visitor) == VisitStatus.EnumeratorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool All<TFunction>(ref TFunction predicate, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TFunction : IFunction<T, bool>
        {
            var visitor = new AllVisitor<T, TFunction>(predicate);
            return enumerable.Visit(ref visitor) == VisitStatus.EnumeratorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool All<TFunction>(ref TFunction predicate)
            where TFunction : IFunction<T, bool>
        {
            var visitor = new AllVisitor<T, TFunction>(predicate);
            return enumerable.Visit(ref visitor) == VisitStatus.EnumeratorFinished;
        }
    }

    public readonly partial struct StructCollection<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool All(Func<T, bool> predicate, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
        {
            var visitor = new AllVisitor<T>(predicate);
            return enumerable.Visit(ref visitor) == VisitStatus.EnumeratorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool All(Func<T, bool> predicate)
        {
            var visitor = new AllVisitor<T>(predicate);
            return enumerable.Visit(ref visitor) == VisitStatus.EnumeratorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool All<TFunction>(ref TFunction predicate, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TFunction : IFunction<T, bool>
        {
            var visitor = new AllVisitor<T, TFunction>(predicate);
            return enumerable.Visit(ref visitor) == VisitStatus.EnumeratorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool All<TFunction>(ref TFunction predicate)
            where TFunction : IFunction<T, bool>
        {
            var visitor = new AllVisitor<T, TFunction>(predicate);
            return enumerable.Visit(ref visitor) == VisitStatus.EnumeratorFinished;
        }
    }

}
