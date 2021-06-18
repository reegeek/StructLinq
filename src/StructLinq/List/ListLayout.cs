﻿#if !NETSTANDARD1_1
// ReSharper disable InconsistentNaming

using System;

namespace StructLinq.List
{
#if (NETCOREAPP3_0_OR_GREATER)
    
    internal class ListLayout<T>
    {
        internal T[] Items;
        internal int Size;
    }
#else
    internal class ListLayout<T>
    {
        internal T[] Items;
#pragma warning disable 649
        internal Object SyncRoot;
#pragma warning restore 649
        internal int Size;
    }
#endif

}
#endif