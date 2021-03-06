﻿using System;

namespace StructLinq.ForEach
{
    readonly struct StructAction<T> : IAction<T>
    {
        #region private fields
        private readonly Action<T> action;
        #endregion
        public StructAction(Action<T> action)
        {
            this.action = action;
        }
        public void Do(T element)
        {
            action(element);
        }
    }
}