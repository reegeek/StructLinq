namespace StructLinq.Aggregate
{
    struct AggregateAction<T, TAccumulate, TAggregation> : IAction<T>
        where TAggregation : struct, IAggregation<T, TAccumulate>
    {
        #region private fields
        private TAggregation aggregation;
        #endregion
        public AggregateAction(ref TAggregation aggregation)
        {
            this.aggregation = aggregation;
        }
        public void Do(T element)
        {
            aggregation.Aggregate(element);
        }
        public TAccumulate Result => aggregation.Result;
    }
}