using System;
using System.Runtime.CompilerServices;
using StructLinq.Concat;
using StructLinq.Union;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct StructEnum<T, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnum<T, ConcatEnumerator<T, TEnumerator, TEnumerator2>> Concat<TEnumerator2>(StructEnum<T, TEnumerator2> enumerable2)
            where TEnumerator2: struct, IStructEnumerator<T>
        {
            var copy = enumerator;
            var copy2 = enumerable2.enumerator;
            return new (new (ref copy, ref copy2));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnum<T, ConcatEnumerator<T, TEnumerator, TEnumerator2>> Concat<TEnumerator2>(StructCollec<T, TEnumerator2> enumerable2)
            where TEnumerator2: struct, ICollectionEnumerator<T>
            => Concat(enumerable2.ToStructEnumerable());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last 2 arguments")]
        public StructEnum<T, ConcatEnumerator<T, TEnumerator, TEnumerator2>> Concat<TEnumerator2>(StructEnum<T, TEnumerator2> enumerable2,
            Func<TEnumerator, IStructEnumerator<T>> _, Func<TEnumerator2, IStructEnumerator<T>> __)
            where TEnumerator2: struct, IStructEnumerator<T>
            => Concat(enumerable2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last 2 arguments")]
        public StructEnum<T, ConcatEnumerator<T, TEnumerator, TEnumerator2>> Concat<TEnumerator2>(StructCollec<T, TEnumerator2> enumerable2,
            Func<TEnumerator, IStructEnumerator<T>> _, Func<TEnumerator2, IStructEnumerator<T>> __)
            where TEnumerator2: struct, ICollectionEnumerator<T>
                    => Concat(enumerable2.ToStructEnumerable());
    }

    public static partial class StructEnumerable
    {

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ConcatEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2> Concat<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2>(this TEnumerable1 enumerable1, 
                                                                                                                                                                    TEnumerable2 enumerable2, Func<TEnumerable1, IStructEnumerable<T, TEnumerator1>> _,
                                                                                                                                                                    Func<TEnumerable2, IStructEnumerable<T, TEnumerator2>> __)
            where TEnumerable1 : IStructEnumerable<T, TEnumerator1>
            where TEnumerable2 : IStructEnumerable<T, TEnumerator2>
            where TEnumerator2 : struct, IStructEnumerator<T>
            where TEnumerator1 : struct, IStructEnumerator<T>
        {
            return new ConcatEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2>(enumerable1, enumerable2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ConcatEnumerable<T, IStructEnumerable<T, TEnumerator1>, IStructEnumerable<T, TEnumerator2>, TEnumerator1, TEnumerator2> 
            Concat<T, TEnumerator1, TEnumerator2>(this IStructEnumerable<T, TEnumerator1> enumerable1, 
                                                  IStructEnumerable<T, TEnumerator2> enumerable2) 
            where TEnumerator2 : struct, IStructEnumerator<T>
            where TEnumerator1 : struct, IStructEnumerator<T>
        {
            return new ConcatEnumerable<T, IStructEnumerable<T, TEnumerator1>, IStructEnumerable<T, TEnumerator2>, TEnumerator1, TEnumerator2>(enumerable1, enumerable2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefConcatEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2> Concat<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2>(this TEnumerable1 enumerable1,
                                                                                                                                                                       TEnumerable2 enumerable2, Func<TEnumerable1, IRefStructEnumerable<T, TEnumerator1>> _,
                                                                                                                                                                       Func<TEnumerable2, IRefStructEnumerable<T, TEnumerator2>> __)
            where TEnumerable1 : IRefStructEnumerable<T, TEnumerator1>
            where TEnumerable2 : IRefStructEnumerable<T, TEnumerator2>
            where TEnumerator2 : struct, IRefStructEnumerator<T>
            where TEnumerator1 : struct, IRefStructEnumerator<T>
        {
            return new RefConcatEnumerable<T, TEnumerable1, TEnumerable2, TEnumerator1, TEnumerator2>(enumerable1, enumerable2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefConcatEnumerable<T, IRefStructEnumerable<T, TEnumerator1>, IRefStructEnumerable<T, TEnumerator2>, TEnumerator1, TEnumerator2> 
            Concat<T, TEnumerator1, TEnumerator2>(this IRefStructEnumerable<T, TEnumerator1> enumerable1, 
                                                  IRefStructEnumerable<T, TEnumerator2> enumerable2) 
            where TEnumerator2 : struct, IRefStructEnumerator<T>
            where TEnumerator1 : struct, IRefStructEnumerator<T>
        {
            return new RefConcatEnumerable<T, IRefStructEnumerable<T, TEnumerator1>, IRefStructEnumerable<T, TEnumerator2>, TEnumerator1, TEnumerator2>(enumerable1, enumerable2);
        }

    }
}
