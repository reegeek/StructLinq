using System;
using StructLinq.Aggregate;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        #region private methods
        private static TAccumulate Aggregate<T, TAccumulate, TEnumerator, TAggregation>(TEnumerator enumerator, TAccumulate seed, ref TAggregation aggregation)
            where TEnumerator : IStructEnumerator<T>
            where TAggregation : struct, IAggregation<T, TAccumulate>
        {
            aggregation.Result = seed;
            while (enumerator.MoveNext())
            {
                aggregation.Aggregate(enumerator.Current);
            }
            return aggregation.Result;
        }
        #endregion
        public static TAccumulate Aggregate<T, TAccumulate, TEnumerator, TAggregation>(this IStructEnumerable<T, TEnumerator> enumerable, TAccumulate seed, ref TAggregation aggregation)
            where TEnumerator : struct, IStructEnumerator<T>
            where TAggregation : struct, IAggregation<T, TAccumulate>
        {
            var enumerator = enumerable.GetEnumerator();
            return Aggregate<T, TAccumulate, TEnumerator, TAggregation>(enumerator, seed, ref aggregation);
        }
        public static TAccumulate Aggregate<T, TAccumulate, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, TAccumulate seed, Func<TAccumulate, T, TAccumulate> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var aggregation = new FuncAggregation<T, TAccumulate>(func);
            return enumerable.Aggregate(seed, ref aggregation);
        }
    }
}

