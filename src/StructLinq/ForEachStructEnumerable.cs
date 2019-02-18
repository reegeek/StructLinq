using System;
using System.Collections.Generic;

namespace StructLinq
{
    public static partial class StructEnumerable
    {
        #region private methods
        private static void ForEach<T, TEnumerator, TAction>(this TEnumerator enumerator, ref TAction action)
            where TEnumerator : IEnumerator<T>
            where TAction : struct, IAction<T>

        {
            while (enumerator.MoveNext())
            {
                action.Do(enumerator.Current);
            }
        }
        #endregion
        public static void ForEach<T, TEnumerator, TAction>(this ITypedEnumerable<T, TEnumerator> enumerable, ref TAction action) 
            where TEnumerator : IEnumerator<T>
            where TAction : struct, IAction<T>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
            {
                ForEach<T, TEnumerator, TAction>(enumerator, ref action);
            }
        }
        public static void ForEach<T, TEnumerator>(this ITypedEnumerable<T, TEnumerator> enumerable, IAction<T> action)
            where TEnumerator : IEnumerator<T>
        {
            var structAction = new StructActionFromInterface<T>(action);
            enumerable.ForEach(ref structAction);
        }
        public static void ForEach<T, TEnumerator>(this ITypedEnumerable<T, TEnumerator> enumerable, Action<T> action)
            where TEnumerator : IEnumerator<T>
        {
            var structAction = new StructActionFromDelegate<T>(action);
            enumerable.ForEach(ref structAction);
        }
    }

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