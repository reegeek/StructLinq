using System;
using System.Runtime.CompilerServices;
using StructLinq.ForEach;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct StructEnumerable<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InternalForEach<TAction>(ref TAction action, TEnumerator enumerator)
            where TAction : struct, IAction<T>
        {
            while (enumerator.MoveNext())
            {
                action.Do(enumerator.Current);
            }
            enumerator.Dispose();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ForEach<TAction>(ref TAction action) 
            where TAction : struct, IAction<T>
        {
            var enumerator = enumerable.GetEnumerator();
            InternalForEach(ref action, enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public void ForEach<TAction>(ref TAction action, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TAction : struct, IAction<T>
        {
            var enumerator = enumerable.GetEnumerator();
            while (enumerator.MoveNext())
            {
                action.Do(enumerator.Current);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ForEach(Action<T> action)
        {
            var structAction = new StructAction<T>(action);
            ForEach(ref structAction);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public void ForEach(Action<T> action, Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
        {
            var enumerator = enumerable.GetEnumerator();
            while (enumerator.MoveNext())
            {
                action(enumerator.Current);
            }
        }
    }
}