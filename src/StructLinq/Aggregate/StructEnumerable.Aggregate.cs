using System;
using System.Runtime.CompilerServices;
using StructLinq.Aggregate;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    //TODO use visitor
    public partial struct StructEnum<T, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TAccumulate Aggregate<TAccumulate, TAggregation>(TAccumulate seed, ref TAggregation aggregation)
            where TAggregation : struct, IAggregation<T, TAccumulate>
        {
            aggregation.Result = seed;
            var copy = enumerator;
            while (copy.MoveNext())
            {
                aggregation.Aggregate(copy.Current);
            }
            return aggregation.Result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TAccumulate Aggregate<TAccumulate>(TAccumulate seed, Func<TAccumulate, T, TAccumulate> func)
        {
            var aggregation = new FuncAggregation<T, TAccumulate>(func);
            return Aggregate(seed, ref aggregation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public TAccumulate Aggregate<TAccumulate, TAggregation>(TAccumulate seed, ref TAggregation aggregation, Func<TEnumerator, IStructEnumerator<T>> _)
            where TAggregation : struct, IAggregation<T, TAccumulate>
        {
            return Aggregate<TAccumulate, TAggregation>(seed, ref aggregation);
        }
    }


    public static partial class StructEnumerable
    {
        #region private methods
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TAccumulate Aggregate<T, TAccumulate, TEnumerator, TAggregation>(this IStructEnumerable<T, TEnumerator> enumerable, TAccumulate seed, ref TAggregation aggregation)
            where TEnumerator : struct, IStructEnumerator<T>
            where TAggregation : struct, IAggregation<T, TAccumulate>
        {
            var enumerator = enumerable.GetEnumerator();
            return Aggregate<T, TAccumulate, TEnumerator, TAggregation>(enumerator, seed, ref aggregation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TAccumulate Aggregate<T, TAccumulate, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, TAccumulate seed, Func<TAccumulate, T, TAccumulate> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var aggregation = new FuncAggregation<T, TAccumulate>(func);
            return enumerable.Aggregate(seed, ref aggregation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TAccumulate Aggregate<T, TAccumulate,TEnumerable, TEnumerator, TAggregation>(this TEnumerable enumerable, TAccumulate seed, ref TAggregation aggregation, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TAggregation : struct, IAggregation<T, TAccumulate>
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return Aggregate<T, TAccumulate, TEnumerator, TAggregation>(enumerator, seed, ref aggregation);
        }

    }
}

