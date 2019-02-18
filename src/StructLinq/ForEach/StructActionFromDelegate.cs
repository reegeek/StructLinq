using System;

namespace StructLinq.ForEach
{
    struct StructActionFromDelegate<T> : IAction<T>
    {
        #region private fields
        private readonly Action<T> action;
        #endregion
        public StructActionFromDelegate(Action<T> action)
        {
            this.action = action;
        }
        public void Do(T element)
        {
            action(element);
        }
    }
}