// ReSharper disable InconsistentNaming

using System;

namespace StructLinq.BCL.List
{
#if (NETCOREAPP3_0 || NETCOREAPP3_1 || NET5_0)
    
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