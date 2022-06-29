﻿using System;
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
            return new(new (enumerable, enumerable2.enumerable));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnumerable<T, ConcatEnumerable<T,TEnumerable, TEnumerable2, TEnumerator, TEnumerator2>, ConcatEnumerator<T, TEnumerator, TEnumerator2>> Concat<TEnumerable2, TEnumerator2>(
            StructEnumerable<T,TEnumerable2, TEnumerator2> enumerable2)
            where TEnumerable2 : struct, IStructEnumerable<T, TEnumerator2>
            where TEnumerator2 : struct, IStructEnumerator<T>
        {
            return new(new (enumerable, enumerable2.enumerable));
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
            return new(new (enumerable, enumerable2.enumerable));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructEnumerable<T, ConcatEnumerable<T,TEnumerable, TEnumerable2, TEnumerator, TEnumerator2>, ConcatEnumerator<T, TEnumerator, TEnumerator2>> Concat<TEnumerable2, TEnumerator2>(
            StructCollection<T,TEnumerable2, TEnumerator2> enumerable2)
            where TEnumerable2 : struct, IStructCollection<T, TEnumerator2>
            where TEnumerator2 : struct, ICollectionEnumerator<T>
        {
            return new(new (enumerable, enumerable2.enumerable));
        }

    }
}
