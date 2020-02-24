using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.ForEach;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        private static void InternalForEach<T, TEnumerator, TAction>(ref TAction action, TEnumerator enumerator)
            where TEnumerator : struct, IEnumerator<T>
            where TAction : struct, IAction<T>
        {
            while (enumerator.MoveNext())
            {
                action.Do(enumerator.Current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ForEach<T, TEnumerator, TAction>(this IStructEnumerable<T, TEnumerator> enumerable, ref TAction action) 
            where TEnumerator : struct, IEnumerator<T>
            where TAction : struct, IAction<T>
        {
            using (var enumerator = enumerable.GetStructEnumerator())
            {
                InternalForEach<T, TEnumerator, TAction>(ref action, enumerator);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ForEach<T, TEnumerator, TAction, TEnumerable>(this TEnumerable enumerable, ref TAction action, Func<(TEnumerable, TAction), (IStructEnumerable<T, TEnumerator>, IAction<T>)> _)
            where TEnumerator : struct, IEnumerator<T>
            where TAction : struct, IAction<T>
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
        {
            using (var enumerator = enumerable.GetStructEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    action.Do(enumerator.Current);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ForEach<T, TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, Action<T> action)
            where TEnumerator : struct, IEnumerator<T>
        {
            var structAction = new StructAction<T>(action);
            enumerable.ForEach(ref structAction);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ForEach<T, TEnumerator, TEnumerable>(this ref TEnumerable enumerable, Action<T> action, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IEnumerator<T>
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
        {
            using (var enumerator = enumerable.GetStructEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    action(enumerator.Current);
                }
            }
        }


    }
}