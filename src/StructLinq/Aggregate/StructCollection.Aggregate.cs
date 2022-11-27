using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct StructCollec<T, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TAccumulate Aggregate<TAccumulate, TAggregation>(TAccumulate seed, ref TAggregation aggregation)
            where TAggregation : struct, IAggregation<T, TAccumulate>
        {
            return ToStructEnumerable().Aggregate(seed, ref aggregation);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TAccumulate Aggregate<TAccumulate>(TAccumulate seed, Func<TAccumulate, T, TAccumulate> func)
        {
            return ToStructEnumerable().Aggregate(seed, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public TAccumulate Aggregate<TAccumulate, TAggregation>(TAccumulate seed, ref TAggregation aggregation, Func<TEnumerator, IStructEnumerator<T>> _)
            where TAggregation : struct, IAggregation<T, TAccumulate>
        {
            return ToStructEnumerable().Aggregate(seed, ref aggregation);
        }
    }
}

