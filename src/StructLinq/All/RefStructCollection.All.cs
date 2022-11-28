

// ReSharper disable once CheckNamespace

using System;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct RefStructCollec<T, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool All(Func<T, bool> predicate)
        {
            var copy = enumerator;
            var count = copy.Count;
            for (int i = 0; i < count; i++)
            {
                ref var current = ref copy.Get(i);
                if (!predicate(current))
                {
                    copy.Dispose();
                    return false;
                }
            }
            copy.Dispose();
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool All(Func<T, bool> predicate, Func<TEnumerator, IRefStructEnumerator<T>> _) => All(predicate);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool All<TFunction>(TFunction predicate)
            where TFunction : IInFunction<T, bool>
        {
            var copy = enumerator;
            var count = copy.Count;
            for (int i = 0; i < count; i++)
            {
                ref var current = ref copy.Get(i);
                if (!predicate.Eval(in current))
                {
                    copy.Dispose();
                    return false;
                }
            }
            copy.Dispose();
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public bool All<TFunction>(ref TFunction predicate, Func<TEnumerator, IRefStructCollection<T, TEnumerator>> _)
            where TFunction : IInFunction<T, bool>
        {
            return All(predicate);
        }
    }
}
