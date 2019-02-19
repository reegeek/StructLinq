using System;

namespace StructLinq.Aggregate
{
    struct FuncAggregation<T, TAccumulate> : IAggregation<T, TAccumulate>
    {
        #region private fields
        private readonly Func<TAccumulate, T, TAccumulate> func;
        #endregion
        public FuncAggregation(Func<TAccumulate, T, TAccumulate> func) : this()
        {
            this.func = func;
        }
        public void Aggregate(T element)
        {
            Result = func(Result, element);
        }
        public TAccumulate Result { get;  set; }
    }
}