﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StructLinq.IList;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IListEnumerable<T, IList<T>> ToStructEnumerable<T>(this IList<T> enumerable)
        {
            return new IListEnumerable<T, IList<T>>(enumerable, 0, enumerable.Count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IListEnumerable<T, TList> ToStructEnumerable<T, TList>(this TList enumerable, Func<TList, IList<T>> _) 
            where TList : IList<T>
        {
            return new IListEnumerable<T, TList>(enumerable, 0, enumerable.Count);
        }

    }
}
