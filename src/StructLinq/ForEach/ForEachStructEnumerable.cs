using System;
using StructLinq.ForEach;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        private static void InternalForEach<T, TEnumerator, TAction>(ref TAction action, TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<T>
            where TAction : struct, IAction<T>
        {
            while (enumerator.MoveNext())
            {
                action.Do(enumerator.Current);
            }
        }

        public static void ForEach<T, TEnumerator, TAction>(this IStructEnumerable<T, TEnumerator> enumerable, ref TAction action) 
            where TEnumerator : struct, IStructEnumerator<T>
            where TAction : struct, IAction<T>
        {
            var enumerator = enumerable.GetEnumerator();
            InternalForEach<T, TEnumerator, TAction>(ref action, enumerator);
        }

        public static void ForEach<T, TEnumerator, TAction, TEnumerable>(this TEnumerable enumerable, ref TAction action, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TAction : struct, IAction<T>
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            while (enumerator.MoveNext())
            {
                action.Do(enumerator.Current);
            }
        }


        public static void ForEach<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, Action<T> action)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var structAction = new StructAction<T>(action);
            enumerable.ForEach(ref structAction);
        }

        public static void ForEach<T, TEnumerator, TEnumerable>(this TEnumerable enumerable, Action<T> action, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<T>
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            while (enumerator.MoveNext())
            {
                action(enumerator.Current);
            }
        }
    }
}