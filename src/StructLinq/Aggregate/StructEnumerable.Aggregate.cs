using System;
using System.Runtime.CompilerServices;
using StructLinq.Aggregate;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        #region private methods
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TAccumulate Aggregate<T, TAccumulate, TEnumerator, TAggregation>(TEnumerator enumerator, TAccumulate seed, ref TAggregation aggregation)
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
    }

    public readonly partial struct StructEnumerable<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TAccumulate Aggregate<TAccumulate, TAggregation>(TAccumulate seed, ref TAggregation aggregation)
            where TAggregation : struct, IAggregation<T, TAccumulate>
        {
            var enumerator = enumerable.GetEnumerator();
            return StructEnumerable.Aggregate<T, TAccumulate, TEnumerator, TAggregation>(enumerator, seed, ref aggregation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TAccumulate Aggregate<TAccumulate>(TAccumulate seed, Func<TAccumulate, T, TAccumulate> func)
        {
            var aggregation = new FuncAggregation<T, TAccumulate>(func);
            return Aggregate(seed, ref aggregation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public TAccumulate Aggregate<TAccumulate, TAggregation>(TAccumulate seed, ref TAggregation aggregation, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TAggregation : struct, IAggregation<T, TAccumulate>
        {
            return Aggregate(seed, ref aggregation);
        }
    }

    public readonly partial struct StructCollection<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TAccumulate Aggregate<TAccumulate, TAggregation>(TAccumulate seed, ref TAggregation aggregation)
            where TAggregation : struct, IAggregation<T, TAccumulate>
        {
            var enumerator = enumerable.GetEnumerator();
            return StructEnumerable.Aggregate<T, TAccumulate, TEnumerator, TAggregation>(enumerator, seed, ref aggregation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TAccumulate Aggregate<TAccumulate>(TAccumulate seed, Func<TAccumulate, T, TAccumulate> func)
        {
            var aggregation = new FuncAggregation<T, TAccumulate>(func);
            return Aggregate(seed, ref aggregation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public TAccumulate Aggregate<TAccumulate, TAggregation>(TAccumulate seed, ref TAggregation aggregation, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TAggregation : struct, IAggregation<T, TAccumulate>
        {
            return Aggregate(seed, ref aggregation);
        }
    }
}

