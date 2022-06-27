using System;
using System.Runtime.CompilerServices;
using StructLinq.Concat;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct StructEnumerable<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last two arguments")]
        public StructEnumerable<T, ConcatEnumerable<T,TEnumerable, TEnumerable2, TEnumerator, TEnumerator2>, ConcatEnumerator<T, TEnumerator, TEnumerator2>> Concat<TEnumerable2, TEnumerator2>(
            StructEnumerable<T,TEnumerable2, TEnumerator2> enumerable2, 
            Func<TEnumerable2, IStructEnumerable<T, TEnumerator2>> __,
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable2 : struct, IStructEnumerable<T, TEnumerator2>
            where TEnumerator2 : struct, IStructEnumerator<T>
        {
            return new StructEnumerable<T, ConcatEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2>, ConcatEnumerator<T, TEnumerator, TEnumerator2>>(new ConcatEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2>(enumerable, enumerable2.enumerable));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnumerable<T, ConcatEnumerable<T,TEnumerable, TEnumerable2, TEnumerator, TEnumerator2>, ConcatEnumerator<T, TEnumerator, TEnumerator2>> Concat<TEnumerable2, TEnumerator2>(
            StructEnumerable<T,TEnumerable2, TEnumerator2> enumerable2)
            where TEnumerable2 : struct, IStructEnumerable<T, TEnumerator2>
            where TEnumerator2 : struct, IStructEnumerator<T>
        {
            return new StructEnumerable<T, ConcatEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2>, ConcatEnumerator<T, TEnumerator, TEnumerator2>>(new ConcatEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2>(enumerable, enumerable2.enumerable));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last two arguments")]
        public StructEnumerable<T, ConcatEnumerable<T,TEnumerable, TEnumerable2, TEnumerator, TEnumerator2>, ConcatEnumerator<T, TEnumerator, TEnumerator2>> Concat<TEnumerable2, TEnumerator2>(
            StructCollection<T,TEnumerable2, TEnumerator2> enumerable2, 
            Func<TEnumerable2, IStructCollection<T, TEnumerator2>> __,
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable2 : struct, IStructCollection<T, TEnumerator2>
            where TEnumerator2 : struct, ICollectionEnumerator<T>
        {
            return new StructEnumerable<T, ConcatEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2>, ConcatEnumerator<T, TEnumerator, TEnumerator2>>(new ConcatEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2>(enumerable, enumerable2.enumerable));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnumerable<T, ConcatEnumerable<T,TEnumerable, TEnumerable2, TEnumerator, TEnumerator2>, ConcatEnumerator<T, TEnumerator, TEnumerator2>> Concat<TEnumerable2, TEnumerator2>(
            StructCollection<T,TEnumerable2, TEnumerator2> enumerable2)
            where TEnumerable2 : struct, IStructCollection<T, TEnumerator2>
            where TEnumerator2 : struct, ICollectionEnumerator<T>
        {
            return new StructEnumerable<T, ConcatEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2>, ConcatEnumerator<T, TEnumerator, TEnumerator2>>(new ConcatEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2>(enumerable, enumerable2.enumerable));
        }

    }


    public partial struct RefStructEnumerable<T, TEnumerable, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public RefStructEnumerable<T, RefConcatEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2>,
            RefConcatEnumerator<T, TEnumerator, TEnumerator2>> Concat<TEnumerable2, TEnumerator2>(
            TEnumerable2 enumerable2,
            Func<TEnumerable2, IRefStructEnumerable<T, TEnumerator2>> __,
            Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerable2 : struct, IRefStructEnumerable<T, TEnumerator2>
            where TEnumerator2 : struct, IRefStructEnumerator<T>
        {
            return new
               RefStructEnumerable<T, RefConcatEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2>,
                    RefConcatEnumerator<T, TEnumerator, TEnumerator2>>(
                    new RefConcatEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2>(enumerable, enumerable2));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefStructEnumerable<T, RefConcatEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2>,
            RefConcatEnumerator<T, TEnumerator, TEnumerator2>> Concat<TEnumerable2, TEnumerator2>(
            TEnumerable2 enumerable2,
            Func<TEnumerable2, IRefStructEnumerable<T, TEnumerator2>> __)
            where TEnumerable2 : struct, IRefStructEnumerable<T, TEnumerator2>
            where TEnumerator2 : struct, IRefStructEnumerator<T>
        {
            return new
                RefStructEnumerable<T, RefConcatEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2>,
                    RefConcatEnumerator<T, TEnumerator, TEnumerator2>>(
                    new RefConcatEnumerable<T, TEnumerable, TEnumerable2, TEnumerator, TEnumerator2>(enumerable, enumerable2));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RefStructEnumerable<T,
            RefConcatEnumerable<T, TEnumerable, IRefStructEnumerable<T, TEnumerator2>, TEnumerator, TEnumerator2>,
            RefConcatEnumerator<T, TEnumerator, TEnumerator2>> Concat<TEnumerator2>(
            IRefStructEnumerable<T, TEnumerator2> enumerable2)
            where TEnumerator2 : struct, IRefStructEnumerator<T>
        {
            return new RefStructEnumerable<T,
                RefConcatEnumerable<T, TEnumerable, IRefStructEnumerable<T, TEnumerator2>, TEnumerator, TEnumerator2>,
                RefConcatEnumerator<T, TEnumerator, TEnumerator2>>(
                new RefConcatEnumerable<T, TEnumerable, IRefStructEnumerable<T, TEnumerator2>, TEnumerator, TEnumerator2>(
                    enumerable, enumerable2));
        }

    }
}
