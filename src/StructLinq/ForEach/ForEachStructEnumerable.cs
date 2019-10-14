using System;
using System.Collections.Generic;
using StructLinq.ForEach;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        public static void ForEach<T, TEnumerator, TAction>(this IStructEnumerable<T, TEnumerator> enumerable, ref TAction action) 
            where TEnumerator : struct, IEnumerator<T>
            where TAction : struct, IAction<T>
        {
            using (var enumerator = enumerable.GetStructEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    action.Do(enumerator.Current);
                }
            }
        }
        public static void ForEach<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, Action<T> action)
            where TEnumerator : struct, IEnumerator<T>
        {
            var structAction = new StructAction<T>(action);
            enumerable.ForEach(ref structAction);
        }
    }
}