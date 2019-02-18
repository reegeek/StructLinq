namespace StructLinq.ForEach
{
    struct StructActionFromInterface<T> : IAction<T>
    {
        #region private fields
        private readonly IAction<T> action;
        #endregion
        public StructActionFromInterface(IAction<T> action)
        {
            this.action = action;
        }
        public void Do(T element)
        {
            action.Do(element);
        }
    }
}