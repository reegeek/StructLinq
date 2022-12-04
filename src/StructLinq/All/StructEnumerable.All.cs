

// ReSharper disable once CheckNamespace

using System;
using System.Linq;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct StructEnum<T, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool All(Func<T, bool> predicate)
        {
            var visitor = new AllVisitor(predicate);
            return Visit(ref visitor) == VisitStatus.EnumeratorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool All(Func<T, bool> predicate, Func<TEnumerator, IStructEnumerator<T>> _) => All(predicate);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool All<TFunction>(ref TFunction predicate)
            where TFunction : IFunction<T, bool>
        {
            var visitor = new AllVisitor<TFunction>(predicate);
            return Visit(ref visitor) == VisitStatus.EnumeratorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool All<TFunction>(ref TFunction predicate, Func<TEnumerator, IStructEnumerator<T>> _)
            where TFunction : IFunction<T, bool> => All(ref predicate);


        private readonly struct AllVisitor : IVisitor<T>
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

        private readonly struct AllVisitor<TFunction> : IVisitor<T>
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

    }

    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool All<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<T, bool> predicate, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var visitor = new AllVisitor<T>(predicate);
            return enumerable.Visit(ref visitor) == VisitStatus.EnumeratorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool All<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, Func<T, bool> predicate)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var visitor = new AllVisitor<T>(predicate);
            return enumerable.Visit(ref visitor) == VisitStatus.EnumeratorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool All<T, TEnumerable, TEnumerator, TFunction>(this TEnumerable enumerable, ref TFunction predicate, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunction : IFunction<T, bool>
        {
            var visitor = new AllVisitor<T, TFunction>(predicate);
            return enumerable.Visit(ref visitor) == VisitStatus.EnumeratorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool All<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, IFunction<T, bool> predicate)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var visitor = new AllVisitor<T, IFunction<T, bool>>(predicate);
            return enumerable.Visit(ref visitor) == VisitStatus.EnumeratorFinished;
        }

        private struct AllVisitor<T, TFunction> : IVisitor<T>
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

        private struct AllVisitor<T> : IVisitor<T>
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

    }
}
