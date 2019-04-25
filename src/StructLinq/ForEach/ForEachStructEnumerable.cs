using System;
using System.Collections.Generic;
using StructLinq.ForEach;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        #region private methods
        private static void ForEach<T, TEnumerator, TAction>(TEnumerator enumerator, ref TAction action)
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
            where TEnumerator : struct, IEnumerator<T>
            where TAction : struct, IAction<T>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
            {
                ForEach<T, TEnumerator, TAction>(enumerator, ref action);
            }
        }
        public static void ForEach<T, TEnumerator>(this ITypedEnumerable<T, TEnumerator> enumerable, Action<T> action)
            where TEnumerator : struct, IEnumerator<T>
        {
            var structAction = new StructAction<T>(action);
            enumerable.ForEach(ref structAction);
        }
    }
}