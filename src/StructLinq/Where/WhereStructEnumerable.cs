using System;
using StructLinq.Where;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        public static WhereEnumerable<T, TEnumerable, TEnumerator, TFunction> Where<T, TEnumerable, TEnumerator, TFunction>(this TEnumerable enumerable, ref TFunction predicate, 
                                                                                                                            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunction : struct, IFunction<T, bool>
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
        {
            return new WhereEnumerable<T, TEnumerable, TEnumerator, TFunction>(ref predicate, ref enumerable);
        }
        public static WhereEnumerable<T, TEnumerable, TEnumerator, StructFunction<T, bool>> Where<T, TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<T, bool> predicate, 
                                                                                                                               Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
        {
            var structPredicate = predicate.ToStruct();
            return new WhereEnumerable<T, TEnumerable, TEnumerator, StructFunction<T, bool>>(ref structPredicate, ref enumerable);

        }
    }
}
